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
           
            //// Seed Data  
            builder.HasData(PaymentFakeData.GetFakePayments());
        }


    }
}
