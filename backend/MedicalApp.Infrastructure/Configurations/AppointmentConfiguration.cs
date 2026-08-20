using MedicalApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Infrastructure.Configurations
{
    public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
    {
        public void Configure(EntityTypeBuilder<Appointment> builder)
        {
            builder.ToTable("appointments");

            builder.Property(x => x.Id);
            builder.Property(x => x.AppointmentDate)
                .IsRequired();
            builder.Property(x => x.Status)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Notes)
                .HasMaxLength(1000);
            builder.Property(x => x.CreatedAt)
                .IsRequired();

            //foraneas
            builder.HasOne(x => x.User)
                .WithMany()
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Doctor)
                .WithMany()
                .HasForeignKey(x => x.DoctorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
