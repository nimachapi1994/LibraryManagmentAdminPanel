using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.ViewModels
{
    public class BooksCreateViewModel

    {


        public BooksCreateViewModel(List<TreeViewCategory> _treeViewCategories)
        {
            treeViewCategories = _treeViewCategories;
        }
        public BooksCreateViewModel()
        {

        }
        public List<TreeViewCategory> treeViewCategories;
        [Required(ErrorMessage = "وارد کردن عنوان کتاب الزامی است")]
        public string Title { get; set; }
        [Required(ErrorMessage = "وارد کردن خلاصه کتاب الزامی است")]
        public string Summary { get; set; }
        [Required(ErrorMessage = "وارد کردن قیمت کتاب الزامی است")]
        public int Price { get; set; }
        [Required(ErrorMessage = "وارد کردن موجودی کتاب الزامی است")]
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
        [Required(ErrorMessage = "وارد کردن زبان کتاب الزامی است")]
        public int LanguageID { get; set; }

        [Required(ErrorMessage = "وارد کردن ناشر کتاب الزامی است")]
        public int PublisherID { get; set; }
        [Required(ErrorMessage = "وارد کردن سال انتشار کتاب الزامی است")]
        public int PublishYear { get; set; }
        [Required(ErrorMessage = "وارد کردن نویسنده کتاب الزامی است")]
        public int[] AuthorID { get; set; }
        [Required(ErrorMessage = "وارد کردن مترجم کتاب الزامی است")]
        public int[] TranslatorID { get; set; }
        [Required(ErrorMessage = "وارد کردن دسته بندی کتاب الزامی است")]
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
        [Display(Name = "عنوان")]
        public string Title { get; set; }

        public string Stock { get; set; }
        [Display(Name = "قیمت (ریال)")]
        public int Price { get; set; }
        [Display(Name = "شابک")]
        public string ISBN { get; set; }
        [Display(Name = "ناشر")]
        public string PublisherName { get; set; }
        [Display(Name = "تاریخ انتشار  ")]
        public DateTime? PublishDate { get; set; }
        [Display(Name = "وضعیت")]
        public bool Ispublish { get; set; }
        [Display(Name = "نویسندگان")]
        public string Auther { get; set; }
        public string translator { get; set; }
        public string languageName { get; set; }
        public string CategoryName { get; set; }
        public int NumberOfPages { get; set; }

    }
}
