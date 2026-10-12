using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Timeframe>))]
public sealed record Timeframe : OpenStringEnum<Timeframe>
{
    private Timeframe(string value) : base(value)
    {
    }

    public static readonly Timeframe Day = new("day");

    public static readonly Timeframe Hour = new("hour");

    public static readonly Timeframe Minute = new("minute");

    public TResult Match<TResult>(Func<TResult> onDay,
        Func<TResult> onHour,
        Func<TResult> onMinute,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Day => onDay(),
            _ when this == Hour => onHour(),
            _ when this == Minute => onMinute(),
            _ => otherwise(Value)
        };

    public void Match(Action onDay, Action onHour, Action onMinute, Action<string> otherwise)
    {
        if (this == Day) onDay();
        else if (this == Hour) onHour();
        else if (this == Minute) onMinute();
        else otherwise(Value);
    }
}
