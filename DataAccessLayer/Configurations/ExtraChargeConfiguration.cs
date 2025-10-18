using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace DataAccessLayer.Configurations
{
    public class ExtraChargeConfiguration : IEntityTypeConfiguration<ExtraCharge>
    {
        public void Configure(EntityTypeBuilder<ExtraCharge> builder)
        {
            builder.HasKey(ec => ec.Id);

            builder.Property(ec => ec.Description)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(ec => ec.Amount)
                .HasPrecision(18, 2)
                .IsRequired();

            builder.Property(ec => ec.Quantity)
                .IsRequired();

            builder.Property(ec => ec.ChargeDate)
                .IsRequired();

            builder.Property(ec => ec.IsPaid)
                .IsRequired();

            // İlişkiler
            builder.HasOne(ec => ec.Reservation)
                .WithMany()
                .HasForeignKey(ec => ec.ReservationId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ec => ec.Customer)
                .WithMany()
                .HasForeignKey(ec => ec.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ec => ec.CreatedByEmployee)
                .WithMany()
                .HasForeignKey(ec => ec.CreatedByEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
