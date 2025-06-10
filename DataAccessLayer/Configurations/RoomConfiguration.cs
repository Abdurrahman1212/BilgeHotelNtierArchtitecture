using DataAccessLayer.Data.FakeData;
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
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {



        public void Configure(EntityTypeBuilder<Room> builder)
        {
            // Table name
            builder.ToTable("Rooms");

            // Primary key
            builder.HasKey(r => r.Id);

            // Properties


            builder.Property(r => r.RoomNumber)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(r => r.Type)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(r => r.RoomCapacity)
                .IsRequired();

            builder.Property(r => r.PricePerNight)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(r => r.HasBalcony)
                .IsRequired();
            builder.Property(r=>r.RoomBreakfast).IsRequired();

            builder.Property(r => r.HasMinibar)
                .IsRequired();

            builder.Property(r => r.DataStasus)
                .IsRequired();

            builder.Property(r => r.CreatedDate)
                .IsRequired();

            builder.Property(r => r.UpdatedDate)
                .IsRequired();

            // Relationships
            builder.HasMany(r => r.Reservations)
                .WithOne(res => res.Room)
                .HasForeignKey(res => res.RoomId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(RoomFakeData.GenerateRooms());
        }


    }
}
