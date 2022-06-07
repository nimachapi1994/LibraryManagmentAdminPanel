using BookShop.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.Repository
{
    public class BookRepository
    {
        public BookShopContext bookShopContext;
        public BookRepository(BookShopContext _bookshopcontext)
        {
            bookShopContext = _bookshopcontext;
        }
        public async Task<Book> GetBookDetailAsync(int id)
        {
            return await Task.Run(delegate ()
             {
                 return bookShopContext.Books.FromSqlRaw
                 ($"select * from dbo.bookinfo where BookId={id}")
                 .Include(x => x.Language).Include(x => x.Publisher).First();
             });
        }

        public async Task<List<BookIndexViewModel>> getAllBooksInAdminPanel(string title, string ISBN, string Language, string Publisher, string Author, string Translator)
        {
            string AuthorName = string.Empty;
            string TranslatorName = string.Empty;
            string CategoryName = string.Empty;
            List<BookIndexViewModel> ViewModelList = new List<BookIndexViewModel>();



            return await Task.Run(delegate ()
            {
                #region  getBookInfo Query Data

                var books = (from b in bookShopContext.Books
                             join p in bookShopContext.publishers
                              on b.PublisherID equals p.PublisherId

                             // get author book  join
                             join Au in bookShopContext.Auther_Books on b.BookId equals Au.BookId into Aui
                             from okAuthor in Aui.DefaultIfEmpty()
                             join Author in bookShopContext.Authers on okAuthor.AutherId equals Author.AutherId into AuthorFull
                             from AuthorOK in AuthorFull.DefaultIfEmpty()


                                 //get language book
                             join lang in bookShopContext.languages
                             on b.LangId equals lang.LanguageId

                             //get all translators  join
                             join t in bookShopContext.translator_Books
                             on b.BookId equals t.BookId into Book_TranslatorFull
                             from Book_TranslatorOK in Book_TranslatorFull.DefaultIfEmpty()

                             join Tran in bookShopContext.Translators on Book_TranslatorOK.translatorId equals Tran.Translator_Id
                             into TranslatorFull
                             from TranslatorOK in TranslatorFull.DefaultIfEmpty()



                                 //get All Categories join
                             join cat in bookShopContext.book_Categories
                            on b.BookId equals cat.BookId into CategoryFull
                             from CategoryOk in CategoryFull.DefaultIfEmpty()
                             join tbl_cateory in bookShopContext.Categories
                            on CategoryOk.CategoryId equals tbl_cateory.CategoryId into CatFull
                             from catOk in CatFull.DefaultIfEmpty()


                                 //Conditions To Search.............
                             where (b.IsDeleted == false)
                            && b.Title.Contains(title.Trim())
                            && b.Publisher.PublisherName.Contains(Publisher.Trim())
                            && b.ISBN.Contains(ISBN.Trim())
                            && b.Title.Contains(title.Trim())
                           && EF.Functions.Like(lang.LanguageName, "%" + Language.Trim() + "%")
                              && EF.Functions.Like(TranslatorOK.Name, "%" + Translator.Trim() + "%")                          
                             select new BookIndexViewModel
                             {
                                 bookId = b.BookId,
                                 ISBN = b.ISBN,
                                 Ispublish = b.IsPublish,
                                 PublisherName = p.PublisherName,
                                 Price = b.Price,
                                 PublishDate = b.PublishDate,
                                 Stock = b.Stock,
                                 Title = b.Title,
                                 Auther = (AuthorOK) != null ?
                                 AuthorOK.FirstName + " " + AuthorOK.LastName : "",
                                 translator = TranslatorOK != null ? TranslatorOK.Name : "",
                                 languageName = lang.LanguageName,
                                 CategoryName = catOk != null ? catOk.Category_Name : ""


                             }).Where(x => x.Auther.Contains(Author.Trim())).ToList();




                var BookGroup = books.GroupBy(b => b.bookId).Select(x => new { bookId = x.Key, bookGroup = x }).ToList().Distinct();
                // when books for load author books name is repeated i use group and forech all data

                foreach (var item in BookGroup)
                {
                    AuthorName = "";

                    foreach (var author in item.bookGroup.Select(x => x.Auther).Distinct())
                    {
                        AuthorName += $"_{author}";
                    }
                    TranslatorName = "";
                    foreach (var translator in item.bookGroup.Select(x => x.translator).Distinct())
                    {
                        TranslatorName += $"_{translator}";
                    }
                    CategoryName = "";
                    foreach (var Category in item.bookGroup.Select(x => x.CategoryName).Distinct())
                    {
                        CategoryName += $"_{Category}";
                    }
                    BookIndexViewModel bookIndexViewModel = new BookIndexViewModel()
                    {
                        bookId = item.bookId,
                        ISBN = item.bookGroup.First().ISBN,
                        Ispublish = item.bookGroup.First().Ispublish,
                        Price = item.bookGroup.First().Price,
                        PublishDate = item.bookGroup.First().PublishDate,
                        PublisherName = item.bookGroup.First().PublisherName,
                        Stock = item.bookGroup.First().Stock,
                        Title = item.bookGroup.First().Title,
                        Auther = AuthorName.Remove(0, 1),
                        translator = TranslatorName.Remove(0, 1),
                        languageName = item.bookGroup.First().languageName,
                        CategoryName = CategoryName.Remove(0, 1)

                    };
                    ViewModelList.Add(bookIndexViewModel);
                }
                return ViewModelList;
                #endregion
            });
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
