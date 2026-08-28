using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Precision>))]
public sealed record Precision : StringEnum<Precision>
{
    private Precision(string value) : base(value)
    {
    }

    public static readonly Precision Full = new("full");

    public static readonly Precision _0 = new("0");

    public static readonly Precision _1 = new("1");

    public static readonly Precision _2 = new("2");

    public static readonly Precision _3 = new("3");

    public static readonly Precision _4 = new("4");

    public static readonly Precision _5 = new("5");

    public static readonly Precision _6 = new("6");

    public static readonly Precision _7 = new("7");

    public static readonly Precision _8 = new("8");

    public static readonly Precision _9 = new("9");

    public static readonly Precision _10 = new("10");

    public static readonly Precision _11 = new("11");

    public static readonly Precision _12 = new("12");

    public static readonly Precision _13 = new("13");

    public static readonly Precision _14 = new("14");

    public static readonly Precision _15 = new("15");

    public static readonly Precision _16 = new("16");

    public static readonly Precision _17 = new("17");

    public static readonly Precision _18 = new("18");

    public static Precision FromValue(string value) => FromValueCore(value);
}
