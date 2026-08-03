using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Enum;

namespace CoinGeckoDemoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DexPairFormat>))]
public sealed record DexPairFormat : StringEnum<DexPairFormat>
{
    private DexPairFormat(string value) : base(value)
    {
    }

    public static readonly DexPairFormat ContractAddress = new("contract_address");

    public static readonly DexPairFormat Symbol = new("symbol");

    public static DexPairFormat FromValue(string value) => FromValueCore(value);
}
