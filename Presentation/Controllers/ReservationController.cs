using BussinessLogicLayer.Services.Abstracs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Presentation.Models;
using System.Security.Claims;
using Models.Enums;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace Presentation.Controllers
{
    [Authorize] // Kullanıcının giriş yapmış olmasını zorunlu kılar
    public class ReservationController : Controller
    {
        private readonly IReservationService _reservationService;
        private readonly IRoomService _roomService;
        
        public ReservationController(IReservationService reservationService, IRoomService roomService)
        {
            _reservationService = reservationService;
            _roomService = roomService;
        }
        
        // GET: ReservationController
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Room");
            }

            var room = _roomService.GetById(id.Value);
            if (room == null)
            {
                return NotFound();
            }

            // Mevcut kullanıcının ID'sini al
            var currentUserId = GetCurrentUserId();
            if (currentUserId == 0)
            {
                return RedirectToAction("Login", "Account");
            }

            var viewModel = new ReservationViewModel
            {
                RoomId = room.Id,
                RoomNumber = room.RoomNumber.ToString(),
                RoomDescription = room.Description,
                PricePerNight = room.PricePerNight,
                RoomCapacity = room.RoomCapacity,
                RoomType = room.Type.ToString(),
                Floor = room.Floor,
                ImageUrl = room.ImageUrl,
                RoomBreakfast = room.RoomBreakfast,
                PackageType = room.PackageType.ToString(),
                RoomStatus = room.Status.ToString(),
                HasWiFi = room.HasWiFi,
                HasTV = room.HasTV,
                HasBalcony = room.HasBalcony,
                HasMinibar = room.HasMinibar,
                HasAirConditioner = room.HasAirConditioning,
                HasHairDryer = room.HasHairDryer,
                CustomerId = currentUserId, // Otomatik olarak mevcut kullanıcının ID'sini ata
                CheckInDate = DateTime.Today,
                CheckOutDate = DateTime.Today.AddDays(1)
            };

            return View(viewModel);
        }

        // Mevcut kullanıcının ID'sini al
        private int GetCurrentUserId()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);
            if (userIdClaim != null && int.TryParse(userIdClaim.Value, out int userId))
            {
                return userId;
            }
            return 0;
        }

        private decimal CalculateTotalAmount(DateTime checkInDate, DateTime checkOutDate, decimal pricePerNight)
        {
            var days = (checkOutDate - checkInDate).Days;
            if (days <= 0) days = 1; // En az 1 gün
            return days * pricePerNight;
        }

        // GET: ReservationController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ReservationController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ReservationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ReservationViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                // Hata durumunda aynı oda bilgileriyle view'ı tekrar göster
                var room = _roomService.GetById(viewModel.RoomId);
                if (room != null)
                {
                    viewModel.RoomNumber = room.RoomNumber.ToString();
                    viewModel.RoomDescription = room.Description;
                    viewModel.PricePerNight = room.PricePerNight;
                    viewModel.RoomCapacity = room.RoomCapacity;
                    viewModel.RoomType = room.Type.ToString();
                    viewModel.Floor = room.Floor;
                    viewModel.ImageUrl = room.ImageUrl;
                    viewModel.RoomBreakfast = room.RoomBreakfast;
                    viewModel.PackageType = room.PackageType.ToString();
                    viewModel.RoomStatus = room.Status.ToString();
                    viewModel.HasWiFi = room.HasWiFi;
                    viewModel.HasTV = room.HasTV;
                    viewModel.HasBalcony = room.HasBalcony;
                    viewModel.HasMinibar = room.HasMinibar;
                    viewModel.HasAirConditioner = room.HasAirConditioning;
                    viewModel.HasHairDryer = room.HasHairDryer;
                    viewModel.CustomerId = GetCurrentUserId();
                }
                return View("Index", viewModel);
            }

            try
            {
                var reservation = new Reservation
                {
                    RoomId = viewModel.RoomId,
                    CheckInDate = viewModel.CheckInDate,
                    CheckOutDate = viewModel.CheckOutDate,
                    CustomerId = viewModel.CustomerId,
                    CreatedDate = DateTime.Now,
                    status = DataStasus.Active,
                };

                await _reservationService.CreateAsync(reservation);
                
                // Rezervasyon oluşturulduktan sonra payment sayfasına yönlendir
                var totalAmount = CalculateTotalAmount(viewModel.CheckInDate, viewModel.CheckOutDate, viewModel.PricePerNight);
                
                TempData["SuccessMessage"] = "Rezervasyonunuz oluşturuldu! Şimdi ödeme yapabilirsiniz.";
                return RedirectToAction("Index", "Payment", new { 
                    reservationId = reservation.Id, 
                    totalAmount = totalAmount 
                });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Rezervasyon oluşturulurken bir hata oluştu: " + ex.Message);
                
                // Hata durumunda aynı oda bilgileriyle view'ı tekrar göster
                var room = _roomService.GetById(viewModel.RoomId);
                if (room != null)
                {
                    viewModel.RoomNumber = room.RoomNumber.ToString();
                    viewModel.RoomDescription = room.Description;
                    viewModel.PricePerNight = room.PricePerNight;
                    viewModel.RoomCapacity = room.RoomCapacity;
                    viewModel.RoomType = room.Type.ToString();
                    viewModel.Floor = room.Floor;
                    viewModel.ImageUrl = room.ImageUrl;
                    viewModel.RoomBreakfast = room.RoomBreakfast;
                    viewModel.PackageType = room.PackageType.ToString();
                    viewModel.RoomStatus = room.Status.ToString();
                    viewModel.HasWiFi = room.HasWiFi;
                    viewModel.HasTV = room.HasTV;
                    viewModel.HasBalcony = room.HasBalcony;
                    viewModel.HasMinibar = room.HasMinibar;
                    viewModel.HasAirConditioner = room.HasAirConditioning;
                    viewModel.HasHairDryer = room.HasHairDryer;
                    viewModel.CustomerId = GetCurrentUserId();
                }
                return View("Index", viewModel);
            }
        }

        // GET: ReservationController/Edit/5
        public ActionResult Edit(int id)
        {
            try
            {
                // Mevcut kullanıcının ID'sini al
                var currentUserId = GetCurrentUserId();
                if (currentUserId == 0)
                {
                    return RedirectToAction("Login", "Account");
                }

                // Rezervasyonu getir
                var reservation = _reservationService.GetById(id);
                if (reservation == null)
                {
                    return NotFound();
                }

                // Kullanıcının sadece kendi rezervasyonunu düzenleyebilmesini sağla
                if (reservation.CustomerId != currentUserId)
                {
                    return Forbid();
                }

                return View(reservation);
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "Rezervasyon bilgileri alınırken hata oluştu: " + ex.Message;
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: ReservationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, Reservation model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }

                // Mevcut kullanıcının ID'sini al
                var currentUserId = GetCurrentUserId();
                if (currentUserId == 0)
                {
                    return RedirectToAction("Login", "Account");
                }

                // Rezervasyonu getir
                var existingReservation = _reservationService.GetById(id);
                if (existingReservation == null)
                {
                    return NotFound();
                }

                // Kullanıcının sadece kendi rezervasyonunu düzenleyebilmesini sağla
                if (existingReservation.CustomerId != currentUserId)
                {
                    return Forbid();
                }

                // Güncellenecek alanları güncelle
                existingReservation.CheckInDate = model.CheckInDate;
                existingReservation.CheckOutDate = model.CheckOutDate;
                existingReservation.PackageType = model.PackageType;
                existingReservation.TotalAmount = model.TotalAmount;
                existingReservation.ReservationStatus = model.ReservationStatus;
                existingReservation.PaymentMethod = model.PaymentMethod;
                existingReservation.UpdatedDate = DateTime.Now;
                existingReservation.UpdatedComputerName = Environment.MachineName;

                // Rezervasyonu güncelle
                await _reservationService.UpdateAsync(existingReservation);

                TempData["SuccessMessage"] = "Rezervasyonunuz başarıyla güncellendi!";
                return RedirectToAction("Reservasyonlarım", "Home");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Rezervasyon güncellenirken hata oluştu: " + ex.Message);
                return View(model);
            }
        }

        // GET: ReservationController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ReservationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
