using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalApp.Domain.Entities;

namespace MedicalApp.Infrastructure.Configurations
{
    public class DoctorConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.ToTable("doctors");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.LicenseNumber)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.Description)
                .HasMaxLength(100);

            builder.Property(x => x.ConsultationPrice)
                .HasPrecision(10, 2);

            builder.Property(x => x.IsActive)
                .IsRequired();

            builder.Property(x => x.CreatedAt)
                .IsRequired();

        }
    }
}
