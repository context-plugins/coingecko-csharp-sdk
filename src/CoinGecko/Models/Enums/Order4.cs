using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order4>))]
public sealed record Order4 : OpenStringEnum<Order4>
{
    private Order4(string value) : base(value)
    {
    }

    public static readonly Order4 NameAsc = new("name_asc");

    public static readonly Order4 NameDesc = new("name_desc");

    public static readonly Order4 OpenInterestBtcAsc = new("open_interest_btc_asc");

    public static readonly Order4 OpenInterestBtcDesc = new("open_interest_btc_desc");

    public static readonly Order4 TradeVolume24HBtcAsc = new("trade_volume_24h_btc_asc");

    public static readonly Order4 TradeVolume24HBtcDesc = new("trade_volume_24h_btc_desc");

    public TResult Match<TResult>(Func<TResult> onNameAsc,
        Func<TResult> onNameDesc,
        Func<TResult> onOpenInterestBtcAsc,
        Func<TResult> onOpenInterestBtcDesc,
        Func<TResult> onTradeVolume24HBtcAsc,
        Func<TResult> onTradeVolume24HBtcDesc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == NameAsc => onNameAsc(),
            _ when this == NameDesc => onNameDesc(),
            _ when this == OpenInterestBtcAsc => onOpenInterestBtcAsc(),
            _ when this == OpenInterestBtcDesc => onOpenInterestBtcDesc(),
            _ when this == TradeVolume24HBtcAsc => onTradeVolume24HBtcAsc(),
            _ when this == TradeVolume24HBtcDesc => onTradeVolume24HBtcDesc(),
            _ => otherwise(Value)
        };

    public void Match(Action onNameAsc,
        Action onNameDesc,
        Action onOpenInterestBtcAsc,
        Action onOpenInterestBtcDesc,
        Action onTradeVolume24HBtcAsc,
        Action onTradeVolume24HBtcDesc,
        Action<string> otherwise)
    {
        if (this == NameAsc) onNameAsc();
        else if (this == NameDesc) onNameDesc();
        else if (this == OpenInterestBtcAsc) onOpenInterestBtcAsc();
        else if (this == OpenInterestBtcDesc) onOpenInterestBtcDesc();
        else if (this == TradeVolume24HBtcAsc) onTradeVolume24HBtcAsc();
        else if (this == TradeVolume24HBtcDesc) onTradeVolume24HBtcDesc();
        else otherwise(Value);
    }
}
