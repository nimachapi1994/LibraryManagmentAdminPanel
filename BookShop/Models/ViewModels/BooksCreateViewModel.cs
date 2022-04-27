using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.ViewModels
{
    public class BooksCreateViewModel

    {
        // public IEnumerable<TreeViewCategory> Categories { get; set; }
        public IEnumerable<TreeViewCategory> treeViewCategories;
        public BooksCreateViewModel(IEnumerable<TreeViewCategory> _treeViewCategories)
        {
            treeViewCategories = _treeViewCategories;
        }
        public BooksCreateViewModel()
        {

        }
        [Required(ErrorMessage = "وارد کردن عنوان کتاب الزامی است")]
        public string Title { get; set; }
        [Required(ErrorMessage = "وارد کردن خلاصه کتاب الزامی است")]
        public string Summary { get; set; }
        [Required(ErrorMessage = "وارد کردن قیمت کتاب الزامی است")]
        public int Price { get; set; }

        public string Stock { get; set; }
    //    [Required(ErrorMessage = "وارد کردن فایل کتاب الزامی است")]
     //   public string File { get; set; }
        [Required(ErrorMessage = "وارد کردن صفحات کتاب الزامی است")]
        public int NumOfPages { get; set; }
        [Required(ErrorMessage = "وارد کردن وزن کتاب الزامی است")]
        public short Weight { get; set; }
        [Required(ErrorMessage = "وارد کردن شابک کتاب الزامی است")]
        public string ISBN { get; set; }
        [Display(Name = "کتاب در سایت نمایش داده شود")]
        public bool IsPublish { get; set; }

        public int LanguageID { get; set; }


        public int PublisherID { get; set; }

        public int PublishYear { get; set; }
        public int[] AuthorID { get; set; }

        public int[] TranslatorID { get; set; }

           public int[] CategoryID { get; set; }
    }
    public class AuthorList
    {
        public int AuthorID { get; set; }
        public string NameFamily { get; set; }
    }

    public class BookIndexViewModel
    {
        public int bookId { get; set; }
        public string Title { get; set; }
        public string Stock { get; set; }
        public int Price { get; set; }
        public string ISBN { get; set; }
        public string PublisherName { get; set; }
        public DateTime? PublishDate { get; set; }
        public bool Ispublish { get; set; }
        public string Auther { get; set; }

    }
}
