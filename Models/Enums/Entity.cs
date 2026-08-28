using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Entity>))]
public sealed record Entity : StringEnum<Entity>
{
    private Entity(string value) : base(value)
    {
    }

    public static readonly Entity Companies = new("companies");

    public static readonly Entity Governments = new("governments");

    public static Entity FromValue(string value) => FromValueCore(value);
}
