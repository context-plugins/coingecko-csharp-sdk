using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Enum;

namespace CoinGeckoDemoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order4>))]
public sealed record Order4 : StringEnum<Order4>
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

    public static Order4 FromValue(string value) => FromValueCore(value);
}
