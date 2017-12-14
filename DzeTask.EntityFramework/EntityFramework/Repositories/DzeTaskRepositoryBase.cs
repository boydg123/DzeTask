using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace DzeTask.EntityFramework.Repositories
{
    public abstract class DzeTaskRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<DzeTaskDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected DzeTaskRepositoryBase(IDbContextProvider<DzeTaskDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class DzeTaskRepositoryBase<TEntity> : DzeTaskRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected DzeTaskRepositoryBase(IDbContextProvider<DzeTaskDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
