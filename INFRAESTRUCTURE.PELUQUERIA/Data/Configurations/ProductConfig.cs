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
        public void Configure(EntityTypeBuilder<Product> entity)
        {
            entity.ToTable("PRODUCTS");

            entity.Property(e => e.ProductId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("PRODUCT_ID");

            entity.Property(e => e.CategorieIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CATEGORIE_IDX");

            entity.Property(e => e.Photo).HasColumnName("PHOTO");

            entity.Property(e => e.Product1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PRODUCT");

            entity.Property(e => e.Quantity)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("QUANTITY");

            entity.HasOne(d => d.CategorieIdxNavigation)
                .WithMany(p => p.Products)
                .HasForeignKey(d => d.CategorieIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__PRODUCTS__CATEGO__47DBAE45");
        }
    }
}
