using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<IncludeTokens>))]
public sealed record IncludeTokens : OpenStringEnum<IncludeTokens>
{
    private IncludeTokens(string value) : base(value)
    {
    }

    public static readonly IncludeTokens Top = new("top");

    public static readonly IncludeTokens All = new("all");

    public TResult Match<TResult>(Func<TResult> onTop, Func<TResult> onAll, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Top => onTop(),
            _ when this == All => onAll(),
            _ => otherwise(Value)
        };

    public void Match(Action onTop, Action onAll, Action<string> otherwise)
    {
        if (this == Top) onTop();
        else if (this == All) onAll();
        else otherwise(Value);
    }
}
