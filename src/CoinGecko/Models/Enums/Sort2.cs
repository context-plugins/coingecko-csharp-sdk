using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Sort2>))]
public sealed record Sort2 : OpenStringEnum<Sort2>
{
    private Sort2(string value) : base(value)
    {
    }

    public static readonly Sort2 H24VolumeUsdLiquidityDesc = new("h24_volume_usd_liquidity_desc");

    public static readonly Sort2 H24TxCountDesc = new("h24_tx_count_desc");

    public static readonly Sort2 H24VolumeUsdDesc = new("h24_volume_usd_desc");

    public TResult Match<TResult>(Func<TResult> onH24VolumeUsdLiquidityDesc,
        Func<TResult> onH24TxCountDesc,
        Func<TResult> onH24VolumeUsdDesc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == H24VolumeUsdLiquidityDesc => onH24VolumeUsdLiquidityDesc(),
            _ when this == H24TxCountDesc => onH24TxCountDesc(),
            _ when this == H24VolumeUsdDesc => onH24VolumeUsdDesc(),
            _ => otherwise(Value)
        };

    public void Match(Action onH24VolumeUsdLiquidityDesc,
        Action onH24TxCountDesc,
        Action onH24VolumeUsdDesc,
        Action<string> otherwise)
    {
        if (this == H24VolumeUsdLiquidityDesc) onH24VolumeUsdLiquidityDesc();
        else if (this == H24TxCountDesc) onH24TxCountDesc();
        else if (this == H24VolumeUsdDesc) onH24VolumeUsdDesc();
        else otherwise(Value);
    }
}
