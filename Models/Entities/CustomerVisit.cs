using Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Enums;
namespace Models.Entities
{
    public class CustomerVisit : BaseEntity
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int NightsStayed { get; set; }
        public decimal TotalAmount { get; set; }
        public PackageType PackageType { get; set; }
        public string RoomNumbers { get; set; } // Virgülle ayrılmış oda numaraları

        // Ziyaret detayları
        public int NumberOfGuests { get; set; }
        public bool HadComplaints { get; set; }
        public string VisitNotes { get; set; }
        public VisitRating Rating { get; set; }
    }

    public enum VisitRating
    {
        Poor = 1,
        Fair = 2,
        Good = 3,
        VeryGood = 4,
        Excellent = 5
    }
}
