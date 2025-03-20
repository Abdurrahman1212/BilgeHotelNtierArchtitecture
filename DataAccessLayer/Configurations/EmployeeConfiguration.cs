using DataAccessLayer.Data.FakeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace DataAccessLayer.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            // Table name
            builder.ToTable("Employees");

            // Primary key
            builder.HasKey(e => e.Id);
            // Properties


            builder.Property(e => e.EmployeeFirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.EmployeeLastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.EmployeePhoneNumber)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.EmployeeAddres)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.City)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Country)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.PostalCode)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.HourlyWage)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(e => e.Status)
                .IsRequired();

            // Relationships
            builder.HasMany(e => e.Shifts)
                .WithOne(s => s.Employee)
                .HasForeignKey(s => s.Id)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(EmployeeFakeData.Employees().ToArray());
        }
    }
}


