using Core.Client;
using Core.Client.Interface;
using Core.Client.Model;
using Polly;
using Polly.Contrib.WaitAndRetry;
using Polly.Extensions.Http;

namespace NethereumSmartContracts.Api.Module
{
    public static class IpfsDataCleintModule
    {
        public static IServiceCollection AddIpfsParserClient(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            var config = configuration.GetSection("IpfsClient").Get<IpfsClientConfig>();
            serviceCollection.AddSingleton(config);

            serviceCollection.AddHttpClient<IIpfsApiClient, IpfsApiClient>((x, client) =>
            {
                client.BaseAddress = new Uri(config.BaseUrl);
            }).AddPolicyHandler(GetRetryPolicy(config.RetryCount));

            return serviceCollection;
        }

        private static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy(int retryCount)
        {
            var delay = Backoff.DecorrelatedJitterBackoffV2(TimeSpan.FromSeconds(1), retryCount);
            return HttpPolicyExtensions.HandleTransientHttpError()
                .OrResult(x => x.StatusCode == System.Net.HttpStatusCode.NotFound)
                .OrResult(x => x.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                .WaitAndRetryAsync(delay);
        }
    }
}
