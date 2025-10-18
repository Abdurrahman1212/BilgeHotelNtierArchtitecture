using Models.Abstracts;
using Models.Entities;
using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public class ExtraCharge : BaseEntity
    {
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public ExtraChargeType ChargeType { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount => Amount * Quantity;

        public DateTime ChargeDate { get; set; }
        public bool IsPaid { get; set; }
        public DateTime? PaidDate { get; set; }

        // Personel bilgisi
        public int CreatedByEmployeeId { get; set; }
        public Employee CreatedByEmployee { get; set; }
    }

    public class CheckoutSummary : BaseEntity
    {
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Ana ücretler
        public decimal RoomTotal { get; set; }
        public decimal PackageTotal { get; set; }
        public decimal Subtotal => RoomTotal + PackageTotal;

        // Ekstra harcamalar
        public decimal ExtraChargesTotal { get; set; }
        public List<ExtraCharge> ExtraCharges { get; set; }

        // İndirimler
        public decimal DiscountAmount { get; set; }
        public string DiscountReason { get; set; }

        // Vergiler
        public decimal TaxAmount { get; set; }
        public decimal TaxRate { get; set; }

        // Toplamlar
        public decimal GrandTotal => Subtotal + ExtraChargesTotal + TaxAmount - DiscountAmount;

        // Ödeme bilgileri
        public PaymentMethod PaymentMethod { get; set; }
        public bool IsPaid { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime? PaidDate { get; set; }

        // Personel bilgisi
        public int ProcessedByEmployeeId { get; set; }
        public Employee ProcessedByEmployee { get; set; }

        public string Notes { get; set; }
    }

    public enum ExtraChargeType
    {
        Minibar = 1,
        RoomService = 2,
        Laundry = 3,
        SpaService = 4,
        Restaurant = 5,
        Phone = 6,
        Internet = 7,
        Parking = 8,
        Other = 9
    }

    public enum PaymentMethod
    {
        Cash = 1,
        CreditCard = 2,
        DebitCard = 3,
        BankTransfer = 4,
        MobilePayment = 5
    }
}
