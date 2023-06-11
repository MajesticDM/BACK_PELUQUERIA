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
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("PRODUCTS");

            builder.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("PRODUCT_ID");

            builder.Property(e => e.CategorieIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CATEGORIE_IDX");

            builder.Property(e => e.Photo).HasColumnName("PHOTO");

            builder.Property(e => e.Product1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRODUCT");

            builder.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QUANTITY");

            builder.HasOne(d => d.CategorieIdxNavigation)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.CategorieIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PRODUCTS__CATEGO__4BAC3F29");
        }
    }
}
