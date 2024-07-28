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
        public void Configure(EntityTypeBuilder<Appointment> entity)
        {
            entity.HasKey(e => e.ApptId)
                .HasName("PK__APPOINTM__D5523B58203C4623");

            entity.ToTable("APPOINTMENTS");

            entity.Property(e => e.ApptId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("APPT_ID");

            entity.Property(e => e.ApptStatusIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("APPT_STATUS_IDX");

            entity.Property(e => e.ApptTypeIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("APPT_TYPE_IDX");

            entity.Property(e => e.ClientIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CLIENT_IDX");

            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("DATE");

            entity.Property(e => e.Note)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("NOTE");

            entity.Property(e => e.SpecialistIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("SPECIALIST_IDX");

            entity.HasOne(d => d.ApptStatusIdxNavigation)
                .WithMany(p => p.Appointments)
                .HasForeignKey(d => d.ApptStatusIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APPOINTME__APPT___412EB0B6");

            entity.HasOne(d => d.ApptTypeIdxNavigation)
                .WithMany(p => p.Appointments)
                .HasForeignKey(d => d.ApptTypeIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APPOINTME__APPT___403A8C7D");

            entity.HasOne(d => d.ClientIdxNavigation)
                .WithMany(p => p.Appointments)
                .HasForeignKey(d => d.ClientIdx)
                .HasConstraintName("FK__APPOINTME__CLIEN__4316F928");

            entity.HasOne(d => d.SpecialistIdxNavigation)
                .WithMany(p => p.Appointments)
                .HasForeignKey(d => d.SpecialistIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__APPOINTME__SPECI__4222D4EF");
        }
    }
}
