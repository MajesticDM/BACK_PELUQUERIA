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
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("USERS");

            builder.Property(e => e.UserId)
                .HasColumnType("numeric(18, 0)")
                .ValueGeneratedOnAdd()
                .HasColumnName("USER_ID");

            builder.Property(e => e.ClientIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("CLIENT_IDX");

            builder.Property(e => e.Password).HasColumnName("PASSWORD");

            builder.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("USER_NAME");

            builder.Property(e => e.UserTypeIdx)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("USER_TYPE_IDX");

            builder.HasOne(d => d.ClientIdxNavigation)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.ClientIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__USERS__CLIENT_ID__403A8C7D");

            builder.HasOne(d => d.UserTypeIdxNavigation)
                .WithMany(p => p.Users)
                .HasForeignKey(d => d.UserTypeIdx)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__USERS__USER_TYPE__412EB0B6");
        }
    }
}
