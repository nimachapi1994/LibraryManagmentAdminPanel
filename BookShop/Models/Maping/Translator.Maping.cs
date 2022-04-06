using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookShop.Models.Maping
{
    public class TranslatorMaping : IEntityTypeConfiguration<Translator>
    {
        public void Configure(EntityTypeBuilder<Translator> builder)
        {
            builder.ToTable("TranslatorInfo");
           // builder.HasKey(x => x.Translator_Id);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            List<Translator> translators = new List<Translator>()
            {
                new Translator{Translator_Id=1,Name="rezaei"},
                new Translator{Translator_Id=2,Name="chapi"},
                new Translator{Translator_Id=3,Name="ahmadi"},
            };
            builder.HasData(translators);
        }
    }
}
