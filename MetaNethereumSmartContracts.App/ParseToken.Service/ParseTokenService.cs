using Nethereum.Web3;
using BoredApeYachtClubContracts.Contracts.IERC721Metadata;
using Common.Logging;
using Microsoft.Extensions.Configuration;
using Nethereum.JsonRpc.Client;
using Core.Client.Model;
using Core.Client.Interface;
using ParseToken.Service.Model;
using ParseToken.Service.Helper;
using System.Text.Json;
using System.Net.Http;
using System.Diagnostics.Metrics;
using SmartContract.Exception;

namespace ParseToken.Service
{
    public class ParseTokenService : IParseTokenService
    {
        private readonly IConfiguration _configuration;
        private readonly IIpfsApiClient _ipfsApiClient;
        private readonly IHttpClientFactory _httpClientFactory;
        public ParseTokenService(IConfiguration configuration, IIpfsApiClient ipfsApiClient, IHttpClientFactory httpClientFactory)
        {
            _configuration = configuration;
            _ipfsApiClient = ipfsApiClient;
            _httpClientFactory = httpClientFactory;
        }

        /// <summary>
        /// Here take the tokenId and contractAddress from the request 
        /// Instantiated the Web3 obj and IERC721MetaDataService class to obtain metadata for the NFT
        /// called service and fed the response for parsing the result to make desired output JSON format
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="contractAddress"></param>
        /// <returns>ParsedOutputDto</returns>
        /// <exception cref="RequestInvalidException"></exception>
        public async Task<ParsedOutputDto> GetMetadataFromTokenUri(int tokenId, string? contractAddress)
        {
            var url = _configuration.GetSection("InfuraUrl").Value;
            var web3 = new Web3(url);
            var service = new IERC721MetadataService(web3, contractAddress);
            var token = await service.TokenURIQueryAsync(tokenId);
            if (!string.IsNullOrEmpty(token))
                return await ProcessTokenUri(token);
            throw new RequestInvalidException("invalid token");

        }

        private async Task<ParsedOutputDto> ProcessTokenUri(string data)
        {
            if (data.Contains("base64"))
            {
                string decodedResult = DecodeBase64String(data.Split(",").Last());
                var decodedModel = GetIpfsDataFromDecodedResult(decodedResult);                
                return decodedModel.MapToParsedOutPutModel();
            }
            if (data.Contains("https"))
            {
                var httpClient = _httpClientFactory.CreateClient();
                var response = await httpClient.GetAsync(data);
                if (response != null && response.IsSuccessStatusCode == true)
                {
                    var content = await response.Content.ReadAsStringAsync();                    
                    var decodedModel = GetIpfsDataFromDecodedResult(content);
                    return decodedModel.MapToParsedOutPutModel();
                }
                throw new NotFoundException("specified token URI not supported");
            }
            string contractAddress = data.Split("//")[1];          
            if (contractAddress.Contains("ipfs"))
            {
                string[] url = contractAddress.Split("/");
                contractAddress = $"{url.Last()}";
            }
            var result = await _ipfsApiClient.GetParsedDataByContractUsingIpfsClient(contractAddress);
            return result.MapToParsedOutPutModel();

        }

        private IpfsDataDto GetIpfsDataFromDecodedResult(string decodedResult)
        {
            var model = JsonSerializer.Deserialize<IpfsDataDto>(decodedResult) ?? new IpfsDataDto();
            if (model == null)
                throw new RequestInvalidException("Current version of parser not supported at this time");
            return model;

        }

        private string DecodeBase64String(string encodedData)
        {
            var bencodedBytes = System.Convert.FromBase64String(encodedData);
            return System.Text.Encoding.UTF8.GetString(bencodedBytes);
        }
    }
}