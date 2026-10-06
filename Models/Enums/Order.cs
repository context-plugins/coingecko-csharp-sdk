using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order>))]
public sealed record Order : OpenStringEnum<Order>
{
    private Order(string value) : base(value)
    {
    }

    public static readonly Order MarketCapAsc = new("market_cap_asc");

    public static readonly Order MarketCapDesc = new("market_cap_desc");

    public static readonly Order VolumeAsc = new("volume_asc");

    public static readonly Order VolumeDesc = new("volume_desc");

    public static readonly Order IdAsc = new("id_asc");

    public static readonly Order IdDesc = new("id_desc");

    public TResult Match<TResult>(Func<TResult> onMarketCapAsc,
        Func<TResult> onMarketCapDesc,
        Func<TResult> onVolumeAsc,
        Func<TResult> onVolumeDesc,
        Func<TResult> onIdAsc,
        Func<TResult> onIdDesc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MarketCapAsc => onMarketCapAsc(),
            _ when this == MarketCapDesc => onMarketCapDesc(),
            _ when this == VolumeAsc => onVolumeAsc(),
            _ when this == VolumeDesc => onVolumeDesc(),
            _ when this == IdAsc => onIdAsc(),
            _ when this == IdDesc => onIdDesc(),
            _ => otherwise(Value)
        };

    public void Match(Action onMarketCapAsc,
        Action onMarketCapDesc,
        Action onVolumeAsc,
        Action onVolumeDesc,
        Action onIdAsc,
        Action onIdDesc,
        Action<string> otherwise)
    {
        if (this == MarketCapAsc) onMarketCapAsc();
        else if (this == MarketCapDesc) onMarketCapDesc();
        else if (this == VolumeAsc) onVolumeAsc();
        else if (this == VolumeDesc) onVolumeDesc();
        else if (this == IdAsc) onIdAsc();
        else if (this == IdDesc) onIdDesc();
        else otherwise(Value);
    }
}
