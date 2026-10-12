using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<EntityType>))]
public sealed record EntityType : OpenStringEnum<EntityType>
{
    private EntityType(string value) : base(value)
    {
    }

    public static readonly EntityType Company = new("company");

    public static readonly EntityType Government = new("government");

    public TResult Match<TResult>(Func<TResult> onCompany,
        Func<TResult> onGovernment,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Company => onCompany(),
            _ when this == Government => onGovernment(),
            _ => otherwise(Value)
        };

    public void Match(Action onCompany, Action onGovernment, Action<string> otherwise)
    {
        if (this == Company) onCompany();
        else if (this == Government) onGovernment();
        else otherwise(Value);
    }
}
