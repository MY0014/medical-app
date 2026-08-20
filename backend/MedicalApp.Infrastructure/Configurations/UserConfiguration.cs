using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalApp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalApp.Infrastructure.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength (100);
            builder.Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(150);
            builder.HasIndex(x => x.Email)
                .IsUnique();
            builder.Property(x => x.PasswordHash)
                .IsRequired();
            builder.Property(x => x.Role)
                .IsRequired()
                .HasMaxLength(30);
            builder.Property(x => x.CreatedAt)
                .IsRequired();
          
        }
    }
}
