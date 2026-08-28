using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<IncludeTickers>))]
public sealed record IncludeTickers : StringEnum<IncludeTickers>
{
    private IncludeTickers(string value) : base(value)
    {
    }

    public static readonly IncludeTickers All = new("all");

    public static readonly IncludeTickers Unexpired = new("unexpired");

    public static IncludeTickers FromValue(string value) => FromValueCore(value);
}
