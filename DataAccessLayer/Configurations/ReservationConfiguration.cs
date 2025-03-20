using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Data.FakeData;

namespace DataAccessLayer.Configurations
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            // Table name
            builder.ToTable("Reservations");

            //Primary Key
            builder.HasKey(r => r.Id);

            // Properties
            builder.Property(r => r.CheckInDate)
                .IsRequired();

            builder.Property(r => r.CheckOutDate)
                .IsRequired();

            builder.Property(r => r.PackageType)
                .IsRequired()
                .HasMaxLength(50);

            //todo TotalAmount decimal olması gerekiyor
            builder.Property(r => r.TotalAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.PaymentVerification)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(r => r.status)
                .IsRequired();

            // Relationships
            builder.HasOne(r => r.Room)
                .WithMany(rm => rm.Reservations)
                .HasForeignKey(r => r.RoomId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.Customer)
                .WithMany(c => c.Reservations)
                .HasForeignKey(r => r.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(ReservationsFakeData.GetFakeReservations());
        }
    }
}
