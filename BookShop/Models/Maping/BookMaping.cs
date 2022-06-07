using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.Maping
{
    public class BookMaping : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> modelBuilder)
        {

            modelBuilder.Property(x => x.Summary).HasMaxLength(200);
            modelBuilder.HasKey(x => x.BookId);

                modelBuilder.Property(x => x.Title).
                    HasMaxLength(50).HasColumnType("nvarchar(50)").IsRequired();

                modelBuilder.Property(x => x.ImagesPath).HasColumnType("image");

                modelBuilder.ToTable("BookInfo");

                //modelBuilder.Property(x => x.Count).IsRequired();
           
        }
    }
}
