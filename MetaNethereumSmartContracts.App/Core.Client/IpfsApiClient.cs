using Core.Client.Interface;
using Core.Client.Model;
using System.Text.Json;

namespace Core.Client
{
    public class IpfsApiClient : IIpfsApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly IpfsClientConfig _ipfsApiClientConfig;

        public IpfsApiClient(HttpClient httpClient, IpfsClientConfig ipfsClientConfig)
        {
            _httpClient = httpClient;
            _ipfsApiClientConfig = ipfsClientConfig;
        }

        public async Task<IpfsDataDto> GetParsedDataByContractUsingIpfsClient(string contractAddress)
        {
            string url = $"{_ipfsApiClientConfig.BaseUrl}/{contractAddress}";
            var content = await _httpClient.GetAsync(url);
            var response = await content.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IpfsDataDto>(response) ?? new IpfsDataDto();
        }
    }
}