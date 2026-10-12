using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order3>))]
public sealed record Order3 : OpenStringEnum<Order3>
{
    private Order3(string value) : base(value)
    {
    }

    public static readonly Order3 MarketCapAsc = new("market_cap_asc");

    public static readonly Order3 MarketCapDesc = new("market_cap_desc");

    public static readonly Order3 TrustScoreDesc = new("trust_score_desc");

    public static readonly Order3 TrustScoreAsc = new("trust_score_asc");

    public static readonly Order3 VolumeDesc = new("volume_desc");

    public static readonly Order3 VolumeAsc = new("volume_asc");

    public static readonly Order3 BaseTarget = new("base_target");

    public TResult Match<TResult>(Func<TResult> onMarketCapAsc,
        Func<TResult> onMarketCapDesc,
        Func<TResult> onTrustScoreDesc,
        Func<TResult> onTrustScoreAsc,
        Func<TResult> onVolumeDesc,
        Func<TResult> onVolumeAsc,
        Func<TResult> onBaseTarget,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MarketCapAsc => onMarketCapAsc(),
            _ when this == MarketCapDesc => onMarketCapDesc(),
            _ when this == TrustScoreDesc => onTrustScoreDesc(),
            _ when this == TrustScoreAsc => onTrustScoreAsc(),
            _ when this == VolumeDesc => onVolumeDesc(),
            _ when this == VolumeAsc => onVolumeAsc(),
            _ when this == BaseTarget => onBaseTarget(),
            _ => otherwise(Value)
        };

    public void Match(Action onMarketCapAsc,
        Action onMarketCapDesc,
        Action onTrustScoreDesc,
        Action onTrustScoreAsc,
        Action onVolumeDesc,
        Action onVolumeAsc,
        Action onBaseTarget,
        Action<string> otherwise)
    {
        if (this == MarketCapAsc) onMarketCapAsc();
        else if (this == MarketCapDesc) onMarketCapDesc();
        else if (this == TrustScoreDesc) onTrustScoreDesc();
        else if (this == TrustScoreAsc) onTrustScoreAsc();
        else if (this == VolumeDesc) onVolumeDesc();
        else if (this == VolumeAsc) onVolumeAsc();
        else if (this == BaseTarget) onBaseTarget();
        else otherwise(Value);
    }
}
