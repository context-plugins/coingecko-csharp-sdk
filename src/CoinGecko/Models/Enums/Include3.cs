using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Include3>))]
public sealed record Include3 : OpenStringEnum<Include3>
{
    private Include3(string value) : base(value)
    {
    }

    public static readonly Include3 Network = new("network");

    public TResult Match<TResult>(Func<TResult> onNetwork, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Network => onNetwork(),
            _ => otherwise(Value)
        };

    public void Match(Action onNetwork, Action<string> otherwise)
    {
        if (this == Network) onNetwork();
        else otherwise(Value);
    }
}
