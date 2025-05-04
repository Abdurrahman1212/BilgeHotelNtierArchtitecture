
using Bogus.DataSets;
using BussinessLogicLayer.DependencyResolvers;
using BussinessLogicLayer.DtoClasses;
using BussinessLogicLayer.Services.Abstracs;
using BussinessLogicLayer.Services.Concretes;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Enums;
using Newtonsoft.Json;
using NuGet.Configuration;
using Presentation.Models;
using Presentation.Models.SessionService;
using Presentation.Models.ShoppingTools;
using System.Diagnostics;
using System.Security.Claims;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRoomService _roomService;
        private readonly IReservationService _reservationService;
        private readonly ProjectDatabaseContext _context;
        private readonly IUserService _userService;
        public HomeController(ILogger<HomeController> logger, IRoomService roomService, IReservationService reservationService, ProjectDatabaseContext context, IUserService userService)
        {
            _logger = logger;
            _roomService = roomService;
            _reservationService = reservationService;
            _context = context;
             _userService = userService;
        }

        public IActionResult Index()
        {

            return View();
        }

        public IActionResult About()
        {

            return View();
        }
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

     
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CheckInDate,CheckOutDate,PackageType,TotalAmount,PaymentVerification,status,RoomId,CustomerId,Id,MasterId,CreatedDate,EntryDate,UpdatedDate,SelectedStatus,UpdatedComputerName")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            // Validate if CustomerId exists
            if (!_context.Customers.Any(c => c.Id == reservation.CustomerId))
            {
                ModelState.AddModelError("CustomerId", "The selected customer does not exist.");
                ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "City", reservation.CustomerId);
                ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Description", reservation.RoomId);
                return View(reservation);
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
        [ValidateAntiForgeryToken]
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

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult CheckInForms()
        {
            return View();
        }
        public IActionResult Rooms(int id)
        {
            var rooms = _roomService.GetById(id).ToString().ToList();

            return View(rooms);

        }
        public IActionResult Reservasyonlarým()
        {


            //var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            //var userReservations = _reservationService.GetReservationsByCustomerId(userId);
            return View();

        }
        [HttpGet]
        public async Task<IActionResult> AllReservations()
        {

            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var userReservations = _reservationService.GetReservationsByCustomerId(userId).OrderBy(x=>x.Id);

            if (userId == null)
                return Json(new { data = NotFound(), message = "Error while retrieving data." });

            return Json(new { data = userReservations });
        }
        public async Task<IActionResult> DeleteReservations(int? id)
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
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCOnfirmReservations(int id)
        {
            var reservation = await _context.Reservations.FindAsync(id);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> EditReservations(int? id)
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
        public async Task<IActionResult> EditReservations(int id, [Bind("CheckInDate,CheckOutDate,PackageType,TotalAmount,PaymentVerification,status,RoomId,CustomerId,Id,MasterId,CreatedDate,EntryDate,UpdatedDate,SelectedStatus,UpdatedComputerName")] Reservation reservation)
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



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Authorize(Roles = "Admin,Member,Employee")]
        public IActionResult UserDetails()
        {

          

            return View();
        }
        [HttpGet]
        
        public async Task<IActionResult> AllUsers()
        {

            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
            var userReservations = _userService.GetUsersById(userId);

            if (userId == null)
                return Json(new { data = NotFound(), message = "Error while retrieving data." });

            return Json(new { data = userReservations });

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUserDetails(int id, [Bind("Id,UserName,Email,Address,UpdatedDate")] UserDTO userDto)
        {
            if (id != userDto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _context.Users.FindAsync(id);
                    if (user == null)
                    {
                        return NotFound();
                    }

                    user.UserName = userDto.UserName;
                    user.Email = userDto.Email;
                    user.Address = userDto.Address;
                    user.UpdatedDate = DateTime.Now;

                    _context.Update(user);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Users.Any(u => u.Id == userDto.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(UserDetails));
            }
            return View(userDto);
        }



        [HttpPost, ActionName("DeleteUserDetails")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteUserDetailsConfirmed(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> CheckRoomAvailability(int roomId)
        {
            var reservations = await _context.Reservations
                .Where(r => r.RoomId == roomId)
                .Select(r => new
                {
                    r.CheckInDate,
                    r.CheckOutDate
                })
                .ToListAsync();

            var availability = reservations.Select(r => new
            {
                StartDate = r.CheckInDate.ToString("yyyy-MM-dd"),
                EndDate = r.CheckOutDate.ToString("yyyy-MM-dd"),
                Status = "Occupied" // Mark as occupied for the given date range
            });

            return Json(new { data = availability });
        }

        public IActionResult CheckAvailability(int roomId,DateTime checkInDate, DateTime checkOutDate)
        {
            var isAvailable = !_reservationService.IsRoomReserved(roomId, checkInDate, checkOutDate);
            return Json(new { isAvailable });
        }
        public bool IsRoomReserved(int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            return _context.Reservations.Any(r =>
                r.RoomId == roomId &&
                r.CheckOutDate > checkInDate &&
                r.CheckInDate < checkOutDate);
        }
        // GET: Home/ReserveRoom
      
    
   

    
    }

 
}
