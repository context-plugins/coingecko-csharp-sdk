using System.Net.Http;
using CoinGeckoDemoApi.Core.Extensions;

namespace CoinGeckoDemoApi.Core.Request;

internal sealed class EmptyBody : IRequest
{
    public static EmptyBody Instance { get; } = new();

    private EmptyBody() { }

    public HttpContent Get() => HttpContent.None;

    public bool CanRetry => true;
}
