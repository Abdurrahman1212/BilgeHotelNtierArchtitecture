using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Presentation.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize(Roles = "Admin")]

    public class ReservationsController : Controller
    {
        private readonly ProjectDatabaseContext _context;
        private readonly IReservationService _reservationService;

        public ReservationsController(ProjectDatabaseContext context, IReservationService reservation)
        {
            _context = context;
            _reservationService = reservation;
        }

        // GET: Dashboard/Reservations
        public IActionResult Index()
        {


            return View(_reservationService.GetAll().ToList());
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



        [HttpGet]
        public async Task<IActionResult> AllReservation()
        {
            var allReservations = _reservationService.GetAll();

            if (allReservations == null)
                return Json(new { data = NotFound(), message = "Error while retrieving data." });

            return Json(new { data = allReservations });
        }

        // GET: Dashboard/Reservations/Details/5

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Dashboard/Reservations/Create
        public IActionResult Create()
        {
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "City");
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Description");
            return View();
        }

        // POST: Dashboard/Reservations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CheckInDate,CheckOutDate,PackageType,TotalAmount,PaymentVerification,status,RoomId,CustomerId,Id,MasterId,CreatedDate,EntryDate,UpdatedDate,SelectedStatus,UpdatedComputerName")] Reservation reservation)
        {
            //ModelState.Remove("Payment");
            if (ModelState.IsValid)
            {
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "City", reservation.CustomerId);
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Description", reservation.RoomId);
            return View(reservation);
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
        // GET: Dashboard/Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations
                .Include(r => r.Customer)
                .Include(r => r.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Dashboard/Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.Id == id);
        }
    }
}
