namespace AsaxiyClone.Infrastructure.Repositories;

public interface IGeneralRepository<TEntity,TKey>
{
    ValueTask<TEntity> InsertAsync(TEntity entity);

    IQueryable<TEntity> SelectAll();

    ValueTask<TEntity> SelectAllByIdAsync(TKey id);

    ValueTask<TEntity> UpdateAsync(TEntity entity);

    ValueTask<TEntity> DeleteAsync(TEntity entity);

    ValueTask SaveChangeSync();
}
