using Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace BussinessLogicLayer.Services
{
    public class DatabaseManagementService
    {
        private List<DatabaseConfiguration> _configurations;

        public DatabaseManagementService()
        {
            _configurations = new List<DatabaseConfiguration>();
            LoadDefaultConfigurations();
        }

        private void LoadDefaultConfigurations()
        {
            // Varsayılan konfigürasyonları yükle
            _configurations.Add(new DatabaseConfiguration
            {
                Id = 1,
                ServerName = "localhost",
                DatabaseName = "BilgeHotelDb",
                Username = "sa",
                Password = "password123",
                Port = 1433,
                Provider = DatabaseProvider.SqlServer,
                IsActive = true,
                IsDefault = true,
                Notes = "Ana veritabanı sunucusu"
            });

            _configurations.Add(new DatabaseConfiguration
            {
                Id = 2,
                ServerName = "backup-server",
                DatabaseName = "BilgeHotelDb_Backup",
                Username = "sa",
                Password = "password123",
                Port = 1433,
                Provider = DatabaseProvider.SqlServer,
                IsActive = true,
                IsDefault = false,
                Notes = "Yedek veritabanı sunucusu"
            });
        }

        public List<DatabaseConfiguration> GetAllConfigurations()
        {
            return _configurations.Where(c => c.IsActive).ToList();
        }

        public DatabaseConfiguration GetDefaultConfiguration()
        {
            return _configurations.FirstOrDefault(c => c.IsDefault && c.IsActive);
        }

        public DatabaseConfiguration GetConfigurationById(int id)
        {
            return _configurations.FirstOrDefault(c => c.Id == id && c.IsActive);
        }

        public bool TestConnection(DatabaseConfiguration config)
        {
            try
            {
                var connectionString = BuildConnectionString(config);
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    config.LastConnectionTest = DateTime.Now;
                    config.LastConnectionStatus = true;
                    return true;
                }
            }
            catch (Exception ex)
            {
                config.LastConnectionTest = DateTime.Now;
                config.LastConnectionStatus = false;
                return false;
            }
        }

        public string BuildConnectionString(DatabaseConfiguration config)
        {
            switch (config.Provider)
            {
                case DatabaseProvider.SqlServer:
                    return $"Server={config.ServerName},{config.Port};Database={config.DatabaseName};User Id={config.Username};Password={config.Password};";
                case DatabaseProvider.MySql:
                    return $"Server={config.ServerName};Port={config.Port};Database={config.DatabaseName};Uid={config.Username};Pwd={config.Password};";
                case DatabaseProvider.Access:
                    return $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={config.ServerName}\\{config.DatabaseName}.accdb;Persist Security Info=False;";
                default:
                    throw new NotSupportedException($"Database provider {config.Provider} not supported");
            }
        }

        public void AddConfiguration(DatabaseConfiguration config)
        {
            config.Id = _configurations.Any() ? _configurations.Max(c => c.Id) + 1 : 1;
            config.IsActive = true;
            _configurations.Add(config);
        }

        public void UpdateConfiguration(DatabaseConfiguration config)
        {
            var existing = _configurations.FirstOrDefault(c => c.Id == config.Id);
            if (existing != null)
            {
                existing.ServerName = config.ServerName;
                existing.DatabaseName = config.DatabaseName;
                existing.Username = config.Username;
                existing.Password = config.Password;
                existing.Port = config.Port;
                existing.Provider = config.Provider;
                existing.IsDefault = config.IsDefault;
                existing.Notes = config.Notes;
            }
        }

        public void SetDefaultConfiguration(int configId)
        {
            foreach (var config in _configurations)
            {
                config.IsDefault = config.Id == configId;
            }
        }

        public void DeleteConfiguration(int configId)
        {
            var config = _configurations.FirstOrDefault(c => c.Id == configId);
            if (config != null)
            {
                config.IsActive = false;
            }
        }
    }

    public class DatabaseBackupService
    {
        private readonly DatabaseManagementService _dbManagementService;
        private readonly string _backupDirectory;

        public DatabaseBackupService(DatabaseManagementService dbManagementService)
        {
            _dbManagementService = dbManagementService;
            _backupDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BilgeHotel", "Backups");

            if (!Directory.Exists(_backupDirectory))
            {
                Directory.CreateDirectory(_backupDirectory);
            }
        }

        public DatabaseBackup CreateBackup(DatabaseConfiguration config, BackupType backupType, int employeeId, string description = "")
        {
            try
            {
                var backupName = $"Backup_{DateTime.Now:yyyyMMdd_HHmmss}";
                var backupFileName = $"{backupName}.bak";
                var backupPath = Path.Combine(_backupDirectory, backupFileName);

                var backup = new DatabaseBackup
                {
                    BackupName = backupName,
                    BackupPath = backupPath,
                    BackupFileName = backupFileName,
                    BackupDate = DateTime.Now,
                    BackupType = backupType,
                    DatabaseProvider = config.Provider,
                    DatabaseName = config.DatabaseName,
                    CreatedByEmployeeId = employeeId,
                    Description = description,
                    IsCompressed = true
                };

                // Gerçek backup işlemi burada yapılacak
                // Şimdilik dosya oluşturuyoruz
                PerformDatabaseBackup(config, backup);

                return backup;
            }
            catch (Exception ex)
            {
                throw new Exception($"Backup creation failed: {ex.Message}");
            }
        }

        private void PerformDatabaseBackup(DatabaseConfiguration config, DatabaseBackup backup)
        {
            // Bu kısım gerçek veritabanı backup işlemi içerecek
            // Şimdilik örnek dosya oluşturuyoruz

            var connectionString = _dbManagementService.BuildConnectionString(config);

            switch (config.Provider)
            {
                case DatabaseProvider.SqlServer:
                    PerformSqlServerBackup(connectionString, backup);
                    break;
                case DatabaseProvider.Access:
                    PerformAccessBackup(config, backup);
                    break;
                default:
                    throw new NotSupportedException($"Backup not supported for {config.Provider}");
            }
        }

        private void PerformSqlServerBackup(string connectionString, DatabaseBackup backup)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    var backupCommand = $@"
                    BACKUP DATABASE [{backup.DatabaseName}]
                    TO DISK = '{backup.BackupPath}'
                    WITH FORMAT, INIT, NAME = '{backup.BackupName}', SKIP, NOREWIND, NOUNLOAD, STATS = 10";

                    using (var command = new SqlCommand(backupCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                // Dosya boyutunu al
                if (File.Exists(backup.BackupPath))
                {
                    var fileInfo = new FileInfo(backup.BackupPath);
                    backup.FileSize = fileInfo.Length;
                    backup.Checksum = CalculateChecksum(backup.BackupPath);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"SQL Server backup failed: {ex.Message}");
            }
        }

        private void PerformAccessBackup(DatabaseConfiguration config, DatabaseBackup backup)
        {
            try
            {
                var sourcePath = Path.Combine(config.ServerName, $"{config.DatabaseName}.accdb");
                var destinationPath = backup.BackupPath;

                if (File.Exists(sourcePath))
                {
                    File.Copy(sourcePath, destinationPath, true);

                    var fileInfo = new FileInfo(destinationPath);
                    backup.FileSize = fileInfo.Length;
                    backup.Checksum = CalculateChecksum(destinationPath);
                }
                else
                {
                    throw new FileNotFoundException($"Access database file not found: {sourcePath}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Access backup failed: {ex.Message}");
            }
        }

        public bool RestoreBackup(DatabaseBackup backup, DatabaseConfiguration targetConfig)
        {
            try
            {
                if (!File.Exists(backup.BackupPath))
                {
                    throw new FileNotFoundException($"Backup file not found: {backup.BackupPath}");
                }

                switch (backup.DatabaseProvider)
                {
                    case DatabaseProvider.SqlServer:
                        return RestoreSqlServerBackup(backup, targetConfig);
                    case DatabaseProvider.Access:
                        return RestoreAccessBackup(backup, targetConfig);
                    default:
                        throw new NotSupportedException($"Restore not supported for {backup.DatabaseProvider}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Restore failed: {ex.Message}");
            }
        }

        private bool RestoreSqlServerBackup(DatabaseBackup backup, DatabaseConfiguration targetConfig)
        {
            try
            {
                var connectionString = _dbManagementService.BuildConnectionString(targetConfig);

                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Önce mevcut veritabanını kapat
                    var closeCommand = $"ALTER DATABASE [{targetConfig.DatabaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE";
                    using (var command = new SqlCommand(closeCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Veritabanını geri yükle
                    var restoreCommand = $@"
                    RESTORE DATABASE [{targetConfig.DatabaseName}]
                    FROM DISK = '{backup.BackupPath}'
                    WITH REPLACE, RECOVERY";

                    using (var command = new SqlCommand(restoreCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    // Veritabanını tekrar aç
                    var openCommand = $"ALTER DATABASE [{targetConfig.DatabaseName}] SET MULTI_USER";
                    using (var command = new SqlCommand(openCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"SQL Server restore failed: {ex.Message}");
            }
        }

        private bool RestoreAccessBackup(DatabaseBackup backup, DatabaseConfiguration targetConfig)
        {
            try
            {
                var destinationPath = Path.Combine(targetConfig.ServerName, $"{targetConfig.DatabaseName}.accdb");

                // Önce mevcut dosyayı yedekle
                if (File.Exists(destinationPath))
                {
                    var backupPath = Path.Combine(_backupDirectory, $"PreRestore_{DateTime.Now:yyyyMMdd_HHmmss}_{targetConfig.DatabaseName}.accdb");
                    File.Copy(destinationPath, backupPath);
                }

                // Backup'ı geri yükle
                File.Copy(backup.BackupPath, destinationPath, true);

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"Access restore failed: {ex.Message}");
            }
        }

        public List<DatabaseBackup> GetAllBackups()
        {
            // Bu kısım veritabanından backup geçmişini getirecek
            // Şimdilik örnek veri döndürüyoruz
            return new List<DatabaseBackup>
            {
                new DatabaseBackup
                {
                    Id = 1,
                    BackupName = "Daily_Backup_20250114_090000",
                    BackupPath = Path.Combine(_backupDirectory, "Daily_Backup_20250114_090000.bak"),
                    BackupFileName = "Daily_Backup_20250114_090000.bak",
                    FileSize = 104857600, // 100MB
                    BackupDate = DateTime.Now.AddDays(-1),
                    BackupType = BackupType.Full,
                    DatabaseProvider = DatabaseProvider.SqlServer,
                    DatabaseName = "BilgeHotelDb",
                    CreatedByEmployeeId = 1,
                    Description = "Günlük otomatik yedek",
                    IsCompressed = true,
                    Checksum = "ABC123DEF456"
                }
            };
        }

        public void DeleteBackup(int backupId)
        {
            var backup = GetAllBackups().FirstOrDefault(b => b.Id == backupId);
            if (backup != null && File.Exists(backup.BackupPath))
            {
                File.Delete(backup.BackupPath);
            }
        }

        private string CalculateChecksum(string filePath)
        {
            // Basit bir checksum hesaplaması
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                using (var stream = File.OpenRead(filePath))
                {
                    var hash = sha256.ComputeHash(stream);
                    return BitConverter.ToString(hash).Replace("-", "").Substring(0, 16);
                }
            }
        }

        public long GetDirectorySize()
        {
            return Directory.Exists(_backupDirectory) ?
                new DirectoryInfo(_backupDirectory).EnumerateFiles().Sum(f => f.Length) : 0;
        }

        public void CleanupOldBackups(int keepDays = 30)
        {
            var cutoffDate = DateTime.Now.AddDays(-keepDays);

            var oldBackups = GetAllBackups()
                .Where(b => b.BackupDate < cutoffDate)
                .ToList();

            foreach (var backup in oldBackups)
            {
                DeleteBackup(backup.Id);
            }
        }
    }
}
