using BookShop.Models.Repository;

namespace BookShop.Models.UnitOfWork
{
    public class UnitOfWork
    {

        private BookShopContext context;
        public UnitOfWork(BookShopContext context)
        {
            this.context = context;
        }

        public IBaseRepository<TEntity> baseRepository<TEntity>()
            where TEntity :class
        {
            IBaseRepository<TEntity> repository = new BaseRepository<TEntity, BookShopContext>(context);
            return repository;
        }
      

    }
}
