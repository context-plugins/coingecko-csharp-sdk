using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Enum;

namespace CoinGeckoDemoApi.Models.Enums;

/// <summary>
/// Transaction type
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TypeModel>))]
public sealed record TypeModel : StringEnum<TypeModel>
{
    private TypeModel(string value) : base(value)
    {
    }

    public static readonly TypeModel Buy = new("buy");

    public static readonly TypeModel Sell = new("sell");

    public static TypeModel FromValue(string value) => FromValueCore(value);
}
