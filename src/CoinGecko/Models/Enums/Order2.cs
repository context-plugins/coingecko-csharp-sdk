using System;
using System.Text.Json.Serialization;
using CoinGecko.Core.Enum;

namespace CoinGecko.Models.Enums;

[JsonConverter(typeof(StringEnumConverter<Order2>))]
public sealed record Order2 : OpenStringEnum<Order2>
{
    private Order2(string value) : base(value)
    {
    }

    public static readonly Order2 MarketCapDesc = new("market_cap_desc");

    public static readonly Order2 MarketCapAsc = new("market_cap_asc");

    public static readonly Order2 NameDesc = new("name_desc");

    public static readonly Order2 NameAsc = new("name_asc");

    public static readonly Order2 MarketCapChange24HDesc = new("market_cap_change_24h_desc");

    public static readonly Order2 MarketCapChange24HAsc = new("market_cap_change_24h_asc");

    public TResult Match<TResult>(Func<TResult> onMarketCapDesc,
        Func<TResult> onMarketCapAsc,
        Func<TResult> onNameDesc,
        Func<TResult> onNameAsc,
        Func<TResult> onMarketCapChange24HDesc,
        Func<TResult> onMarketCapChange24HAsc,
        Func<string, TResult> otherwise) =>
        this switch
        {
            _ when this == MarketCapDesc => onMarketCapDesc(),
            _ when this == MarketCapAsc => onMarketCapAsc(),
            _ when this == NameDesc => onNameDesc(),
            _ when this == NameAsc => onNameAsc(),
            _ when this == MarketCapChange24HDesc => onMarketCapChange24HDesc(),
            _ when this == MarketCapChange24HAsc => onMarketCapChange24HAsc(),
            _ => otherwise(Value)
        };

    public void Match(Action onMarketCapDesc,
        Action onMarketCapAsc,
        Action onNameDesc,
        Action onNameAsc,
        Action onMarketCapChange24HDesc,
        Action onMarketCapChange24HAsc,
        Action<string> otherwise)
    {
        if (this == MarketCapDesc) onMarketCapDesc();
        else if (this == MarketCapAsc) onMarketCapAsc();
        else if (this == NameDesc) onNameDesc();
        else if (this == NameAsc) onNameAsc();
        else if (this == MarketCapChange24HDesc) onMarketCapChange24HDesc();
        else if (this == MarketCapChange24HAsc) onMarketCapChange24HAsc();
        else otherwise(Value);
    }
}
