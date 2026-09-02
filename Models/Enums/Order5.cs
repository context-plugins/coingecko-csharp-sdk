using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order5>))]
public sealed record Order5 : StringEnum<Order5>
{
    private Order5(string value) : base(value)
    {
    }

    public static readonly Order5 TotalHoldingsUsdDesc = new("total_holdings_usd_desc");

    public static readonly Order5 TotalHoldingsUsdAsc = new("total_holdings_usd_asc");

    public static Order5 FromValue(string value) => FromValueCore(value);
}
