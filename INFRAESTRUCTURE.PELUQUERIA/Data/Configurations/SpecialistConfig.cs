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
    public class SpecialistConfig : IEntityTypeConfiguration<Specialist>
    {
        public void Configure(EntityTypeBuilder<Specialist> entity)
        {
            entity.ToTable("SPECIALISTS");

            entity.Property(e => e.SpecialistId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("SPECIALIST_ID");

            entity.Property(e => e.BitAdmin).HasColumnName("BIT_ADMIN");

            entity.Property(e => e.BitStatus).HasColumnName("BIT_STATUS");

            entity.Property(e => e.SpecialistEmail)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SPECIALIST_EMAIL");

            entity.Property(e => e.SpecialistName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SPECIALIST_NAME");

            entity.Property(e => e.SpecialistNote)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SPECIALIST_NOTE");

            entity.Property(e => e.SpecialistPhone)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SPECIALIST_PHONE");

            entity.Property(e => e.SpecialistPhoto).HasColumnName("SPECIALIST_PHOTO");
        }
    }
}
