using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<IncludeTokens>))]
public sealed record IncludeTokens : StringEnum<IncludeTokens>
{
    private IncludeTokens(string value) : base(value)
    {
    }

    public static readonly IncludeTokens Top = new("top");

    public static readonly IncludeTokens All = new("all");

    public static IncludeTokens FromValue(string value) => FromValueCore(value);
}
