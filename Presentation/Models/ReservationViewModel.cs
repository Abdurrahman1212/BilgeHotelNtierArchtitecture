using System.ComponentModel.DataAnnotations;

namespace Presentation.Models
{
    public class ReservationViewModel
    {
        [Required(ErrorMessage = "Oda seçimi zorunludur")]
        public int RoomId { get; set; }

        [Required(ErrorMessage = "Giriş tarihi zorunludur")]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Required(ErrorMessage = "Çıkış tarihi zorunludur")]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        [Required(ErrorMessage = "Müşteri ID zorunludur")]
        public int CustomerId { get; set; }

        // Oda bilgileri (sadece görüntüleme için)
        public string RoomNumber { get; set; }
        public string RoomDescription { get; set; }
        public decimal PricePerNight { get; set; }
        public int RoomCapacity { get; set; }
        public string RoomType { get; set; }
        public int Floor { get; set; }
        public string ImageUrl { get; set; }
        public bool RoomBreakfast { get; set; }
        public string PackageType { get; set; }
        public string RoomStatus { get; set; }

        // Oda özellikleri
        public bool HasWiFi { get; set; }
        public bool HasTV { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasMinibar { get; set; }
        public bool HasAirConditioner { get; set; }
        public bool HasHairDryer { get; set; }
    }
}
