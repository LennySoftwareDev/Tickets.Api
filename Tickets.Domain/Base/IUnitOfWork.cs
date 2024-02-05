using Microsoft.EntityFrameworkCore;

namespace Tickets.Domain.Base;

public interface IUnitOfWork : IDisposable
{
    int Commit();

    void UndoChanges();

    DbSet<TEntity> Set<TEntity>() where TEntity : class;

    void AttachEntity<TEntity>(TEntity item) where TEntity : class;

    void SetModified<TEntity>(TEntity item) where TEntity : class;
}