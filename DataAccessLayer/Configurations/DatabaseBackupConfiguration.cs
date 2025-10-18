using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models.Entities;

namespace DataAccessLayer.Configurations
{
    public class DatabaseBackupConfiguration : IEntityTypeConfiguration<DatabaseBackup>
    {
        public void Configure(EntityTypeBuilder<DatabaseBackup> builder)
        {
            builder.HasKey(db => db.Id);

            builder.Property(db => db.BackupName)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(db => db.BackupPath)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(db => db.BackupFileName)
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(db => db.FileSize)
                .IsRequired();

            builder.Property(db => db.BackupDate)
                .IsRequired();

            builder.Property(db => db.BackupType)
                .IsRequired();

            builder.Property(db => db.DatabaseName)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(db => db.Description)
                .HasMaxLength(1000);

            builder.Property(db => db.Checksum)
                .HasMaxLength(50);

            // İlişkiler
            builder.HasOne(db => db.CreatedByEmployee)
                .WithMany()
                .HasForeignKey(db => db.CreatedByEmployeeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
