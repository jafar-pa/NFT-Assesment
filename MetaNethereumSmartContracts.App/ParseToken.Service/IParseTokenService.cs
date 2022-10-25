using ParseToken.Service.Model;

namespace ParseToken.Service
{
    public interface IParseTokenService
    {
        Task<ParsedOutputDto> GetMetadataFromTokenUri(int tokenId, string? contractAddress);
    }
}
