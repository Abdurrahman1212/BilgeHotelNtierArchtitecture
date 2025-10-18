using Models.Abstracts;
using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;

namespace Models.Entities
{
    public class RoomPricing : BaseEntity
    {
        public int RoomId { get; set; }
        public Room? Room { get; set; }

        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }

        // Fiyatlar
        public decimal BasePricePerNight { get; set; } // Tam pansiyon gecelik fiyat
        public decimal AllInclusivePricePerNight { get; set; } // Herşey dahil gecelik fiyat

        // Sezon bilgisi
        public SeasonType SeasonType { get; set; }
        public string Notes { get; set; }
    }

    public class EarlyBookingDiscount : BaseEntity
    {
        public PackageType PackageType { get; set; }
        public int DaysInAdvance { get; set; } // Kaç gün önceden rezervasyon
        public decimal DiscountPercentage { get; set; }

        public DateTime EffectiveFrom { get; set; }
        public DateTime EffectiveTo { get; set; }
        public bool IsActive { get; set; }
    }

    public class DailyGuestReport : BaseEntity
    {
        public DateTime ReportDate { get; set; }
        public string XmlContent { get; set; }
        public bool SentToGovernment { get; set; }
        public DateTime? SentDate { get; set; }

        // Rapor istatistikleri
        public int TotalGuests { get; set; }
        public int TurkishGuests { get; set; }
        public int ForeignGuests { get; set; }
    }

    public enum SeasonType
    {
        Low = 1,        // Düşük sezon
        Mid = 2,        // Orta sezon
        High = 3,       // Yüksek sezon
        Peak = 4        // Zirve sezon
    }
}
