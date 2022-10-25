using Microsoft.AspNetCore.Mvc;
using ParseToken.Service;
using SmartContract.Exception;

namespace NethereumSmartContracts.Api.Controllers
{
    [Route("api/metadata/")]
    public class NFTMetaDataController : Controller
    {
        private IParseTokenService _parseTokenService;
        private readonly ILogger<NFTMetaDataController> _logger;
        public NFTMetaDataController(IParseTokenService parseTokenService, ILogger<NFTMetaDataController> logger)
        {
            _parseTokenService = parseTokenService;
            _logger = logger;
        }
        [HttpGet(Name = "Get")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetMetaData([FromHeader] string? contractAddress, int token)
        {
            try
            {
                if (string.IsNullOrEmpty(contractAddress))
                {
                    throw new RequestInvalidException($"invlaid contractAddress");
                }
                var metadata = await _parseTokenService.GetMetadataFromTokenUri(token, contractAddress);
                return Ok(metadata);
            }
            catch (NotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message,ex.StackTrace);
               return StatusCode(StatusCodes.Status500InternalServerError,ex.Message);
            }
           
          
        }
    }
}
