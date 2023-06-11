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
    public class ApptConfig : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.HasKey(e => e.ApptId)
                   .HasName("PK__APPOINTM__D5523B5834F2B4E6");

            builder.ToTable("APPOINTMENTS");

            builder.Property(e => e.ApptId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("APPT_ID");

            builder.Property(e => e.ApptStatusIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("APPT_STATUS_IDX");

            builder.Property(e => e.ApptTypeIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("APPT_TYPE_IDX");

            builder.Property(e => e.ClientIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CLIENT_IDX");

            builder.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");

            builder.Property(e => e.Note)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOTE");

            builder.Property(e => e.SpecialistIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SPECIALIST_IDX");

            builder.HasOne(d => d.ApptStatusIdxNavigation)
                .WithMany(p => p.Appointments)
                .HasForeignKey(d => d.ApptStatusIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APPOINTME__APPT___44FF419A");

            builder.HasOne(d => d.ApptTypeIdxNavigation)
                .WithMany(p => p.Appointments)
                .HasForeignKey(d => d.ApptTypeIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APPOINTME__APPT___440B1D61");

            builder.HasOne(d => d.ClientIdxNavigation)
                .WithMany(p => p.Appointments)
                .HasForeignKey(d => d.ClientIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APPOINTME__CLIEN__46E78A0C");

            builder.HasOne(d => d.SpecialistIdxNavigation)
                .WithMany(p => p.Appointments)
                .HasForeignKey(d => d.SpecialistIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APPOINTME__SPECI__45F365D3");
        }
    }
}
