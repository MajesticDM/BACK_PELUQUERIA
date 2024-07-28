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
    public class ApptTypeConfig : IEntityTypeConfiguration<AppointmentType>
    {
        public void Configure(EntityTypeBuilder<AppointmentType> entity)
        {
            entity.HasKey(e => e.ApptTypeId)
                   .HasName("PK__APPOINTM__CE54A777F1284426");

            entity.ToTable("APPOINTMENT_TYPES");

            entity.Property(e => e.ApptTypeId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("APPT_TYPE_ID");

            entity.Property(e => e.ApptType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APPT_TYPE");
        }
    }
}
