using CoinGeckoDemoApi.Core.Authentication;
using CoinGeckoDemoApi.Core.Authentication.ApiKey;

namespace CoinGeckoDemoApi;

internal sealed class AuthSchemes
{
    public IAuthScheme HeaderAuth { get; }
    public IAuthScheme QueryAuth { get; }

    public AuthSchemes(CoinGeckoDemoApiClientOptions options)
    {
        HeaderAuth = ApiKeyHeaderScheme.Create("x-cg-demo-api-key", options.HeaderAuth);
        QueryAuth = ApiKeyQueryScheme.Create("x_cg_demo_api_key", options.QueryAuth);
    }
}
