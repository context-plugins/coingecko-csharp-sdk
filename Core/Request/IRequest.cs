using System.Net.Http;

namespace CoinGecko.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}