using DataAccessLayer.Data.FakeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models.Entities;

namespace DataAccessLayer.Configurations
{
    public class ShiftConfiguration : IEntityTypeConfiguration<Shift>
    {
        public void Configure(EntityTypeBuilder<Shift> builder)
        {
            // Table name
            builder.ToTable("Shifts");

            //   Primary key
            builder.HasKey(s => s.Id);
            // Properties

            builder.Property(s => s.ShiftType)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(s => s.StartTime)
                .IsRequired();

            builder.Property(s => s.EndTime)
                .IsRequired();

            //  Relationships
            builder.HasOne(s => s.Employee)
                .WithMany(e => e.Shifts)
                .HasForeignKey(s => s.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(ShiftsFakeData.GetFakeShifts());
        }
    }
}


