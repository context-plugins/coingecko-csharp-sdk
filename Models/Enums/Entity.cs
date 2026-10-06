using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Entity>))]
public sealed record Entity : OpenStringEnum<Entity>
{
    private Entity(string value) : base(value)
    {
    }

    public static readonly Entity Companies = new("companies");

    public static readonly Entity Governments = new("governments");

    public TResult Match<TResult>(Func<TResult> onCompanies,
        Func<TResult> onGovernments,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Companies => onCompanies(),
            _ when this == Governments => onGovernments(),
            _ => otherwise(Value)
        };

    public void Match(Action onCompanies, Action onGovernments, Action<string> otherwise)
    {
        if (this == Companies) onCompanies();
        else if (this == Governments) onGovernments();
        else otherwise(Value);
    }
}
