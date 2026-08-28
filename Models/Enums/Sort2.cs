using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort2>))]
public sealed record Sort2 : StringEnum<Sort2>
{
    private Sort2(string value) : base(value)
    {
    }

    public static readonly Sort2 H24VolumeUsdLiquidityDesc = new("h24_volume_usd_liquidity_desc");

    public static readonly Sort2 H24TxCountDesc = new("h24_tx_count_desc");

    public static readonly Sort2 H24VolumeUsdDesc = new("h24_volume_usd_desc");

    public static Sort2 FromValue(string value) => FromValueCore(value);
}
