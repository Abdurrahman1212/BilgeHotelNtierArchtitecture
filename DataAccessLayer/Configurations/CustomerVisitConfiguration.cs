using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace DataAccessLayer.Configurations
{
    public class CustomerVisitConfiguration : IEntityTypeConfiguration<CustomerVisit>
    {
        public void Configure(EntityTypeBuilder<CustomerVisit> builder)
        {
            builder.HasKey(cv => cv.Id);

            builder.Property(cv => cv.CheckInDate)
                .IsRequired();

            builder.Property(cv => cv.CheckOutDate)
                .IsRequired();

            builder.Property(cv => cv.NightsStayed)
                .IsRequired();

            builder.Property(cv => cv.TotalAmount)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(cv => cv.PackageType)
                .IsRequired();

            builder.Property(cv => cv.RoomNumbers)
                .HasMaxLength(500);

            builder.Property(cv => cv.NumberOfGuests)
                .IsRequired();

            builder.Property(cv => cv.VisitNotes)
                .HasMaxLength(1000);

            builder.Property(cv => cv.Rating)
                .IsRequired();

            // İlişkiler
            builder.HasOne(cv => cv.Customer)
                .WithMany(c => c.VisitHistory)
                .HasForeignKey(cv => cv.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
