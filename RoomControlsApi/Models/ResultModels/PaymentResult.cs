namespace RoomControlsApi.Models.ResultModels
{
    public class PaymentResult
    {
        public bool IsSuccess { get; set; }
        public int PaymentId { get; set; }
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
