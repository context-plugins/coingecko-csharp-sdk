using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Enum;

namespace CoinGeckoDemoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort>))]
public sealed record Sort : StringEnum<Sort>
{
    private Sort(string value) : base(value)
    {
    }

    public static readonly Sort H24TxCountDesc = new("h24_tx_count_desc");

    public static readonly Sort H24VolumeUsdDesc = new("h24_volume_usd_desc");

    public static Sort FromValue(string value) => FromValueCore(value);
}
