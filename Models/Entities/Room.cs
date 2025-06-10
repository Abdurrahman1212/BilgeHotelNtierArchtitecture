using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Models.Abstracts;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Room : BaseEntity
    {

        public int RoomNumber { get; set; }
        public int Floor { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int RoomCapacity { get; set; }
        public bool RoomBreakfast { get; set; }
        public decimal PricePerNight { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasMinibar { get; set; }
        public RoomType Type { get; set; }
        public PackageType PackageType { get; set; } // Enum for package type (e.g., Bed & Breakfast, Full Board, etc.)
        public bool HasAirConditioning { get; set; }
        public bool HasTV { get; set; }
        public bool HasHairDryer { get; set; }
        public bool HasWiFi { get; set; }
        public DataStasus DataStasus { get; set; }
        public ICollection<Reservation> Reservations { get; set; } // One-to-many relationship with Reservation
    }
}

