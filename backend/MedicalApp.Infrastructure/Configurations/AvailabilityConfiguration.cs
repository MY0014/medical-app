using MedicalApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Infrastructure.Configurations
{
    public class AvailabilityConfiguration: IEntityTypeConfiguration<Availability>
    {
        public void Configure(EntityTypeBuilder<Availability> builder)
        {
            builder.ToTable("availabilities");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DayOfWeek)
                .IsRequired();
            builder.Property(x => x.StartTime)
                .IsRequired();
            builder.Property(x => x.EndTime)
                .IsRequired();


            //foraneas
            builder.HasOne(x => x.Doctor)
                .WithMany(x => x.Availabilities)
                .HasForeignKey(x => x.DoctorId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
