using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalApp.Domain.Entities;

namespace MedicalApp.Infrastructure.Configurations
{
    public class SpecialityConfiguration : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder.ToTable("specialties");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Description)
                .HasMaxLength(100);
            builder.HasIndex(x => x.Name)
                .IsUnique();

        }
    }
}
