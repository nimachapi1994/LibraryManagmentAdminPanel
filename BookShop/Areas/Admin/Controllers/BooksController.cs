using BookShop.Data;
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
        public IActionResult Detail(int id)
        {
            Book book = bookRepository.GetBookDetail(id).Item1;
            ViewBag.showAuthors = bookRepository.GetBookDetail(id).Item2;
            ViewBag.Translators_book = bookRepository.GetBookDetail(id).Item3;
            ViewBag.Category_book = bookRepository.GetBookDetail(id).Item4;

            return View(book);
        }


        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> AdvancedSearch(AdvanceSearchBook ViewModel)
        {
            ViewModel.title = String.IsNullOrEmpty(ViewModel.title) ? "" : ViewModel.title;
            ViewModel.ISBN = String.IsNullOrEmpty(ViewModel.ISBN) ? "" : ViewModel.ISBN;
            ViewModel.Publisher = String.IsNullOrEmpty(ViewModel.Publisher) ? "" : ViewModel.Publisher;
            ViewModel.Author = String.IsNullOrEmpty(ViewModel.Author) ? "" : ViewModel.Author;
            ViewModel.Translator = String.IsNullOrEmpty(ViewModel.Translator) ? "" : ViewModel.Translator;
            ViewModel.Category = String.IsNullOrEmpty(ViewModel.Category) ? "" : ViewModel.Category;
            ViewModel.Language = String.IsNullOrEmpty(ViewModel.Language) ? "" : ViewModel.Language;

            IEnumerable<BookIndexViewModel> getAdvancedBookSearch =
                  await bookRepository.getAllBooksInAdminPanel(ViewModel.title, ViewModel.ISBN,
                  ViewModel.Language, ViewModel.Publisher, ViewModel.Author, ViewModel.Translator, ViewModel.Category);

            string jsonBookData =
                Newtonsoft.Json.JsonConvert.SerializeObject(getAdvancedBookSearch);
            return RedirectToAction(nameof(AdvancedSearchPage), new { data = jsonBookData });

        }
        [HttpGet]
        [RequestSizeLimit(100_000_000)]
        public IActionResult AdvancedSearchPage(string data)
        {
            return View(Newtonsoft.Json.JsonConvert.DeserializeObject<List<BookIndexViewModel>>(data));
        }
        public async Task<IActionResult> Index(int pageIndex = 1, int row = 5, string sortExpression = "Title", string title = "")
        {
            ViewBag.search = title;

            // set pagination Rows list numbers for user dynamic use it
            int[] Rows = { 1, 2, 5, 10, 20, 50, 100 };
            ViewBag.RowId = new SelectList(Rows, row);

            ViewBag.BookNumber = (pageIndex - 1) * row + 1;
            //paging this Query


            //get all books in index admin panel by not use advanced Search.....! just read All Books

            IEnumerable<BookIndexViewModel> books = await bookRepository.getAllBooksInAdminPanel("", "", "", "", "", "", "");

            var pageResult = PagingList.Create(books, row, pageIndex, sortExpression, "Title");

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
            ViewBag.Categories = bookRepository.GetAll_categories();

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
            List<Book_Category> book_Categories = new List<Book_Category>();
            if (ModelState.IsValid)
            {

                // if data is ok create a new book

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
                if (booksCreateViewModel.CategoryID != null)
                {
                    foreach (int CategoryId_Item in booksCreateViewModel.CategoryID)
                    {
                        book_Categories.Add(new Book_Category
                        {
                            BookId = book.BookId,
                            CategoryId = CategoryId_Item
                        });

                    }
                }
                await bookShopContext.book_Categories.AddRangeAsync(book_Categories);
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

