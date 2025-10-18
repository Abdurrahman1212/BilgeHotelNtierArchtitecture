using Models.Entities;
using System;
using System.Collections.Generic;

namespace BussinessLogicLayer.DtoClasses
{
    public class ExtraChargeDTO : BaseDTO
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public ExtraChargeType ChargeType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount => Amount * Quantity;
        public DateTime ChargeDate { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? PaidDate { get; set; }
        public int CreatedByEmployeeId { get; set; }
    }

    public class CheckoutSummaryDTO : BaseDTO
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public decimal RoomTotal { get; set; }
        public decimal PackageTotal { get; set; }
        public decimal Subtotal { get; set; }
        public decimal ExtraChargesTotal { get; set; }
        public List<ExtraChargeDTO> ExtraCharges { get; set; }
        public decimal DiscountAmount { get; set; }
        public string DiscountReason { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal GrandTotal { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public bool IsPaid { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime? PaidDate { get; set; }
        public int ProcessedByEmployeeId { get; set; }
        public string Notes { get; set; }
    }

    public class DatabaseConfigurationDTO : BaseDTO
    {
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
        public DatabaseProvider Provider { get; set; }
        public string ConnectionString { get; set; }
        public bool IsActive { get; set; }
        public bool IsDefault { get; set; }
        public DateTime LastConnectionTest { get; set; }
        public bool LastConnectionStatus { get; set; }
        public string Notes { get; set; }
    }

    public class DatabaseBackupDTO : BaseDTO
    {
        public string BackupName { get; set; }
        public string BackupPath { get; set; }
        public string BackupFileName { get; set; }
        public long FileSize { get; set; }
        public DateTime BackupDate { get; set; }
        public BackupType BackupType { get; set; }
        public DatabaseProvider DatabaseProvider { get; set; }
        public string DatabaseName { get; set; }
        public int CreatedByEmployeeId { get; set; }
        public string Description { get; set; }
        public bool IsCompressed { get; set; }
        public string Checksum { get; set; }
    }
}
