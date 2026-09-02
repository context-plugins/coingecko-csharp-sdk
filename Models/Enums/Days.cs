using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Days>))]
public sealed record Days : StringEnum<Days>
{
    private Days(string value) : base(value)
    {
    }

    public static readonly Days _1 = new("1");

    public static readonly Days _7 = new("7");

    public static readonly Days _14 = new("14");

    public static readonly Days _30 = new("30");

    public static readonly Days _90 = new("90");

    public static readonly Days _180 = new("180");

    public static readonly Days _365 = new("365");

    public static Days FromValue(string value) => FromValueCore(value);
}
