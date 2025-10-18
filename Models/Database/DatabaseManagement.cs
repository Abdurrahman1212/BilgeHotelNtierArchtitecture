using Models.Abstracts;
using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public class DatabaseConfiguration : BaseEntity
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Port { get; set; } = 1433; // SQL Server default port
        public DatabaseProvider Provider { get; set; }
        public string ConnectionString { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public DateTime LastConnectionTest { get; set; }
        public bool LastConnectionStatus { get; set; }
        public string Notes { get; set; }
    }

    public class DatabaseBackup : BaseEntity
    {
        public string BackupName { get; set; }
        public string BackupPath { get; set; }
        public string BackupFileName { get; set; }
        public long FileSize { get; set; } // bytes
        public DateTime BackupDate { get; set; }
        public BackupType BackupType { get; set; }
        public DatabaseProvider DatabaseProvider { get; set; }
        public string DatabaseName { get; set; }
        public int CreatedByEmployeeId { get; set; }
        public Employee CreatedByEmployee { get; set; }
        public string Description { get; set; }
        public bool IsCompressed { get; set; }
        public string Checksum { get; set; }
    }

    public enum DatabaseProvider
    {
        SqlServer = 1,
        MySql = 2,
        PostgreSql = 3,
        Oracle = 4,
        Access = 5
    }

    public enum BackupType
    {
        Full = 1,
        Differential = 2,
        TransactionLog = 3,
        SchemaOnly = 4
    }
}
