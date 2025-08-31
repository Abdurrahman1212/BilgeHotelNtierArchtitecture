namespace RoomControlsApi.Models.ResponseModels
{
    public class PaymentResponseModel
    {
        public bool IsSuccess { get; set; }
        public int PaymentId { get; set; }
        public string Message { get; set; } = string.Empty;
        public string ErrorMessage { get; set; } = string.Empty;
    }

}
