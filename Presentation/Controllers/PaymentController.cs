using BussinessLogicLayer.DtoClasses;
using BussinessLogicLayer.Services.Abstracs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Presentation.Models.Payments.ResponseModels;
using Presentation.Models.Payments.RequestModels;
using System.Security.Claims;
using Models.Enums;
namespace Presentation.Controllers
{
    public class PaymentController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly IUserService _userService;
        private readonly IExpenseService _expenseService;
        private readonly IPaymentService _paymentService;
        private readonly IRoomService _roomService;

        public PaymentController(IReservationService reservationService, IUserService userService, IExpenseService expenseService, IPaymentService paymentService, IRoomService roomService)
        {
            _reservationService = reservationService;
            _userService = userService;
            _expenseService = expenseService;   
            _paymentService = paymentService;
            _roomService = roomService;
        }
        public IActionResult Index(int? id)
            {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var room = _roomService.GetById(id.Value);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }




        [HttpGet]
        public async Task<IActionResult> CustomerReservationDetails(int customerId)
        {
            var reservations = _reservationService.GetReservationsByCustomerId(customerId);
            if (reservations == null || !reservations.Any())
            {
                return NotFound("No reservations found for the customer.");
            }

            var reservationDetails = reservations.Select(reservation => new
            {
                ReservationId = reservation.Id,
                CheckInDate = reservation.CheckInDate,
                CheckOutDate = reservation.CheckOutDate,
                RoomNumber = reservation.Room?.RoomNumber,
                TotalAmount = reservation.TotalAmount,
                Payments = _paymentService.GetAll()
                    .Where(payment => payment.ReservationId == reservation.Id)
                    .Select(payment => new
                    {
                        PaymentDate = payment.PaymentDate,
                        PaymentAmount = payment.PaymentAmount,
                        PaymentMethod = payment.PaymentMethod.ToString()
                    }).ToList()
            });

            return View(reservationDetails);
        }
        
        //public async Task<IActionResult> CompletePayment()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> CompletePayment(PaymentProcessRequestModel paymentRequest)
        {
            if (!ModelState.IsValid) return View(paymentRequest);

           
            var payment = new Payment
            {
                PaymentDate = DateTime.Now,
                PaymentAmount = paymentRequest.ShoppingPrice,
                ReservationId = paymentRequest.ReservationId,
                PaymentMethod = PaymentMethod.CreditCard 
            };

            await _paymentService.CreateAsync(payment);

            Reservation getReservation=_reservationService.GetById(paymentRequest.ReservationId);
            getReservation.TotalAmount = payment.PaymentAmount;
            await _reservationService.UpdateAsync(getReservation);

            //return RedirectToAction(nameof(CustomerReservationDetails), new { reservationId = paymentRequest.ReservationId });
            return Json(payment);
        }
    }
}
