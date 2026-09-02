using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Interval>))]
public sealed record Interval : StringEnum<Interval>
{
    private Interval(string value) : base(value)
    {
    }

    public static readonly Interval Hourly = new("hourly");

    public static readonly Interval Daily = new("daily");

    public static Interval FromValue(string value) => FromValueCore(value);
}
