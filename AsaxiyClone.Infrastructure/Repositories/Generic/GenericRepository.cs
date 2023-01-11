using AsaxiyClone.Infrastructure.Contexts;

namespace AsaxiyClone.Infrastructure.Repositories;

public abstract class GenericRepository<TEntity, TKey> : IGeneralRepository<TEntity, TKey>
    where TEntity : class
{
    private readonly AsaxiyCloneDBContext asaxiyCloneDBContext;

    public GenericRepository(AsaxiyCloneDBContext asaxiyCloneDBContext)
    {
        this.asaxiyCloneDBContext = asaxiyCloneDBContext;
    }
    
    public async ValueTask<TEntity> InsertAsync(TEntity entity)
    {
        var insertEntity = await this.asaxiyCloneDBContext.
            AddAsync<TEntity>(entity);

        await this.SaveChangeSync();

        return insertEntity.Entity;
    }

    public IQueryable<TEntity> SelectAll() =>
        this.asaxiyCloneDBContext.Set<TEntity>();
    
    public async ValueTask<TEntity> SelectAllByIdAsync(TKey id) =>
        await this.asaxiyCloneDBContext.Set<TEntity>().FindAsync(id);

    public async ValueTask<TEntity> UpdateAsync(TEntity entity)
    {
        var updateEntity = this.asaxiyCloneDBContext
            .Update<TEntity>(entity);

        await this.SaveChangeSync();

        return updateEntity.Entity;
    }
    
    public async ValueTask<TEntity> DeleteAsync(TEntity entity)
    {
        var deleteEntity = this.asaxiyCloneDBContext.Set<TEntity>()
            .Remove(entity);

        return deleteEntity.Entity;
    }

    public async ValueTask SaveChangeSync()
    {
        await this.asaxiyCloneDBContext.SaveChangesAsync();
    }
}
