using BookShop.Models.Maping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class BookShopContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder builder)
        //{
        //    builder.UseSqlServer("Server=(local);Database=MyBookShopDB;Trusted_Connection=True");
        //}
        public BookShopContext(DbContextOptions<BookShopContext> dbContextOptions)
            : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.ApplyConfiguration(new BookMaping());
            modelBuilder.ApplyConfiguration(new TranslatorMaping());


            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Category_Name = "هنر" },
                new Category { CategoryId = 2, Category_Name = "آشپزی" },
                new Category { CategoryId = 3, Category_Name = "علمی" },
                new Category { CategoryId = 4, Category_Name = "انگیزشی" },
                new Category { CategoryId = 5, Category_Name = "عمومی" },
                new Category { CategoryId = 6, Category_Name = "دانشگاهی" }
                );





        }


        public DbSet<Translator> Translators { get; set; }
        public DbSet<Translator_Book>  translator_Books { get; set; }
        public DbSet<Book_Category> book_Categories{ get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Language> languages { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Auther_Book> Auther_Books { get; set; }
        public DbSet<Auther> Authers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Order_Status> Order_Statuses { get; set; }
        public DbSet<Order_Book> Order_Books { get; set; }
        public DbSet<Publisher> publishers { get; set; }
    }
}
