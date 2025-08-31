using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Presentation.Models;
using Models.Entities;
using Models.Enums;
using System.Text;
using System.Text.Json;

namespace Presentation.Controllers
{
    [Authorize]
    public class PaymentController : Controller
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public PaymentController(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _configuration = configuration;
        }

        // GET: Payment/Index
        public IActionResult Index(int reservationId, decimal totalAmount)
        {
            var paymentViewModel = new PaymentViewModel
            {
                ReservationId = reservationId,
                TotalAmount = totalAmount,
                PaymentDate = DateTime.Now
            };

            return View(paymentViewModel);
        }

        // POST: Payment/ProcessPayment
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ProcessPayment(PaymentViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            // Kredi kartı seçilmediğinde kart bilgileri zorunlu değil
            if (model.PaymentMethod == PaymentMethod.CreditCard)
            {
                if (string.IsNullOrEmpty(model.CardNumber) || string.IsNullOrEmpty(model.CardHolderName) ||
                    model.ExpiryMonth <= 0 || model.ExpiryYear <= 0 || string.IsNullOrEmpty(model.CVV))
                {
                    ModelState.AddModelError("", "Kredi kartı seçildiğinde tüm kart bilgileri zorunludur.");
                    return View("Index", model);
                }
            }

            try
            {
                // API'ye payment bilgilerini gönder
                var paymentData = new
                {
                    ReservationId = model.ReservationId,
                    PaymentAmount = model.TotalAmount,
                    PaymentMethod = (int)model.PaymentMethod, // Enum'ı int olarak gönder
                    PaymentDate = DateTime.Now,
                    CardNumber = model.CardNumber ?? "",
                    CardHolderName = model.CardHolderName ?? "",
                    ExpiryMonth = model.ExpiryMonth,
                    ExpiryYear = model.ExpiryYear,
                    CVV = model.CVV ?? ""
                };

                var json = JsonSerializer.Serialize(paymentData);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                // API endpoint'i configuration'dan al
                var apiBaseUrl = _configuration["ApiSettings:BaseUrl"] ?? "https://localhost:7679";
                var response = await _httpClient.PostAsync($"{apiBaseUrl}/api/payment/process", content);

                if (response.IsSuccessStatusCode)
                {
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var result = JsonSerializer.Deserialize<PaymentResult>(responseContent);

                    if (result?.IsSuccess == true)
                    {
                        TempData["SuccessMessage"] = "Ödeme başarıyla tamamlandı!";
                        return RedirectToAction("Success", new { paymentId = result.PaymentId });
                    }
                    else
                    {
                        ModelState.AddModelError("", result?.ErrorMessage ?? "Ödeme işlemi başarısız oldu.");
                    }
                }
                else
                {
                    ModelState.AddModelError("", "API ile iletişim kurulamadı. Lütfen tekrar deneyin.");
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Ödeme işlemi sırasında hata oluştu: {ex.Message}");
            }

            return View("Index", model);
        }

        // GET: Payment/Success
        public IActionResult Success(int paymentId)
        {
            ViewBag.PaymentId = paymentId;
            return View();
        }

        // GET: Payment/Failed
        public IActionResult Failed(string errorMessage)
        {
            ViewBag.ErrorMessage = errorMessage;
            return View();
        }

        private int GetCurrentUserId()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim != null && int.TryParse(userIdClaim.Value, out int userId))
            {
                return userId;
            }
            return 0;
        }
    }

    public class PaymentResult
    {
        public bool IsSuccess { get; set; }
        public int PaymentId { get; set; }
        public string ErrorMessage { get; set; }
    }
}
