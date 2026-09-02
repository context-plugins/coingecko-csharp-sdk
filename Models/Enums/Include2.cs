using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Include2>))]
public sealed record Include2 : StringEnum<Include2>
{
    private Include2(string value) : base(value)
    {
    }

    public static readonly Include2 Pool = new("pool");

    public static Include2 FromValue(string value) => FromValueCore(value);
}
