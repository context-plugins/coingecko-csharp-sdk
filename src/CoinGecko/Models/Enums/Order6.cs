using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order6>))]
public sealed record Order6 : OpenStringEnum<Order6>
{
    private Order6(string value) : base(value)
    {
    }

    public static readonly Order6 DateDesc = new("date_desc");

    public static readonly Order6 DateAsc = new("date_asc");

    public static readonly Order6 HoldingNetChangeDesc = new("holding_net_change_desc");

    public static readonly Order6 HoldingNetChangeAsc = new("holding_net_change_asc");

    public static readonly Order6 TransactionValueUsdDesc = new("transaction_value_usd_desc");

    public static readonly Order6 TransactionValueUsdAsc = new("transaction_value_usd_asc");

    public static readonly Order6 AverageCostDesc = new("average_cost_desc");

    public static readonly Order6 AverageCostAsc = new("average_cost_asc");

    public TResult Match<TResult>(Func<TResult> onDateDesc,
        Func<TResult> onDateAsc,
        Func<TResult> onHoldingNetChangeDesc,
        Func<TResult> onHoldingNetChangeAsc,
        Func<TResult> onTransactionValueUsdDesc,
        Func<TResult> onTransactionValueUsdAsc,
        Func<TResult> onAverageCostDesc,
        Func<TResult> onAverageCostAsc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == DateDesc => onDateDesc(),
            _ when this == DateAsc => onDateAsc(),
            _ when this == HoldingNetChangeDesc => onHoldingNetChangeDesc(),
            _ when this == HoldingNetChangeAsc => onHoldingNetChangeAsc(),
            _ when this == TransactionValueUsdDesc => onTransactionValueUsdDesc(),
            _ when this == TransactionValueUsdAsc => onTransactionValueUsdAsc(),
            _ when this == AverageCostDesc => onAverageCostDesc(),
            _ when this == AverageCostAsc => onAverageCostAsc(),
            _ => otherwise(Value)
        };

    public void Match(Action onDateDesc,
        Action onDateAsc,
        Action onHoldingNetChangeDesc,
        Action onHoldingNetChangeAsc,
        Action onTransactionValueUsdDesc,
        Action onTransactionValueUsdAsc,
        Action onAverageCostDesc,
        Action onAverageCostAsc,
        Action<string> otherwise)
    {
        if (this == DateDesc) onDateDesc();
        else if (this == DateAsc) onDateAsc();
        else if (this == HoldingNetChangeDesc) onHoldingNetChangeDesc();
        else if (this == HoldingNetChangeAsc) onHoldingNetChangeAsc();
        else if (this == TransactionValueUsdDesc) onTransactionValueUsdDesc();
        else if (this == TransactionValueUsdAsc) onTransactionValueUsdAsc();
        else if (this == AverageCostDesc) onAverageCostDesc();
        else if (this == AverageCostAsc) onAverageCostAsc();
        else otherwise(Value);
    }
}
