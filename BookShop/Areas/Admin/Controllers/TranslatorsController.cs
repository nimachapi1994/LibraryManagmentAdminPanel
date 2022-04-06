using BookShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TranslatorsController : Controller
    {
        protected readonly BookShopContext bookShopContext;
        public TranslatorsController(BookShopContext _bookShopContext)
        {
            bookShopContext = _bookShopContext;
        }
        public async Task<IActionResult> Index()
        {

            var d = bookShopContext.Books.Select(x => x.BookId).ToList();

            
            foreach (var item in d)
            {
                string name = "";
                var id = bookShopContext.Auther_Books.Where(x => x.BookId == item);
                if (id.Any())
                {
                    name += id.Select(x => x.Auther.FirstName).FirstOrDefault();

                }

            }










            return View(await bookShopContext.Translators.ToListAsync());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Translator translator)
        {
            if (ModelState.IsValid)
            {
                bookShopContext.Translators.Add(new Translator
                {
                    Name = translator.Name
                });
                await bookShopContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(nameof(Create), translator);
            }
        }
    }
}
