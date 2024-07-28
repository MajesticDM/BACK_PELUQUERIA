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
        public void Configure(EntityTypeBuilder<AppointmentStatus> entity)
        {
            entity.HasKey(e => e.ApptStatusId)
                    .HasName("PK__APPOINTM__A5654C3740426F60");

            entity.ToTable("APPOINTMENT_STATUS");

            entity.Property(e => e.ApptStatusId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("APPT_STATUS_ID");

            entity.Property(e => e.ApptStatus)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APPT_STATUS");
        }
    }
}
