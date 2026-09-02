using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Include3>))]
public sealed record Include3 : StringEnum<Include3>
{
    private Include3(string value) : base(value)
    {
    }

    public static readonly Include3 Network = new("network");

    public static Include3 FromValue(string value) => FromValueCore(value);
}
