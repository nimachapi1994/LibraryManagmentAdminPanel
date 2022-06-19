using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookShop.Models.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> FindAllAsync();

        Task<TEntity> FindById(object id);
        Task Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task InsertRange(IEnumerable<TEntity> entities);

        void UpdateRange(IEnumerable<TEntity> entities);

        void DeleteRange(IEnumerable<TEntity> entities);


        Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> OrderBy = null, params Expression<Func<TEntity, object>>[] Includes);

    }
}

