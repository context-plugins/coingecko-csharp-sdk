using System.Threading;
using System.Threading.Tasks;
using CoinGecko.Core.Models;

namespace CoinGecko.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}