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
    public class PersonaConfig : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(e => e.IdPersona)
                    .HasName("PK__PERSONAS__78244149D2F8685D");

            builder.ToTable("PERSONAS");

            builder.Property(e => e.IdPersona)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("ID_PERSONA");

            builder.Property(e => e.Apellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");

            builder.Property(e => e.ApellidoDos)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("APELLIDO_DOS");

            builder.Property(e => e.Estado).HasColumnName("ESTADO");

            builder.Property(e => e.Foto).HasColumnName("FOTO");

            builder.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
        }
    }
}
