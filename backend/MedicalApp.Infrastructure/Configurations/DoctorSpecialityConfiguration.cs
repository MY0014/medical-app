using MedicalApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalApp.Infrastructure.Configurations
{
    public class DoctorSpecialityConfiguration : IEntityTypeConfiguration<DoctorSpecialty>
    {
        public void Configure(EntityTypeBuilder<DoctorSpecialty> builder)
        {
            builder.ToTable("doctor_speciality");
            builder.HasKey(x => new
            {
                x.DoctorId,
                x.SpecialityId
            });

            builder.HasOne(x => x.Doctor)
                .WithMany(x => x.DoctorSpecialties)
                .HasForeignKey(x => x.DoctorId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Specialty)
                .WithMany(x => x.DoctorSpecialties)
                .HasForeignKey(x => x.SpecialityId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
