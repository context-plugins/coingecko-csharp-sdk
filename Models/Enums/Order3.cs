using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Enum;

namespace CoinGeckoDemoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order3>))]
public sealed record Order3 : StringEnum<Order3>
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

    public static Order3 FromValue(string value) => FromValueCore(value);
}
