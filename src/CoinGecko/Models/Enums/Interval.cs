using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Interval>))]
public sealed record Interval : OpenStringEnum<Interval>
{
    private Interval(string value) : base(value)
    {
    }

    public static readonly Interval Hourly = new("hourly");

    public static readonly Interval Daily = new("daily");

    public TResult Match<TResult>(Func<TResult> onHourly, Func<TResult> onDaily, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Hourly => onHourly(),
            _ when this == Daily => onDaily(),
            _ => otherwise(Value)
        };

    public void Match(Action onHourly, Action onDaily, Action<string> otherwise)
    {
        if (this == Hourly) onHourly();
        else if (this == Daily) onDaily();
        else otherwise(Value);
    }
}
