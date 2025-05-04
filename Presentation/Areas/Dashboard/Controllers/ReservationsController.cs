using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Context;
using Models.Entities;
using BussinessLogicLayer.Services.Abstracs;
using Microsoft.AspNetCore.Authorization;

namespace Presentation.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize(Roles = "Admin")]

    public class ReservationsController : Controller
    {
        private readonly ProjectDatabaseContext _context;
        private readonly IReservationService _reservationService;

        public ReservationsController(ProjectDatabaseContext context,IReservationService reservation)
        {
            _context = context;
            _reservationService = reservation;
        }

        // GET: Dashboard/Reservations
        public IActionResult Index()
        {
          

            return View(_reservationService.GetAll().ToList());
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

        // GET: Dashboard/Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "City", reservation.CustomerId);
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Description", reservation.RoomId);
            return View(reservation);
        }

        // POST: Dashboard/Reservations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CheckInDate,CheckOutDate,PackageType,TotalAmount,PaymentVerification,status,RoomId,CustomerId,Id,MasterId,CreatedDate,EntryDate,UpdatedDate,SelectedStatus,UpdatedComputerName")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "City", reservation.CustomerId);
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Description", reservation.RoomId);
            return View(reservation);
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
