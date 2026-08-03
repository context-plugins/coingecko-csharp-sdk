using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Enum;

namespace CoinGeckoDemoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order6>))]
public sealed record Order6 : StringEnum<Order6>
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

    public static Order6 FromValue(string value) => FromValueCore(value);
}
