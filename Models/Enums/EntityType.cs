using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EntityType>))]
public sealed record EntityType : StringEnum<EntityType>
{
    private EntityType(string value) : base(value)
    {
    }

    public static readonly EntityType Company = new("company");

    public static readonly EntityType Government = new("government");

    public static EntityType FromValue(string value) => FromValueCore(value);
}
