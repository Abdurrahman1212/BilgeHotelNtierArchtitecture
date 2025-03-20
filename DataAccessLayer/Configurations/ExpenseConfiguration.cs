using DataAccessLayer.Data.FakeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace DataAccessLayer.Configurations
{
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            // Table name
            builder.ToTable("Expenses");

            // Primary key
            builder.HasKey(e => e.Id);

            // Properties
           
                

            builder.Property(e => e.ExpenseName)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(e => e.ExpenseAmount)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.Property(e => e.ExpenseDate)
                .IsRequired();

            builder.Property(e => e.ExpenseDescription)
                .HasMaxLength(200);

            builder.Property(e => e.ExpenseStatus)
                .IsRequired();

            //  Relationships
            builder.HasOne(e => e.Reservation)
                .WithMany(r => r.Expenses)
                .HasForeignKey(r => r.ReservationId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(ExpeseFakeData.Expenses());
        }
    }
}


