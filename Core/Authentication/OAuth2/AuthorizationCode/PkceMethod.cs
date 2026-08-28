using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Core.Authentication.OAuth2.AuthorizationCode;

[JsonConverter(typeof(StringEnumConverter<PkceMethod>))]
public sealed record PkceMethod : StringEnum<PkceMethod>
{
    public static readonly PkceMethod S256 = new("S256");
    public static readonly PkceMethod Plain = new("plain");

    private PkceMethod(string value) : base(value) { }
}
