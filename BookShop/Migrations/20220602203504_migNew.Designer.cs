﻿// <auto-generated />
using System;
using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookShop.Migrations
{
    [DbContext(typeof(BookShopContext))]
    [Migration("20220602203504_migNew")]
    partial class migNew
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BookShop.Models.Auther", b =>
                {
                    b.Property<int>("AutherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AutherId");

                    b.ToTable("Authers");
                });

            modelBuilder.Entity("BookShop.Models.Auther_Book", b =>
                {
                    b.Property<int>("AutherBook_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AutherId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("AutherBook_Id");

                    b.HasIndex("AutherId");

                    b.HasIndex("BookId");

                    b.ToTable("Auther_Books");
                });

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("FileDownload_Book")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("ImagesPath")
                        .HasColumnType("image");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPublish")
                        .HasColumnType("bit");

                    b.Property<int>("LangId")
                        .HasColumnType("int");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PublishYear")
                        .HasColumnType("int");

                    b.Property<int>("PublisherID")
                        .HasColumnType("int");

                    b.Property<string>("Stock")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("BookId");

                    b.HasIndex("LangId");

                    b.HasIndex("PublisherID");

                    b.ToTable("BookInfo");
                });

            modelBuilder.Entity("BookShop.Models.Book_Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("book_Categories");
                });

            modelBuilder.Entity("BookShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Category_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ParentCategoryID")
                        .HasColumnType("int");

                    b.HasKey("CategoryId");

                    b.HasIndex("ParentCategoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Category_Name = "هنر"
                        },
                        new
                        {
                            CategoryId = 2,
                            Category_Name = "آشپزی"
                        },
                        new
                        {
                            CategoryId = 3,
                            Category_Name = "علمی"
                        },
                        new
                        {
                            CategoryId = 4,
                            Category_Name = "انگیزشی"
                        },
                        new
                        {
                            CategoryId = 5,
                            Category_Name = "عمومی"
                        },
                        new
                        {
                            CategoryId = 6,
                            Category_Name = "دانشگاهی"
                        });
                });

            modelBuilder.Entity("BookShop.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("StateId")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.HasIndex("StateId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("BookShop.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("City1CityId")
                        .HasColumnType("int");

                    b.Property<int?>("City2CityId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Fname");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Lname");

                    b.Property<string>("Mobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tell")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.HasIndex("City1CityId");

                    b.HasIndex("City2CityId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("BookShop.Models.Discount", b =>
                {
                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("Percent")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookId");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("BookShop.Models.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("LanguageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LanguageId");

                    b.ToTable("languages");
                });

            modelBuilder.Entity("BookShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<long>("Amount")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("BuyDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("DispathNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Order_StatusOrderStatus_Id")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("Order_StatusOrderStatus_Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookShop.Models.Order_Book", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Order_Books");
                });

            modelBuilder.Entity("BookShop.Models.Order_Status", b =>
                {
                    b.Property<int>("OrderStatus_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("OrderStatus_Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderStatus_Id");

                    b.ToTable("Order_Statuses");
                });

            modelBuilder.Entity("BookShop.Models.Publisher", b =>
                {
                    b.Property<int>("PublisherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("PublisherName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PublisherId");

                    b.ToTable("publishers");
                });

            modelBuilder.Entity("BookShop.Models.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("BookShop.Models.Translator", b =>
                {
                    b.Property<int>("Translator_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Translator_Id");

                    b.ToTable("TranslatorInfo");

                    b.HasData(
                        new
                        {
                            Translator_Id = 1,
                            Name = "rezaei"
                        },
                        new
                        {
                            Translator_Id = 2,
                            Name = "chapi"
                        },
                        new
                        {
                            Translator_Id = 3,
                            Name = "ahmadi"
                        });
                });

            modelBuilder.Entity("BookShop.Models.Translator_Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("translatorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("translatorId");

                    b.ToTable("translator_Books");
                });

            modelBuilder.Entity("BookShop.Models.Auther_Book", b =>
                {
                    b.HasOne("BookShop.Models.Auther", "Auther")
                        .WithMany("Authers_Book")
                        .HasForeignKey("AutherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShop.Models.Book", "Book")
                        .WithMany("Authers_Book")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auther");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.HasOne("BookShop.Models.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShop.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("BookShop.Models.Book_Category", b =>
                {
                    b.HasOne("BookShop.Models.Book", "book")
                        .WithMany("book_Categories")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShop.Models.Category", "Category")
                        .WithMany("book_Categories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BookShop.Models.Category", b =>
                {
                    b.HasOne("BookShop.Models.Category", "category")
                        .WithMany("categories")
                        .HasForeignKey("ParentCategoryID");

                    b.Navigation("category");
                });

            modelBuilder.Entity("BookShop.Models.City", b =>
                {
                    b.HasOne("BookShop.Models.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId");

                    b.Navigation("State");
                });

            modelBuilder.Entity("BookShop.Models.Customer", b =>
                {
                    b.HasOne("BookShop.Models.City", "City1")
                        .WithMany("Customers1")
                        .HasForeignKey("City1CityId");

                    b.HasOne("BookShop.Models.City", "City2")
                        .WithMany("Customers2")
                        .HasForeignKey("City2CityId");

                    b.Navigation("City1");

                    b.Navigation("City2");
                });

            modelBuilder.Entity("BookShop.Models.Discount", b =>
                {
                    b.HasOne("BookShop.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("BookShop.Models.Order", b =>
                {
                    b.HasOne("BookShop.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId");

                    b.HasOne("BookShop.Models.Order_Status", "Order_Status")
                        .WithMany("Orders")
                        .HasForeignKey("Order_StatusOrderStatus_Id");

                    b.Navigation("Customer");

                    b.Navigation("Order_Status");
                });

            modelBuilder.Entity("BookShop.Models.Order_Book", b =>
                {
                    b.HasOne("BookShop.Models.Book", null)
                        .WithMany("Order_Books")
                        .HasForeignKey("BookId");

                    b.HasOne("BookShop.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShop.Models.Order", "Order")
                        .WithMany("Order_Books")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BookShop.Models.Translator_Book", b =>
                {
                    b.HasOne("BookShop.Models.Book", "book")
                        .WithMany("translator_Books")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookShop.Models.Translator", "translator")
                        .WithMany("translator_Books")
                        .HasForeignKey("translatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("book");

                    b.Navigation("translator");
                });

            modelBuilder.Entity("BookShop.Models.Auther", b =>
                {
                    b.Navigation("Authers_Book");
                });

            modelBuilder.Entity("BookShop.Models.Book", b =>
                {
                    b.Navigation("Authers_Book");

                    b.Navigation("book_Categories");

                    b.Navigation("Order_Books");

                    b.Navigation("translator_Books");
                });

            modelBuilder.Entity("BookShop.Models.Category", b =>
                {
                    b.Navigation("book_Categories");

                    b.Navigation("categories");
                });

            modelBuilder.Entity("BookShop.Models.City", b =>
                {
                    b.Navigation("Customers1");

                    b.Navigation("Customers2");
                });

            modelBuilder.Entity("BookShop.Models.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BookShop.Models.Language", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookShop.Models.Order", b =>
                {
                    b.Navigation("Order_Books");
                });

            modelBuilder.Entity("BookShop.Models.Order_Status", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("BookShop.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("BookShop.Models.State", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("BookShop.Models.Translator", b =>
                {
                    b.Navigation("translator_Books");
                });
#pragma warning restore 612, 618
        }
    }
}
