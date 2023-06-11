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
    public class ApptStatusConfig : IEntityTypeConfiguration<AppointmentStatus>
    {
        public void Configure(EntityTypeBuilder<AppointmentStatus> builder)
        {
            builder.HasKey(e => e.ApptStatusId)
                    .HasName("PK__APPOINTM__A5654C37F889A601");

            builder.ToTable("APPOINTMENT_STATUS");

            builder.Property(e => e.ApptStatusId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("APPT_STATUS_ID");

            builder.Property(e => e.ApptStatus)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APPT_STATUS");
        }
    }
}
