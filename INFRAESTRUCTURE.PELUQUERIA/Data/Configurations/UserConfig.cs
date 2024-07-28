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
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> entity)
        {
            entity.ToTable("USERS");

            entity.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("USER_ID");

            entity.Property(e => e.Employee).HasColumnName("EMPLOYEE");

            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasColumnName("PASSWORD");

            entity.Property(e => e.PersonIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PERSON_IDX");

            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");
        }
    }
}
