using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Precision>))]
public sealed record Precision : OpenStringEnum<Precision>
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

    public TResult Match<TResult>(Func<TResult> onFull,
        Func<TResult> on_0,
        Func<TResult> on_1,
        Func<TResult> on_2,
        Func<TResult> on_3,
        Func<TResult> on_4,
        Func<TResult> on_5,
        Func<TResult> on_6,
        Func<TResult> on_7,
        Func<TResult> on_8,
        Func<TResult> on_9,
        Func<TResult> on_10,
        Func<TResult> on_11,
        Func<TResult> on_12,
        Func<TResult> on_13,
        Func<TResult> on_14,
        Func<TResult> on_15,
        Func<TResult> on_16,
        Func<TResult> on_17,
        Func<TResult> on_18,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Full => onFull(),
            _ when this == _0 => on_0(),
            _ when this == _1 => on_1(),
            _ when this == _2 => on_2(),
            _ when this == _3 => on_3(),
            _ when this == _4 => on_4(),
            _ when this == _5 => on_5(),
            _ when this == _6 => on_6(),
            _ when this == _7 => on_7(),
            _ when this == _8 => on_8(),
            _ when this == _9 => on_9(),
            _ when this == _10 => on_10(),
            _ when this == _11 => on_11(),
            _ when this == _12 => on_12(),
            _ when this == _13 => on_13(),
            _ when this == _14 => on_14(),
            _ when this == _15 => on_15(),
            _ when this == _16 => on_16(),
            _ when this == _17 => on_17(),
            _ when this == _18 => on_18(),
            _ => otherwise(Value)
        };

    public void Match(Action onFull,
        Action on_0,
        Action on_1,
        Action on_2,
        Action on_3,
        Action on_4,
        Action on_5,
        Action on_6,
        Action on_7,
        Action on_8,
        Action on_9,
        Action on_10,
        Action on_11,
        Action on_12,
        Action on_13,
        Action on_14,
        Action on_15,
        Action on_16,
        Action on_17,
        Action on_18,
        Action<string> otherwise)
    {
        if (this == Full) onFull();
        else if (this == _0) on_0();
        else if (this == _1) on_1();
        else if (this == _2) on_2();
        else if (this == _3) on_3();
        else if (this == _4) on_4();
        else if (this == _5) on_5();
        else if (this == _6) on_6();
        else if (this == _7) on_7();
        else if (this == _8) on_8();
        else if (this == _9) on_9();
        else if (this == _10) on_10();
        else if (this == _11) on_11();
        else if (this == _12) on_12();
        else if (this == _13) on_13();
        else if (this == _14) on_14();
        else if (this == _15) on_15();
        else if (this == _16) on_16();
        else if (this == _17) on_17();
        else if (this == _18) on_18();
        else otherwise(Value);
    }
}
