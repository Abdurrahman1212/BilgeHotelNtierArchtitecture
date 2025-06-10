using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Enums;
using System.Drawing.Printing;
using System.Security.Claims;

namespace Presentation.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;
        private readonly IReservationService _reservationService;
        private readonly ProjectDatabaseContext _context;

        public RoomController(IRoomService roomService, IReservationService reservationService, ProjectDatabaseContext context)
        {
            _roomService = roomService;
            _reservationService = reservationService;
            _context = context;
        }

        public IActionResult Index()
        {
            var rooms = _roomService.GetAll().ToList();
            return View(rooms);
        }

        public IActionResult RoomDetail(int? id)
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

            return View(room);
        }

        public async Task<List<Room>> GetRooms(int? id)
        {
            var room = new List<Room>();
            if (id == null)
            {
                room = _roomService.GetAll().ToList();
            }
            else
            {
                var singleRoom = _roomService.GetById((int)id);
                if (singleRoom != null)
                {
                    room.Add(singleRoom);
                }
            }

            return room;
        }

        public async Task<IActionResult> NewReservation()
        {

            return PartialView("~/Views/Room/Partial/_NewReservation.cshtml");
        }

        [Authorize(Roles = "Admin,Employee,Member")]
        
        public async Task<IActionResult> CreateReservation(Reservation reservation)
        {
            // Model validasyonunu kontrol et
            ModelState.Remove("Payment");
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }

                TempData["ErrorMessage"] = "Rezervasyon oluşturulurken bir hata oluştu.";
                return RedirectToAction("RoomDetail");
            }

            // Tarih bilgilerini kullanıcıdan al
            reservation.CreatedDate = DateTime.Now;
            reservation.status = (DataStasus)RoomStatus.Reserved;

            // Kullanıcıdan CheckIn ve CheckOut tarihlerini al
            reservation.CheckInDate = reservation.CheckInDate; // Kullanıcının girdiği tarihler
            reservation.CheckOutDate = reservation.CheckOutDate; // Kullanıcının girdiği tarihler

            // Kullanıcı ID'sini dinamik olarak al
            var userId = GetCurrentUserId();
            reservation.CustomerId = userId;

            // Rezervasyonu oluştur
            await _roomService.CreateReservationAsync(reservation);

            // Başarılı mesaj göster
            TempData["SuccessMessage"] = "Rezervasyonunuz başarıyla oluşturuldu!";
            return Json(reservation);
        }

        // Kullanıcı ID'sini dinamik olarak almak için gerekli yöntem
        private int GetCurrentUserId()
        {
            // Burada, oturum açmış kullanıcının ID'sini dinamik olarak alın
            // Örneğin, kullanıcı kimliği istek bağlamından (HttpContext) alınabilir:
            return int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));
        }

        public IActionResult GetReservationDetail(int reservationId)
        {
            if (reservationId <= 0)
            {
                return BadRequest("Geçersiz rezervasyon ID'si.");
            }
            // Rezervasyonu al
            var reservation = _reservationService.GetReservation(reservationId);

            // Rezervasyon bulunamadıysa hata döndür
            if (reservation == null)
            {
                return NotFound("Rezervasyon bulunamadı veya bu rezervasyona erişim yetkiniz yok.");
            }

            // Rezervasyon detaylarını döndür
            return Json(reservation);
        }

        public async Task<IActionResult> DeleteReservation(int reservationId)
        {
            if (reservationId <= 0)
            {
                return BadRequest("Geçersiz rezervasyon ID'si.");
            }
            // Rezervasyonu al
            var reservation = _reservationService.GetReservation(reservationId);

            // Rezervasyon bulunamadıysa hata döndür
            if (reservation == null)
            {
                return NotFound("Rezervasyon bulunamadı veya bu rezervasyona erişim yetkiniz yok.");
            }
            await _reservationService.DestroyAsync(reservation);

            return Json("ok");
        }

        public async Task<IActionResult> GetRoom(int id)
        {
            if (id <= 0)
            {
                return NotFound();
            }

            var reservation = _reservationService.GetReservation(id);
            if (reservation == null)
            {
                return NotFound();
            }
            ViewData["CustomerId"] = new SelectList(_context.Customers, "Id", "City", reservation.CustomerId);
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Description", reservation.RoomId);
            return PartialView("~/Views/Room/Partial/_EditReservation.cshtml",reservation);
        }


        [HttpPost]
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

        private bool ReservationExists(int id)
        {
            return _context.Reservations.Any(e => e.Id == id);
        }
      
    }

}
