using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.DtoClasses
{
    public class PaymentDTO:BaseDTO
    {
        public DateTime PaymentDate { get; set; }           // Ödemenin yapıldığı tarih
        public decimal PaymentAmount { get; set; }          // Ödenen toplam tutar
        public PaymentMethod PaymentMethod { get; set; }    // Ödeme yöntemi (Kredi Kartı, Nakit, Banka Havalesi)
        public int ReservationId { get; set; }              // Ödemeye bağlı rezervasyon ID'si
        public string CardNumber { get; set; }              // Ödemenin yapıldığı kart numarası
        public decimal TotalAmount { get; set; }
        public string PaymentDetails { get; set; }
    }
}
