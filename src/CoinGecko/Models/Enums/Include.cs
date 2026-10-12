using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Include>))]
public sealed record Include : OpenStringEnum<Include>
{
    private Include(string value) : base(value)
    {
    }

    public static readonly Include TopPools = new("top_pools");

    public TResult Match<TResult>(Func<TResult> onTopPools, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == TopPools => onTopPools(),
            _ => otherwise(Value)
        };

    public void Match(Action onTopPools, Action<string> otherwise)
    {
        if (this == TopPools) onTopPools();
        else otherwise(Value);
    }
}
