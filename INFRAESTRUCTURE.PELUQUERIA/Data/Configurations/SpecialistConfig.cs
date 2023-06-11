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
        public void Configure(EntityTypeBuilder<Specialist> builder)
        {
            builder.ToTable("SPECIALISTS");

            builder.Property(e => e.SpecialistId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("SPECIALIST_ID");

            builder.Property(e => e.SpecialistName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SPECIALIST_NAME");

            builder.Property(e => e.SpecialistNote)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SPECIALIST_NOTE");

            builder.Property(e => e.SpecialistPhone)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SPECIALIST_PHONE");

            builder.Property(e => e.SpecialistPhoto).HasColumnName("SPECIALIST_PHOTO");
        }
    }
}
