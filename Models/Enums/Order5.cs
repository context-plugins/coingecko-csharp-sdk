using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order5>))]
public sealed record Order5 : OpenStringEnum<Order5>
{
    private Order5(string value) : base(value)
    {
    }

    public static readonly Order5 TotalHoldingsUsdDesc = new("total_holdings_usd_desc");

    public static readonly Order5 TotalHoldingsUsdAsc = new("total_holdings_usd_asc");

    public TResult Match<TResult>(Func<TResult> onTotalHoldingsUsdDesc,
        Func<TResult> onTotalHoldingsUsdAsc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TotalHoldingsUsdDesc => onTotalHoldingsUsdDesc(),
            _ when this == TotalHoldingsUsdAsc => onTotalHoldingsUsdAsc(),
            _ => otherwise(Value)
        };

    public void Match(Action onTotalHoldingsUsdDesc, Action onTotalHoldingsUsdAsc, Action<string> otherwise)
    {
        if (this == TotalHoldingsUsdDesc) onTotalHoldingsUsdDesc();
        else if (this == TotalHoldingsUsdAsc) onTotalHoldingsUsdAsc();
        else otherwise(Value);
    }
}
