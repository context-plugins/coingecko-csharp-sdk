using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Filter>))]
public sealed record Filter : OpenStringEnum<Filter>
{
    private Filter(string value) : base(value)
    {
    }

    public static readonly Filter Nft = new("nft");

    public TResult Match<TResult>(Func<TResult> onNft, Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == Nft => onNft(),
            _ => otherwise(Value)
        };

    public void Match(Action onNft, Action<string> otherwise)
    {
        if (this == Nft) onNft();
        else otherwise(Value);
    }
}
