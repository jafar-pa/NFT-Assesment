using Microsoft.AspNetCore.Server.IIS.Core;
using ParseToken.Service;

namespace NethereumSmartContracts.Api.Module
{
    public static class CoreModule
    {
        public static IServiceCollection RegisterServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IParseTokenService, ParseTokenService>();
            return serviceCollection;
        }
    }
}
