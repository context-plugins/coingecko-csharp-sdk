using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order7>))]
public sealed record Order7 : OpenStringEnum<Order7>
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

    public TResult Match<TResult>(Func<TResult> onH24VolumeUsdAsc,
        Func<TResult> onH24VolumeUsdDesc,
        Func<TResult> onH24VolumeNativeAsc,
        Func<TResult> onH24VolumeNativeDesc,
        Func<TResult> onFloorPriceNativeAsc,
        Func<TResult> onFloorPriceNativeDesc,
        Func<TResult> onMarketCapNativeAsc,
        Func<TResult> onMarketCapNativeDesc,
        Func<TResult> onMarketCapUsdAsc,
        Func<TResult> onMarketCapUsdDesc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == H24VolumeUsdAsc => onH24VolumeUsdAsc(),
            _ when this == H24VolumeUsdDesc => onH24VolumeUsdDesc(),
            _ when this == H24VolumeNativeAsc => onH24VolumeNativeAsc(),
            _ when this == H24VolumeNativeDesc => onH24VolumeNativeDesc(),
            _ when this == FloorPriceNativeAsc => onFloorPriceNativeAsc(),
            _ when this == FloorPriceNativeDesc => onFloorPriceNativeDesc(),
            _ when this == MarketCapNativeAsc => onMarketCapNativeAsc(),
            _ when this == MarketCapNativeDesc => onMarketCapNativeDesc(),
            _ when this == MarketCapUsdAsc => onMarketCapUsdAsc(),
            _ when this == MarketCapUsdDesc => onMarketCapUsdDesc(),
            _ => otherwise(Value)
        };

    public void Match(Action onH24VolumeUsdAsc,
        Action onH24VolumeUsdDesc,
        Action onH24VolumeNativeAsc,
        Action onH24VolumeNativeDesc,
        Action onFloorPriceNativeAsc,
        Action onFloorPriceNativeDesc,
        Action onMarketCapNativeAsc,
        Action onMarketCapNativeDesc,
        Action onMarketCapUsdAsc,
        Action onMarketCapUsdDesc,
        Action<string> otherwise)
    {
        if (this == H24VolumeUsdAsc) onH24VolumeUsdAsc();
        else if (this == H24VolumeUsdDesc) onH24VolumeUsdDesc();
        else if (this == H24VolumeNativeAsc) onH24VolumeNativeAsc();
        else if (this == H24VolumeNativeDesc) onH24VolumeNativeDesc();
        else if (this == FloorPriceNativeAsc) onFloorPriceNativeAsc();
        else if (this == FloorPriceNativeDesc) onFloorPriceNativeDesc();
        else if (this == MarketCapNativeAsc) onMarketCapNativeAsc();
        else if (this == MarketCapNativeDesc) onMarketCapNativeDesc();
        else if (this == MarketCapUsdAsc) onMarketCapUsdAsc();
        else if (this == MarketCapUsdDesc) onMarketCapUsdDesc();
        else otherwise(Value);
    }
}
