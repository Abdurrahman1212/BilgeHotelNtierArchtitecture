using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Enums;
using System.Text.Json;
using System.Text;
using RoomControlsApi.Models.ResponseModels;
using RoomControlsApi.Models.RequestModels;
using RoomControlsApi.Models.ResultModels;

namespace RoomControlsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PaymentController : ControllerBase
    {
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(ILogger<PaymentController> logger)
        {
            _logger = logger;
        }

        // POST: api/payment/process
        [HttpPost("process")]
        public async Task<IActionResult> ProcessPayment([FromBody] PaymentRequestModel request)
        {
            try
            {
                _logger.LogInformation("Payment request received for Reservation ID: {ReservationId}", request.ReservationId);

                // Payment validation
                if (!ValidatePaymentRequest(request))
                {
                    return BadRequest(new PaymentResponseModel
                    {
                        IsSuccess = false,
                        ErrorMessage = "Geçersiz ödeme bilgileri"
                    });
                }

                // Simulate payment processing
                var paymentResult = await ProcessPaymentAsync(request);

                if (paymentResult.IsSuccess)
                {
                    _logger.LogInformation("Payment processed successfully for Reservation ID: {ReservationId}", request.ReservationId);
                    
                    return Ok(new PaymentResponseModel
                    {
                        IsSuccess = true,
                        PaymentId = paymentResult.PaymentId,
                        Message = "Ödeme başarıyla tamamlandı"
                    });
                }
                else
                {
                    _logger.LogWarning("Payment failed for Reservation ID: {ReservationId}. Error: {Error}", 
                        request.ReservationId, paymentResult.ErrorMessage);
                    
                    return BadRequest(new PaymentResponseModel
                    {
                        IsSuccess = false,
                        ErrorMessage = paymentResult.ErrorMessage
                    });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error processing payment for Reservation ID: {ReservationId}", request.ReservationId);
                
                return StatusCode(500, new PaymentResponseModel
                {
                    IsSuccess = false,
                    ErrorMessage = "Ödeme işlemi sırasında bir hata oluştu"
                });
            }
        }

        // GET: api/payment/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPayment(int id)
        {
            try
            {
                // Simulate getting payment from database
                var payment = await GetPaymentByIdAsync(id);
                
                if (payment == null)
                {
                    return NotFound();
                }

                return Ok(payment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting payment with ID: {PaymentId}", id);
                return StatusCode(500, "Ödeme bilgileri alınırken hata oluştu");
            }
        }

        // GET: api/payment/reservation/{reservationId}
        [HttpGet("reservation/{reservationId}")]
        public async Task<IActionResult> GetPaymentByReservation(int reservationId)
        {
            try
            {
                // Simulate getting payment by reservation ID
                var payment = await GetPaymentByReservationIdAsync(reservationId);
                
                if (payment == null)
                {
                    return NotFound();
                }

                return Ok(payment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error getting payment for Reservation ID: {ReservationId}", reservationId);
                return StatusCode(500, "Rezervasyon ödeme bilgileri alınırken hata oluştu");
            }
        }

        private bool ValidatePaymentRequest(PaymentRequestModel request)
        {
            if (request == null) return false;
            if (request.ReservationId <= 0) return false;
            if (request.PaymentAmount <= 0) return false;
            if (string.IsNullOrWhiteSpace(request.CardNumber)) return false;
            if (string.IsNullOrWhiteSpace(request.CardHolderName)) return false;
            if (request.ExpiryMonth < 1 || request.ExpiryMonth > 12) return false;
            if (request.ExpiryYear < DateTime.Now.Year) return false;
            if (string.IsNullOrWhiteSpace(request.CVV)) return false;

            return true;
        }

        private async Task<PaymentResult> ProcessPaymentAsync(PaymentRequestModel request)
        {
            // Simulate async payment processing
            await Task.Delay(1000);

            // Simulate payment success/failure based on card number
            if (request.CardNumber.EndsWith("0000"))
            {
                return new PaymentResult
                {
                    IsSuccess = false,
                    ErrorMessage = "Kart limiti yetersiz"
                };
            }

            // Generate random payment ID
            var random = new Random();
            var paymentId = random.Next(10000, 99999);

            return new PaymentResult
            {
                IsSuccess = true,
                PaymentId = paymentId
            };
        }

        private async Task<PaymentResponseModel> GetPaymentByIdAsync(int id)
        {
            // Simulate async database query
            await Task.Delay(100);
            
            // Return mock payment data
            return new PaymentResponseModel
            {
                IsSuccess = true,
                PaymentId = id,
                Message = "Ödeme bulundu"
            };
        }

        private async Task<PaymentResponseModel> GetPaymentByReservationIdAsync(int reservationId)
        {
            // Simulate async database query
            await Task.Delay(100);
            
            // Return mock payment data
            return new PaymentResponseModel
            {
                IsSuccess = true,
                PaymentId = 12345,
                Message = "Rezervasyon ödemesi bulundu"
            };
        }
    }

   

   
    
}
