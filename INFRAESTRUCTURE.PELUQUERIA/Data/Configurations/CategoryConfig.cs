using CORE.PELUQUERIA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.PELUQUERIA.Data.Configurations
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(e => e.CategorieId)
                    .HasName("PK__CATEGORI__235104C3B8ABF743");

            builder.ToTable("CATEGORIES");

            builder.Property(e => e.CategorieId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("CATEGORIE_ID");

            builder.Property(e => e.Categorie)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CATEGORIE");
        }
    }
}
