using BookShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.Repository
{
    public class BookRepository
    {
        private readonly BookShopContext bookShopContext;
        public BookRepository(BookShopContext _bookshopcontext)
        {
            bookShopContext = _bookshopcontext;
        }

        //show add parent category
        public List<TreeViewCategory> GetAll_categories()
        {
            var categoreis = (from c in bookShopContext.Categories
                              where c.ParentCategoryID == null
                              select new TreeViewCategory { Category_Id = c.CategoryId, CategoryName = c.Category_Name }).ToList();
            categoreis.ForEach(TreeView =>
            {
                BindSubCategoreis(TreeView);
            });
            return categoreis;
        }
       

        // show chid category for binding method
        public void BindSubCategoreis(TreeViewCategory category)
        {
           
            var subCategories = bookShopContext.Categories.Where(x => x.ParentCategoryID == category.Category_Id).
              Select(y => new TreeViewCategory
              {
                  CategoryName = y.Category_Name,
                  Category_Id = y.CategoryId
              }).ToList();

            foreach (var item in subCategories)
            {
                BindSubCategoreis(item);
                category.SubCategory.Add(item);
            }


        }
    }
}
