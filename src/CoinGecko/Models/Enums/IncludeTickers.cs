using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<IncludeTickers>))]
public sealed record IncludeTickers : OpenStringEnum<IncludeTickers>
{
    private IncludeTickers(string value) : base(value)
    {
    }

    public static readonly IncludeTickers All = new("all");

    public static readonly IncludeTickers Unexpired = new("unexpired");

    public TResult Match<TResult>(Func<TResult> onAll, Func<TResult> onUnexpired, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == All => onAll(),
            _ when this == Unexpired => onUnexpired(),
            _ => otherwise(Value)
        };

    public void Match(Action onAll, Action onUnexpired, Action<string> otherwise)
    {
        if (this == All) onAll();
        else if (this == Unexpired) onUnexpired();
        else otherwise(Value);
    }
}
