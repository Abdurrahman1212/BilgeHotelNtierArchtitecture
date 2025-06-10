using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            // Table Name  
            builder.ToTable("Payment");

            // Primary Key  
            builder.HasKey(p => p.Id);

            // Properties  
            builder.Property(p => p.PaymentDate)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(p => p.PaymentAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(p => p.PaymentMethod)
                .IsRequired()
                .HasMaxLength(50);


            // Foreign Key  
            builder.HasOne(p => p.Reservation)
                .WithMany(r => r.Payment) // Fix: Use the correct navigation property
                .HasForeignKey(p => p.ReservationId)
                .OnDelete(DeleteBehavior.Cascade);

            //// Seed Data  
            builder.HasData(
                new Payment
                {
                    Id = 1,
                    PaymentDate = DateTime.Now,
                    PaymentAmount = 100.00m,
                    PaymentMethod = Models.Enums.PaymentMethod.CreditCard,
                    ReservationId = 1
                },
                new Payment
                {
                    Id = 2,
                    PaymentDate = DateTime.Now.AddDays(-1),
                    PaymentAmount = 200.00m,
                    PaymentMethod = Models.Enums.PaymentMethod.Cash,
                    ReservationId = 2
                }
            );
        }
    }
}
