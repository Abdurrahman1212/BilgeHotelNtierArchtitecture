using System.ComponentModel.DataAnnotations;
using Models.Enums;

namespace Presentation.Models
{
    public class PaymentViewModel
    {
        [Required(ErrorMessage = "Rezervasyon ID zorunludur")]
        public int ReservationId { get; set; }

        [Required(ErrorMessage = "Toplam tutar zorunludur")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Toplam tutar 0'dan büyük olmalıdır")]
        public decimal TotalAmount { get; set; }

        [Required(ErrorMessage = "Ödeme tarihi zorunludur")]
        public DateTime PaymentDate { get; set; }

        [Required(ErrorMessage = "Ödeme yöntemi seçiniz")]
        public PaymentMethod PaymentMethod { get; set; }

        // Kredi kartı bilgileri
        [Required(ErrorMessage = "Kart numarası zorunludur")]
        [StringLength(16, MinimumLength = 13, ErrorMessage = "Kart numarası 13-16 karakter olmalıdır")]
        [RegularExpression(@"^\d+$", ErrorMessage = "Kart numarası sadece rakam içermelidir")]
        public string CardNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Kart sahibi adı zorunludur")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Kart sahibi adı 2-100 karakter olmalıdır")]
        public string CardHolderName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Son kullanma ayı zorunludur")]
        [Range(1, 12, ErrorMessage = "Geçerli bir ay giriniz (1-12)")]
        public int ExpiryMonth { get; set; }

        [Required(ErrorMessage = "Son kullanma yılı zorunludur")]
        [Range(2024, 2030, ErrorMessage = "Geçerli bir yıl giriniz (2024-2030)")]
        public int ExpiryYear { get; set; }

        [Required(ErrorMessage = "CVV zorunludur")]
        [StringLength(4, MinimumLength = 3, ErrorMessage = "CVV 3-4 karakter olmalıdır")]
        [RegularExpression(@"^\d+$", ErrorMessage = "CVV sadece rakam içermelidir")]
        public string CVV { get; set; } = string.Empty;

        // Rezervasyon bilgileri (görüntüleme için)
        public string? RoomNumber { get; set; }
        public string? RoomDescription { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public int? GuestNumber { get; set; }
        public string? CustomerName { get; set; }
    }
}
