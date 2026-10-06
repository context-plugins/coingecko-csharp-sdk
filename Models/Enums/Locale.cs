using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Locale>))]
public sealed record Locale : OpenStringEnum<Locale>
{
    private Locale(string value) : base(value)
    {
    }

    public static readonly Locale Ar = new("ar");

    public static readonly Locale Bg = new("bg");

    public static readonly Locale Cs = new("cs");

    public static readonly Locale Da = new("da");

    public static readonly Locale De = new("de");

    public static readonly Locale El = new("el");

    public static readonly Locale En = new("en");

    public static readonly Locale Es = new("es");

    public static readonly Locale Fi = new("fi");

    public static readonly Locale Fr = new("fr");

    public static readonly Locale He = new("he");

    public static readonly Locale Hi = new("hi");

    public static readonly Locale Hr = new("hr");

    public static readonly Locale Hu = new("hu");

    public static readonly Locale Id = new("id");

    public static readonly Locale It = new("it");

    public static readonly Locale Ja = new("ja");

    public static readonly Locale Ko = new("ko");

    public static readonly Locale Lt = new("lt");

    public static readonly Locale Nl = new("nl");

    public static readonly Locale No = new("no");

    public static readonly Locale Pl = new("pl");

    public static readonly Locale Pt = new("pt");

    public static readonly Locale Ro = new("ro");

    public static readonly Locale Ru = new("ru");

    public static readonly Locale Sk = new("sk");

    public static readonly Locale Sl = new("sl");

    public static readonly Locale Sv = new("sv");

    public static readonly Locale Th = new("th");

    public static readonly Locale Tr = new("tr");

    public static readonly Locale Uk = new("uk");

    public static readonly Locale Vi = new("vi");

    public static readonly Locale Zh = new("zh");

    public static readonly Locale ZhTw = new("zh-tw");

    public TResult Match<TResult>(Func<TResult> onAr,
        Func<TResult> onBg,
        Func<TResult> onCs,
        Func<TResult> onDa,
        Func<TResult> onDe,
        Func<TResult> onEl,
        Func<TResult> onEn,
        Func<TResult> onEs,
        Func<TResult> onFi,
        Func<TResult> onFr,
        Func<TResult> onHe,
        Func<TResult> onHi,
        Func<TResult> onHr,
        Func<TResult> onHu,
        Func<TResult> onId,
        Func<TResult> onIt,
        Func<TResult> onJa,
        Func<TResult> onKo,
        Func<TResult> onLt,
        Func<TResult> onNl,
        Func<TResult> onNo,
        Func<TResult> onPl,
        Func<TResult> onPt,
        Func<TResult> onRo,
        Func<TResult> onRu,
        Func<TResult> onSk,
        Func<TResult> onSl,
        Func<TResult> onSv,
        Func<TResult> onTh,
        Func<TResult> onTr,
        Func<TResult> onUk,
        Func<TResult> onVi,
        Func<TResult> onZh,
        Func<TResult> onZhTw,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Ar => onAr(),
            _ when this == Bg => onBg(),
            _ when this == Cs => onCs(),
            _ when this == Da => onDa(),
            _ when this == De => onDe(),
            _ when this == El => onEl(),
            _ when this == En => onEn(),
            _ when this == Es => onEs(),
            _ when this == Fi => onFi(),
            _ when this == Fr => onFr(),
            _ when this == He => onHe(),
            _ when this == Hi => onHi(),
            _ when this == Hr => onHr(),
            _ when this == Hu => onHu(),
            _ when this == Id => onId(),
            _ when this == It => onIt(),
            _ when this == Ja => onJa(),
            _ when this == Ko => onKo(),
            _ when this == Lt => onLt(),
            _ when this == Nl => onNl(),
            _ when this == No => onNo(),
            _ when this == Pl => onPl(),
            _ when this == Pt => onPt(),
            _ when this == Ro => onRo(),
            _ when this == Ru => onRu(),
            _ when this == Sk => onSk(),
            _ when this == Sl => onSl(),
            _ when this == Sv => onSv(),
            _ when this == Th => onTh(),
            _ when this == Tr => onTr(),
            _ when this == Uk => onUk(),
            _ when this == Vi => onVi(),
            _ when this == Zh => onZh(),
            _ when this == ZhTw => onZhTw(),
            _ => otherwise(Value)
        };

    public void Match(Action onAr,
        Action onBg,
        Action onCs,
        Action onDa,
        Action onDe,
        Action onEl,
        Action onEn,
        Action onEs,
        Action onFi,
        Action onFr,
        Action onHe,
        Action onHi,
        Action onHr,
        Action onHu,
        Action onId,
        Action onIt,
        Action onJa,
        Action onKo,
        Action onLt,
        Action onNl,
        Action onNo,
        Action onPl,
        Action onPt,
        Action onRo,
        Action onRu,
        Action onSk,
        Action onSl,
        Action onSv,
        Action onTh,
        Action onTr,
        Action onUk,
        Action onVi,
        Action onZh,
        Action onZhTw,
        Action<string> otherwise)
    {
        if (this == Ar) onAr();
        else if (this == Bg) onBg();
        else if (this == Cs) onCs();
        else if (this == Da) onDa();
        else if (this == De) onDe();
        else if (this == El) onEl();
        else if (this == En) onEn();
        else if (this == Es) onEs();
        else if (this == Fi) onFi();
        else if (this == Fr) onFr();
        else if (this == He) onHe();
        else if (this == Hi) onHi();
        else if (this == Hr) onHr();
        else if (this == Hu) onHu();
        else if (this == Id) onId();
        else if (this == It) onIt();
        else if (this == Ja) onJa();
        else if (this == Ko) onKo();
        else if (this == Lt) onLt();
        else if (this == Nl) onNl();
        else if (this == No) onNo();
        else if (this == Pl) onPl();
        else if (this == Pt) onPt();
        else if (this == Ro) onRo();
        else if (this == Ru) onRu();
        else if (this == Sk) onSk();
        else if (this == Sl) onSl();
        else if (this == Sv) onSv();
        else if (this == Th) onTh();
        else if (this == Tr) onTr();
        else if (this == Uk) onUk();
        else if (this == Vi) onVi();
        else if (this == Zh) onZh();
        else if (this == ZhTw) onZhTw();
        else otherwise(Value);
    }
}
