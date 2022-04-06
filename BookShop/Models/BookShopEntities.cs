using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    [Table("BookInfo")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        //[MaxLength(20)]
        //[Column(TypeName = "nvarchar(100)"), Required]
        public string Title { get; set; }

        public string Summary { get; set; }
        public int NumOfPage { get; set; }
        public short Weight { get; set; }
        public string ISBN { get; set; }
        public int Price { get; set; }

        public int Count { get; set; }

        public string FileDownload_Book { get; set; }


        //insert pic to db
        //[Column(TypeName ="image")]
        public byte[] ImagesPath { get; set; }


        public Sub_Category Sub_Category { get; set; }

        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public Discount Discount { get; set; }
        public List<Auther_Book> Authers_Book { get; set; }

        public List<Order_Book> Order_Books { get; set; }
        //public List<BookImages> BookImages { get; set; }

        ////json string format insert (serilaztion) and show by class view model decrialtion 
        //public string ImagePath { get; set; }
        public Publisher Publisher { get; set; }

        [ForeignKey("Translator")]
        public int TranslatorId { get; set; }
        public Translator Translator { get; set; }

    }

    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public List<Book> Books { get; set; }
    }

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Category_Name { get; set; }
        List<Sub_Category> Sub_Categories { get; set; }
    }
    public class Sub_Category
    {
        [Key]
        public int Sub_CategoryId { get; set; }
        public string Sub_Category_Name { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public List<Book> Books { get; set; }


    }
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public List<Book> Books { get; set; }
    }
    public class Discount
    {
        //[Key]
        //public int DiscountId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        [Key, ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        //byte 0 to 100 numbers
        public byte Percent { get; set; }

    }
    public class Auther
    {
        [Key]
        public int AutherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Auther_Book> Authers_Book { get; set; }
    }
    public class Auther_Book
    {
        [Key, ForeignKey("Book")]
        public int BookId { get; set; }

        public int AutherId { get; set; }
        public Book Book { get; set; }
        public Auther Auther { get; set; }

    }
    public class Customer
    {
        public int CustomerId { get; set; }
        [Column("Fname", TypeName = "nvarchar(50)")]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Column("Lname", TypeName = "nvarchar(50)"), Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [NotMapped]//در پایگاه این ستون ایجاد نمیشود
        public int Age { get; set; }
        public string Address1 { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address2 { get; set; }
        public string Mobile { get; set; }
        public string Tell { get; set; }
        public City City1 { get; set; }
        public City City2 { get; set; }
        //path string insert to folder
        public string Image { get; set; }

        public List<Order> Orders { get; set; }
    }
    public class State
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }
        public List<City> Cities { get; set; }
    }
    public class City
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CityId { get; set; }
        public string CityName { get; set; }
        public State State { get; set; }
        [InverseProperty("City1")]
        public List<Customer> Customers1 { get; set; }
        [InverseProperty("City2")]
        public List<Customer> Customers2 { get; set; }
    }



    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        public long Amount { get; set; }

        //کد رهگیری سفارش
        public string DispathNumber { get; set; }

        public DateTime BuyDate { get; set; }

        public Order_Status Order_Status { get; set; }
        public Customer Customer { get; set; }
        public List<Order_Book> Order_Books { get; set; }
    }
    public class Order_Status
    {
        [Key]
        public int OrderStatus_Id { get; set; }
        public string OrderStatus_Name { get; set; }
        public List<Order> Orders { get; set; }

    }

    public class Order_Book
    {
        [Key, ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }

    public class Translator
    {
        [Key]
        public int Translator_Id { get; set; }
        public string Name { get; set; }

        public List<Book> Books { get; set; }

    }



    //public class BookImages
    //{
    //    public int Id { get; set; }
    //    public Book Book { get; set; }
    //    public string ImagePath { get; set; }

    //}
}
