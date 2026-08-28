using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

/// <summary>
/// Transaction type
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeEnum>))]
public sealed record TypeEnum : StringEnum<TypeEnum>
{
    private TypeEnum(string value) : base(value)
    {
    }

    public static readonly TypeEnum Buy = new("buy");

    public static readonly TypeEnum Sell = new("sell");

    public static TypeEnum FromValue(string value) => FromValueCore(value);
}
