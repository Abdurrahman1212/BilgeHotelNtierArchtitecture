using DataAccessLayer.Configurations.Context;
using Models.Entities;

namespace DataAccessLayer.Services.Concretes
{
    public class DatabaseManagementRepo : ManagerRepository<DatabaseConfiguration>
    {
        private readonly ProjectDatabaseContext _context;

        public DatabaseManagementRepo(ProjectDatabaseContext context) : base(context)
        {
            _context = context;
        }

        public async Task<DatabaseConfiguration> CreateConfigurationAsync(DatabaseConfiguration configuration)
        {
            await _context.DatabaseConfigurations.AddAsync(configuration);
            await _context.SaveChangesAsync();
            return configuration;
        }

        public async Task<DatabaseConfiguration> UpdateConfigurationAsync(DatabaseConfiguration configuration)
        {
            _context.DatabaseConfigurations.Update(configuration);
            await _context.SaveChangesAsync();
            return configuration;
        }

        public async Task<DatabaseConfiguration> DeleteConfigurationAsync(DatabaseConfiguration configuration)
        {
            _context.DatabaseConfigurations.Remove(configuration);
            await _context.SaveChangesAsync();
            return configuration;
        }

        public async Task<List<DatabaseConfiguration>> GetAllConfigurationsAsync()
        {
            return _context.DatabaseConfigurations
                .Where(c => c.IsActive)
                .ToList();
        }

        public async Task<DatabaseConfiguration> GetConfigurationByIdAsync(int id)
        {
            return _context.DatabaseConfigurations
                .FirstOrDefault(c => c.Id == id && c.IsActive);
        }

        public async Task<DatabaseConfiguration> GetDefaultConfigurationAsync()
        {
            return _context.DatabaseConfigurations
                .FirstOrDefault(c => c.IsDefault && c.IsActive);
        }

        public async Task SetDefaultConfigurationAsync(int configId)
        {
            // Tüm konfigürasyonları varsayılan değil yap
            var allConfigs = _context.DatabaseConfigurations.ToList();
            foreach (var config in allConfigs)
            {
                config.IsDefault = false;
            }

            // Seçili konfigürasyonu varsayılan yap
            var selectedConfig = allConfigs.FirstOrDefault(c => c.Id == configId);
            if (selectedConfig != null)
            {
                selectedConfig.IsDefault = true;
            }

            await _context.SaveChangesAsync();
        }
    }

    public class DatabaseBackupRepo : ManagerRepository<DatabaseBackup>
    {
        private readonly ProjectDatabaseContext _context;

        public DatabaseBackupRepo(ProjectDatabaseContext context) : base(context)
        {
            _context = context;
        }

        public async Task<DatabaseBackup> CreateBackupAsync(DatabaseBackup backup)
        {
            await _context.DatabaseBackups.AddAsync(backup);
            await _context.SaveChangesAsync();
            return backup;
        }

        public async Task<DatabaseBackup> UpdateBackupAsync(DatabaseBackup backup)
        {
            _context.DatabaseBackups.Update(backup);
            await _context.SaveChangesAsync();
            return backup;
        }

        public async Task<DatabaseBackup> DeleteBackupAsync(DatabaseBackup backup)
        {
            _context.DatabaseBackups.Remove(backup);
            await _context.SaveChangesAsync();
            return backup;
        }

        public async Task<List<DatabaseBackup>> GetAllBackupsAsync()
        {
            return _context.DatabaseBackups
                .OrderByDescending(b => b.BackupDate)
                .ToList();
        }

        public async Task<List<DatabaseBackup>> GetBackupsByDatabaseNameAsync(string databaseName)
        {
            return _context.DatabaseBackups
                .Where(b => b.DatabaseName == databaseName)
                .OrderByDescending(b => b.BackupDate)
                .ToList();
        }

        public async Task<List<DatabaseBackup>> GetBackupsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return _context.DatabaseBackups
                .Where(b => b.BackupDate >= startDate && b.BackupDate <= endDate)
                .OrderByDescending(b => b.BackupDate)
                .ToList();
        }

        public async Task<DatabaseBackup> GetLatestBackupAsync(string databaseName)
        {
            return _context.DatabaseBackups
                .Where(b => b.DatabaseName == databaseName)
                .OrderByDescending(b => b.BackupDate)
                .FirstOrDefault();
        }
    }
}
