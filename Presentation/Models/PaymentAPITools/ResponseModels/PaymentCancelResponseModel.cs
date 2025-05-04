namespace Presentation.Models.Payments.ResponseModels
{
    public class PaymentCancelResponseModel
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
