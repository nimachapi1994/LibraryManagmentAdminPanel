using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookShop.Models.Repository
{
    public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity> where TEntity : class where TContext : DbContext
    {
        protected TContext bookShopContext { get; set; }
        private DbSet<TEntity> _dbSet;
        public BaseRepository(TContext _bookShopContext)
        {
            bookShopContext = _bookShopContext;
            _dbSet = bookShopContext.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> FindAllAsync() =>
                   await _dbSet.ToListAsync();



        public virtual async Task<TEntity> FindById(object id) =>
            await _dbSet.FindAsync(id);

        public virtual async Task Insert(TEntity entity) => await _dbSet.AddAsync(entity);

        public virtual void Update(TEntity entity) => _dbSet.Update(entity);
        public virtual void Delete(TEntity entity) => _dbSet.Remove(entity);
        public virtual async Task InsertRange(IEnumerable<TEntity> entities) => await _dbSet.AddRangeAsync(entities);

        public virtual void UpdateRange(IEnumerable<TEntity> entities) => _dbSet.UpdateRange(entities);

        public virtual void DeleteRange(IEnumerable<TEntity> entities) => _dbSet.RemoveRange(entities);


        public async Task<IEnumerable<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> OrderBy = null, params Expression<Func<TEntity, object>>[] Includes)
        {
            IQueryable<TEntity> Query = bookShopContext.Set<TEntity>();

            if (Includes != null)
            {
                foreach (var item in Includes)
                {
                    Query = Query.Include(item);
                }
            }
            if (filter != null)
            {
                Query = Query.Where(filter);

            }
            if (OrderBy != null)
            {

                Query = OrderBy(Query);
            }

            return Query;

        }


    }
}
