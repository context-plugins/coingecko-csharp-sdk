using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Enum;

namespace CoinGeckoDemoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order7>))]
public sealed record Order7 : StringEnum<Order7>
{
    private Order7(string value) : base(value)
    {
    }

    public static readonly Order7 H24VolumeUsdAsc = new("h24_volume_usd_asc");

    public static readonly Order7 H24VolumeUsdDesc = new("h24_volume_usd_desc");

    public static readonly Order7 H24VolumeNativeAsc = new("h24_volume_native_asc");

    public static readonly Order7 H24VolumeNativeDesc = new("h24_volume_native_desc");

    public static readonly Order7 FloorPriceNativeAsc = new("floor_price_native_asc");

    public static readonly Order7 FloorPriceNativeDesc = new("floor_price_native_desc");

    public static readonly Order7 MarketCapNativeAsc = new("market_cap_native_asc");

    public static readonly Order7 MarketCapNativeDesc = new("market_cap_native_desc");

    public static readonly Order7 MarketCapUsdAsc = new("market_cap_usd_asc");

    public static readonly Order7 MarketCapUsdDesc = new("market_cap_usd_desc");

    public static Order7 FromValue(string value) => FromValueCore(value);
}
