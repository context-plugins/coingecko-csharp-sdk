using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter>))]
public sealed record Filter : StringEnum<Filter>
{
    private Filter(string value) : base(value)
    {
    }

    public static readonly Filter Nft = new("nft");

    public static Filter FromValue(string value) => FromValueCore(value);
}
