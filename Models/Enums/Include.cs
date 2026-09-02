using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Include>))]
public sealed record Include : StringEnum<Include>
{
    private Include(string value) : base(value)
    {
    }

    public static readonly Include TopPools = new("top_pools");

    public static Include FromValue(string value) => FromValueCore(value);
}
