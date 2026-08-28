using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Locale>))]
public sealed record Locale : StringEnum<Locale>
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

    public static Locale FromValue(string value) => FromValueCore(value);
}
