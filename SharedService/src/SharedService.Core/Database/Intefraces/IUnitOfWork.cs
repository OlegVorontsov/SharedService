using System.Data;

namespace SharedService.Core.Database.Intefraces;

public interface IUnitOfWork
{
    Task<IDbTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default);
}