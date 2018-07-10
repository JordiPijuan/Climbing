namespace Climbing.Info.Data.Contracts.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public interface IGenericRepository<TEntity>
        where TEntity : class
    {

        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter);
        TEntity GetById(object Id);
        TEntity GetEntityByFilter(Expression<Func<TEntity, bool>> filter);

    }

}
