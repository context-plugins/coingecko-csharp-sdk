using System.Text.Json.Serialization;
using CoinGeckoDemoApi.Core.Enum;

namespace CoinGeckoDemoApi.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order>))]
public sealed record Order : StringEnum<Order>
{
    private Order(string value) : base(value)
    {
    }

    public static readonly Order MarketCapAsc = new("market_cap_asc");

    public static readonly Order MarketCapDesc = new("market_cap_desc");

    public static readonly Order VolumeAsc = new("volume_asc");

    public static readonly Order VolumeDesc = new("volume_desc");

    public static readonly Order IdAsc = new("id_asc");

    public static readonly Order IdDesc = new("id_desc");

    public static Order FromValue(string value) => FromValueCore(value);
}
