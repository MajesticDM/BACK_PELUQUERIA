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
    public class NewsConfig : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasKey(e => e.NoticeId)
                    .HasName("PK__NEWS__9610A669BA6FA59E");

            builder.ToTable("NEWS");

            builder.Property(e => e.NoticeId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("NOTICE_ID");

            builder.Property(e => e.DateEnd)
                .HasColumnType("datetime")
                .HasColumnName("DATE_END");

            builder.Property(e => e.DateStart)
                .HasColumnType("datetime")
                .HasColumnName("DATE_START");

            builder.Property(e => e.Notice)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOTICE");

            builder.Property(e => e.Photo).HasColumnName("PHOTO");

        }
    }
}
