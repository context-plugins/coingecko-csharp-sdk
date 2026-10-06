using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<DexPairFormat>))]
public sealed record DexPairFormat : OpenStringEnum<DexPairFormat>
{
    private DexPairFormat(string value) : base(value)
    {
    }

    public static readonly DexPairFormat ContractAddress = new("contract_address");

    public static readonly DexPairFormat Symbol = new("symbol");

    public TResult Match<TResult>(Func<TResult> onContractAddress,
        Func<TResult> onSymbol,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == ContractAddress => onContractAddress(),
            _ when this == Symbol => onSymbol(),
            _ => otherwise(Value)
        };

    public void Match(Action onContractAddress, Action onSymbol, Action<string> otherwise)
    {
        if (this == ContractAddress) onContractAddress();
        else if (this == Symbol) onSymbol();
        else otherwise(Value);
    }
}
