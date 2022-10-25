using Core.Client.Model;
using ParseToken.Service.Model;

namespace ParseToken.Service.Helper
{
    public static class ParsedOutputMapper
    {
        public static ParsedOutputDto MapToParsedOutPutModel(this IpfsDataDto ipfsDataDto)
        {
            return new ParsedOutputDto()
            {
                Name = ipfsDataDto.name,
                Description = ipfsDataDto.description,
                Media = ipfsDataDto.image,
                Properties = (ipfsDataDto.attributes == null) ? null : ipfsDataDto.attributes.Select(d =>
                    new ParsedOutputProperties() { Category = d.trait_type, Property = d.value }
                ).ToList()

            };
        }
    }
}
