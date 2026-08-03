using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Enum;

namespace CoinGeckoDemoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order1>))]
public sealed record Order1 : StringEnum<Order1>
{
    private Order1(string value) : base(value)
    {
    }

    public static readonly Order1 TrustScoreDesc = new("trust_score_desc");

    public static readonly Order1 TrustScoreAsc = new("trust_score_asc");

    public static readonly Order1 VolumeDesc = new("volume_desc");

    public static readonly Order1 VolumeAsc = new("volume_asc");

    public static Order1 FromValue(string value) => FromValueCore(value);
}
