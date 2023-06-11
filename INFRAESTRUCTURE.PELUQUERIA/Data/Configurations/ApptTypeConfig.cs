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
        public void Configure(EntityTypeBuilder<AppointmentType> builder)
        {
            builder.HasKey(e => e.ApptTypeId)
                    .HasName("PK__APPOINTM__CE54A7778DCFAE80");

            builder.ToTable("APPOINTMENT_TYPES");

            builder.Property(e => e.ApptTypeId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("APPT_TYPE_ID");

            builder.Property(e => e.ApptType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APPT_TYPE");
        }
    }
}
