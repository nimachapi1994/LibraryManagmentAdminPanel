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


            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Category_Name = "هنر" },
                new Category { CategoryId = 2, Category_Name = "آشپزی" },
                new Category { CategoryId = 3, Category_Name = "علمی" },
                new Category { CategoryId = 4, Category_Name = "انگیزشی" },
                new Category { CategoryId = 5, Category_Name = "عمومی" },
                new Category { CategoryId = 6, Category_Name = "دانشگاهی" }
                );

            //var CategoryData = new object[,] {
            //    {1,"هنر" },
            //    {1,"هنر" },
            //    {1,"هنر" },
            //    {1,"هنر" },
            //    {1,"هنر" }
            //};
            //modelBuilder.Entity<Category>().HasData(CategoryData);

            modelBuilder.Entity<Book>().Property(x => x.Summary).HasMaxLength(200);


        }



        DbSet<Book> Books { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<Sub_Category> Sub_Categories { get; set; }
        DbSet<Language> languages { get; set; }
        DbSet<Discount> Discounts { get; set; }
        DbSet<Auther_Book> Auther_Books { get; set; }
        DbSet<Auther> Authers { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<State> States { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Order_Status> Order_Statuses { get; set; }
        DbSet<Order_Book> Order_Books { get; set; }
        DbSet<Publisher> publishers { get; set; }
    }
}
