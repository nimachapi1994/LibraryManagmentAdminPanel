using BookShop.GeneralMethods;
using BookShop.Models;
using BookShop.Models.Repository;
using BookShop.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BooksController : Controller
    {
        private readonly BookShopContext bookShopContext;
        private readonly BookRepository bookRepository;
        public BooksController(BookShopContext _bookShopContext, BookRepository _bookRespository)
        {
            bookShopContext = _bookShopContext;
            bookRepository = _bookRespository;
        }
        public async Task<IActionResult> Index(AdvanceSearchBook advanceSearch, int pageIndex = 1, int row = 5, string sortExpression = "Title", string title = "")
        {
            //------------------------------------------------
            #region  getBookInfo Query Data
            string AutherName = string.Empty;
            title = string.IsNullOrEmpty(title) ? "" : title;
            advanceSearch.IBSN = string.IsNullOrEmpty(advanceSearch.IBSN) ? "" : advanceSearch.IBSN;
            advanceSearch.Publisher = string.IsNullOrEmpty(advanceSearch.Publisher) ? "" : advanceSearch.Publisher;
            advanceSearch.Author = string.IsNullOrEmpty(advanceSearch.Author) ? "" : advanceSearch.Author;
            advanceSearch.BookName = string.IsNullOrEmpty(advanceSearch.BookName) ? "" : advanceSearch.BookName;

            ViewBag.search = title;
            List<BookIndexViewModel> ViewModelList = new List<BookIndexViewModel>();
            var books = (from b in bookShopContext.Books
                         join p in bookShopContext.publishers
                          on b.PublisherID equals p.PublisherId
                         join Au in bookShopContext.Auther_Books
                         on b.BookId equals Au.BookId
                         join A in bookShopContext.Authers
                         on Au.AutherId equals A.AutherId
                         where (b.IsDeleted == false)
                         && b.Title.Contains(title.Trim())
                         && b.Publisher.PublisherName.Contains(advanceSearch.Publisher)
                         && b.ISBN.Contains(advanceSearch.IBSN)
                         && b.Title.Contains(advanceSearch.BookName)


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
                             Auther = A.FirstName + " " + A.LastName

                         }).ToList();
            var BookGroup = books.Where(x => x.Auther.Contains(advanceSearch.Author)).GroupBy(b => b.bookId).Select(x => new { bookId = x.Key, bookGroup = x }).ToList();
            // when books for load author books name is repeated i use group and forech all data

            foreach (var item in BookGroup)
            {
                AutherName = "";
                foreach (var item2 in item.bookGroup)
                {
                    AutherName += $"_{item2.Auther}";
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
                    Auther = AutherName.Remove(0, 1)

                };
                ViewModelList.Add(bookIndexViewModel);
            }
            #endregion
            //------------------------------------------------


            // set pagination Rows list numbers for user dynamic use it
            int[] Rows = { 1, 2, 5, 10, 20, 50, 100 };
            ViewBag.RowId = new SelectList(Rows, row);

            ViewBag.BookNumber = (pageIndex - 1) * row + 1;
            //paging this Query



            var pageResult = PagingList.Create(ViewModelList, row, pageIndex, sortExpression, "Title");

            // get num of rows 
            pageResult.RouteValue = new Microsoft.AspNetCore.Routing.RouteValueDictionary
            {
                {"row",row },
                {"title",title }
            };






            //create sort <th> html table icon
            if (sortExpression.Contains('-'))
            {

                ViewBag.BoostrapClassSortExpressionIcon = "fa fa-sort-amount-up";
            }
            else
            {
                ViewBag.BoostrapClassSortExpressionIcon = "fa fa-sort-amount-down";

            }
            ViewBag.LanguageID = new SelectList(bookShopContext.languages, "LanguageName", "LanguageName");
            ViewBag.PublisherID = new SelectList(bookShopContext.publishers, "PublisherName", "PublisherName");
            ViewBag.AuthorID = new SelectList(bookShopContext.Authers.Select
                (x => new AuthorList()
                { AuthorID = x.AutherId, NameFamily = x.FirstName + " " + x.LastName }), "NameFamily", "NameFamily");

            ViewBag.TranslatorID = new SelectList(bookShopContext.Translators, "Name", "Name");


            return View(pageResult);
        }
        public IActionResult Create()
        {




            // select lists for show languageIds , publisherNames , autherNames , translator

            ViewBag.LanguageID = new SelectList(bookShopContext.languages, "LanguageId", "LanguageName");
            ViewBag.PublisherID = new SelectList(bookShopContext.publishers, "PublisherId", "PublisherName");
            ViewBag.AuthorID = new SelectList(bookShopContext.Authers.Select
                (x => new AuthorList()
                { AuthorID = x.AutherId, NameFamily = x.FirstName + " " + x.LastName }), "AuthorID", "NameFamily");

            ViewBag.TranslatorID = new SelectList(bookShopContext.Translators, "Translator_Id", "Name");



            return View(new BooksCreateViewModel(bookRepository.GetAll_categories()));
        }
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateConfirm(BooksCreateViewModel booksCreateViewModel)
        {
            List<Auther_Book> Author_BookList = new List<Auther_Book>();
            List<Translator_Book> translator_Books = new List<Translator_Book>();
            if (ModelState.IsValid)
            {
                //if data is valid insert to db

                DateTime publishedate = new DateTime();
                if (booksCreateViewModel.IsPublish)
                {
                    publishedate = DateTime.Now;
                }
                Book book = new Book()
                {
                    IsDeleted = false,
                    ISBN = booksCreateViewModel.ISBN,
                    IsPublish = booksCreateViewModel.IsPublish,
                    NumOfPage = booksCreateViewModel.NumOfPages,
                    Price = booksCreateViewModel.Price,
                    Summary = booksCreateViewModel.Summary,
                    Title = booksCreateViewModel.Title,
                    PublishYear = booksCreateViewModel.PublishYear,
                    Stock = booksCreateViewModel.Stock,
                    PublishDate = publishedate,
                    Weight = booksCreateViewModel.Weight,
                    PublisherID = booksCreateViewModel.PublisherID,
                    LangId = booksCreateViewModel.LanguageID


                };
                await bookShopContext.Books.AddAsync(book);
                bookShopContext.SaveChanges();

                if (booksCreateViewModel.AuthorID != null)
                {
                    for (int i = 0; i < booksCreateViewModel.AuthorID.Length; i++)
                    {
                        Auther_Book auther_Book = new Auther_Book()
                        {
                            BookId = book.BookId,
                            AutherId = booksCreateViewModel.AuthorID[i]
                        };

                        Author_BookList.Add(auther_Book);
                    }
                }

                await bookShopContext.AddRangeAsync(Author_BookList);
                bookShopContext.SaveChanges();

                if (booksCreateViewModel.TranslatorID != null)
                {
                    for (int i = 0; i < booksCreateViewModel.TranslatorID.Length; i++)
                    {
                        Translator_Book translator = new Translator_Book
                        {
                            BookId = book.BookId,
                            translatorId = booksCreateViewModel.TranslatorID[i]
                        };
                        translator_Books.Add(translator);
                    }

                }
                await bookShopContext.translator_Books.AddRangeAsync(translator_Books);
                bookShopContext.SaveChanges();

                return RedirectToAction(nameof(Create));

            }
            else
            {
                // if data invalid redirect to create page

                ViewBag.LanguageID = new SelectList(bookShopContext.languages, "LanguageId", "LanguageName");
                ViewBag.PublisherID = new SelectList(bookShopContext.publishers, "PublisherId", "PublisherName");
                ViewBag.AuthorID = new SelectList(bookShopContext.Authers.Select
                    (x => new AuthorList()
                    { AuthorID = x.AutherId, NameFamily = x.FirstName + " " + x.LastName }), "AuthorID", "NameFamily");

                ViewBag.TranslatorID = new SelectList(bookShopContext.Translators, "Translator_Id", "Name");
                booksCreateViewModel.treeViewCategories = bookRepository.GetAll_categories();
                List<int> lstCategoryIReturnToView = new List<int>();
                if (booksCreateViewModel.CategoryID != null)
                {
                    ViewBag.showcategory = booksCreateViewModel.CategoryID.ToList();

                }
                return View("Create", booksCreateViewModel);
            }
        }
    }
}
