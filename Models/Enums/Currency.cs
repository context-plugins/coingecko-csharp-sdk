using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Enum;

namespace CoinGeckoDemoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Currency>))]
public sealed record Currency : StringEnum<Currency>
{
    private Currency(string value) : base(value)
    {
    }

    public static readonly Currency Usd = new("usd");

    public static readonly Currency Token = new("token");

    public static Currency FromValue(string value) => FromValueCore(value);
}
