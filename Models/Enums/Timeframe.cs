using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Enum;

namespace CoinGeckoDemoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Timeframe>))]
public sealed record Timeframe : StringEnum<Timeframe>
{
    private Timeframe(string value) : base(value)
    {
    }

    public static readonly Timeframe Day = new("day");

    public static readonly Timeframe Hour = new("hour");

    public static readonly Timeframe Minute = new("minute");

    public static Timeframe FromValue(string value) => FromValueCore(value);
}
