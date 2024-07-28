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
        public void Configure(EntityTypeBuilder<News> entity)
        {
            entity.HasKey(e => e.NoticeId)
                    .HasName("PK__NEWS__9610A669ABE1D0D0");

            entity.ToTable("NEWS");

            entity.Property(e => e.NoticeId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("NOTICE_ID");

            entity.Property(e => e.DateEnd)
                .HasColumnType("datetime")
                .HasColumnName("DATE_END");

            entity.Property(e => e.DateStart)
                .HasColumnType("datetime")
                .HasColumnName("DATE_START");

            entity.Property(e => e.Notice)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOTICE");

            entity.Property(e => e.Photo).HasColumnName("PHOTO");

            entity.Property(e => e.SpecialistCreatorIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SPECIALIST_CREATOR_IDX");

            entity.Property(e => e.SpecialistInvolvedIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SPECIALIST_INVOLVED_IDX");

            entity.HasOne(d => d.SpecialistCreatorIdxNavigation)
                .WithMany(p => p.NewsSpecialistCreatorIdxNavigations)
                .HasForeignKey(d => d.SpecialistCreatorIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NEWS__SPECIALIST__4AB81AF0");

            entity.HasOne(d => d.SpecialistInvolvedIdxNavigation)
                .WithMany(p => p.NewsSpecialistInvolvedIdxNavigations)
                .HasForeignKey(d => d.SpecialistInvolvedIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__NEWS__SPECIALIST__4BAC3F29");

        }
    }
}
