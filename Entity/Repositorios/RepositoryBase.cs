
using WSF.Domain.Entities;
using WSF.EntityFramework;
using WSF.EntityFramework.Repositories;

namespace Entity.Repositorios
{
    public abstract class ToDoRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<POSDbContext, TEntity, TPrimaryKey>
      where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ToDoRepositoryBase(IDbContextProvider<POSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }

    public abstract class ToDoRepositoryBase<TEntity> : ToDoRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ToDoRepositoryBase(IDbContextProvider<POSDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
