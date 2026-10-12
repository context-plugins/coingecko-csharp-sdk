using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order1>))]
public sealed record Order1 : OpenStringEnum<Order1>
{
    private Order1(string value) : base(value)
    {
    }

    public static readonly Order1 TrustScoreDesc = new("trust_score_desc");

    public static readonly Order1 TrustScoreAsc = new("trust_score_asc");

    public static readonly Order1 VolumeDesc = new("volume_desc");

    public static readonly Order1 VolumeAsc = new("volume_asc");

    public TResult Match<TResult>(Func<TResult> onTrustScoreDesc,
        Func<TResult> onTrustScoreAsc,
        Func<TResult> onVolumeDesc,
        Func<TResult> onVolumeAsc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TrustScoreDesc => onTrustScoreDesc(),
            _ when this == TrustScoreAsc => onTrustScoreAsc(),
            _ when this == VolumeDesc => onVolumeDesc(),
            _ when this == VolumeAsc => onVolumeAsc(),
            _ => otherwise(Value)
        };

    public void Match(Action onTrustScoreDesc,
        Action onTrustScoreAsc,
        Action onVolumeDesc,
        Action onVolumeAsc,
        Action<string> otherwise)
    {
        if (this == TrustScoreDesc) onTrustScoreDesc();
        else if (this == TrustScoreAsc) onTrustScoreAsc();
        else if (this == VolumeDesc) onVolumeDesc();
        else if (this == VolumeAsc) onVolumeAsc();
        else otherwise(Value);
    }
}
