using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MedicalApp.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalApp.Infrastructure.Configurations
{
    public class PaymentConfiguration: IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            builder.ToTable("payments");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Amount)
                .IsRequired()
                .HasPrecision(10, 2);
            builder.Property(x => x.Status)
                .IsRequired()
                .HasMaxLength(20);
            builder.Property(x => x.TransactionId)
                .HasMaxLength(100);

            builder.HasIndex(x => x.TransactionId)
                .IsUnique();

            builder.Property(x => x.CreatedAt)
                .IsRequired();
            builder.HasOne(x => x.Appointment)
                .WithMany()
                .HasForeignKey(x => x.AppointmentId)
                .OnDelete(DeleteBehavior.Cascade);


           
        }
    }
}
