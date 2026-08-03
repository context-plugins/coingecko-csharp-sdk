using System.Net.Http;

namespace CoinGeckoDemoApi.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}