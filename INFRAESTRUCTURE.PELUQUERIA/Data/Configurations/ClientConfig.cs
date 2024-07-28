using CORE.PELUQUERIA.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFRAESTRUCTURE.PELUQUERIA.Data.Configurations
{
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Client> entity)
        {
            entity.ToTable("CLIENTS");

            entity.Property(e => e.ClientId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("CLIENT_ID");

            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LAST_NAME");

            entity.Property(e => e.LastVisit)
                .HasColumnType("datetime")
                .HasColumnName("LAST_VISIT");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NAME");

            entity.Property(e => e.Photo).HasColumnName("PHOTO");

            entity.Property(e => e.SpecialistNote)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("SPECIALIST_NOTE");

        }
    }
}
