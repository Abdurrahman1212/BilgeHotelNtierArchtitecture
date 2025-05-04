using BussinessLogicLayer.DtoClasses;

namespace Presentation.Models.Payments.ResponseModels
{
    public class PaymentSummaryDto
    {
        public ReservationDTO ReservationDetails { get; set; }
        public PaymentDTO PaymentDetails { get; set; }
    }
}
