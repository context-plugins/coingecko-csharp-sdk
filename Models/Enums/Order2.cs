using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order2>))]
public sealed record Order2 : StringEnum<Order2>
{
    private Order2(string value) : base(value)
    {
    }

    public static readonly Order2 MarketCapDesc = new("market_cap_desc");

    public static readonly Order2 MarketCapAsc = new("market_cap_asc");

    public static readonly Order2 NameDesc = new("name_desc");

    public static readonly Order2 NameAsc = new("name_asc");

    public static readonly Order2 MarketCapChange24HDesc = new("market_cap_change_24h_desc");

    public static readonly Order2 MarketCapChange24HAsc = new("market_cap_change_24h_asc");

    public static Order2 FromValue(string value) => FromValueCore(value);
}
