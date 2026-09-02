using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : StringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status Active = new("active");

    public static readonly Status Inactive = new("inactive");

    public static Status FromValue(string value) => FromValueCore(value);
}
