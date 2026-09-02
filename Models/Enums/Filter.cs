using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Enum;

namespace CoinGeckoDemoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter>))]
public sealed record Filter : StringEnum<Filter>
{
    private Filter(string value) : base(value)
    {
    }

    public static readonly Filter Nft = new("nft");

    public static Filter FromValue(string value) => FromValueCore(value);
}
