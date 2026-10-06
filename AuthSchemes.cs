using CoinGecko.Core.Authentication;
using CoinGecko.Core.Authentication.ApiKey;

namespace CoinGecko;

internal sealed class AuthSchemes
{
    public IAuthScheme HeaderAuth { get; }
    public IAuthScheme QueryAuth { get; }

    public AuthSchemes(CoinGeckoClientOptions options)
    {
        HeaderAuth = ApiKeyHeaderScheme.Create("x-cg-demo-api-key", options.HeaderAuth);
        QueryAuth = ApiKeyQueryScheme.Create("x_cg_demo_api_key", options.QueryAuth);
    }
}
