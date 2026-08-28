using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Duration>))]
public sealed record Duration : StringEnum<Duration>
{
    private Duration(string value) : base(value)
    {
    }

    public static readonly Duration _5M = new("5m");

    public static readonly Duration _1H = new("1h");

    public static readonly Duration _6H = new("6h");

    public static readonly Duration _24H = new("24h");

    public static Duration FromValue(string value) => FromValueCore(value);
}
