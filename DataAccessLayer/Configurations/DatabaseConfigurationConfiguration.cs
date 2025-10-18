using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace DataAccessLayer.Configurations
{
    public class DatabaseConfigurationConfiguration : IEntityTypeConfiguration<DatabaseConfiguration>
    {
        public void Configure(EntityTypeBuilder<DatabaseConfiguration> builder)
        {
            builder.HasKey(dc => dc.Id);

            builder.Property(dc => dc.ServerName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(dc => dc.DatabaseName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(dc => dc.Username)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(dc => dc.Password)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(dc => dc.Port)
                .IsRequired();

            builder.Property(dc => dc.ConnectionString)
                .HasMaxLength(500);

            builder.Property(dc => dc.IsActive)
                .IsRequired();

            builder.Property(dc => dc.IsDefault)
                .IsRequired();

            builder.Property(dc => dc.Notes)
                .HasMaxLength(1000);
        }
    }
}
