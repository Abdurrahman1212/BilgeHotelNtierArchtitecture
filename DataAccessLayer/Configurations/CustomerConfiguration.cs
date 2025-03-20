using DataAccessLayer.Data.FakeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace DataAccessLayer.Configurations
{
    public class CustomerConfiguration:IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Table name
            builder.ToTable("Customers");

            // Primary key
           builder.HasKey(c => c.Id);

            // Properties


            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.City)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(c => c.County)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.PostalCode)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(c => c.CustomerPhone)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(c => c.CustomerAddress)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.CustomerIdentityNumber)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(c => c.CustomerPaymentDetails)
                .IsRequired()
                .HasMaxLength(200);

            // Relationships
            builder.HasMany(c => c.Reservations)
                .WithOne(r => r.Customer)
                .HasForeignKey(r => r.Id)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(CustomerFakeData.Customers());
        }
    }
}


