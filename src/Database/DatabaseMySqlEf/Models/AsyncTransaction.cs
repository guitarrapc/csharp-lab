using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DatabaseMySqlEf.Models;

/// <summary>
/// Provide transaction api with using style.
/// </summary>
/// <remarks>
/// await using (var transaction = await db.BeginTransactionAsync(ct))
/// {
///    await transaction.CommitAsync(ct);
/// }
/// </remarks>
public class AsyncTransaction : IAsyncDisposable
{
    readonly IDbContextTransaction _transaction;

    public AsyncTransaction(IDbContextTransaction transaction)
    {
        _transaction = transaction;
    }

    public Task CommitAsync(CancellationToken cancellationToken)
    {
        return _transaction.CommitAsync(cancellationToken);
    }

    public ValueTask DisposeAsync()
    {
        return _transaction.DisposeAsync();
    }
}

public static class AsyncTransactionExtensions
{
    public static async Task<AsyncTransaction> BeginTransactionAsync(this DbContext dbContext, CancellationToken cancellationToken)
    {
        var transaction = await dbContext.Database.BeginTransactionAsync(IsolationLevel.ReadUncommitted, cancellationToken);
        return new AsyncTransaction(transaction);
    }
}
