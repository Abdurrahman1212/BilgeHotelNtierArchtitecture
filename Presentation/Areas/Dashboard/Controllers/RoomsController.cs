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
using BussinessLogicLayer.Services.Concretes;
using Bogus;
using Microsoft.SqlServer.Server;
using Microsoft.AspNetCore.Authorization;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
    
namespace Presentation.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize(Roles = "Admin")]

    public class RoomsController : Controller
    {
        private readonly ProjectDatabaseContext _context;
        private readonly IRoomService _roomService;

        public RoomsController(ProjectDatabaseContext context, IRoomService roomService)
        {
            _context = context;
            _roomService = roomService;
        }

        // GET: Dashboard/Rooms
        public IActionResult Index()
        {

            return View(_roomService.GetAll().ToList());
        }


        [HttpGet]
        public async Task<IActionResult> AllRooms()
        {
            var allRooms = _roomService.GetAll();

            if (allRooms == null)
                return Json(new { data = NotFound(), message = "Error while retrieving data." });

            return Json(new { data = allRooms });
        }
        public IActionResult RoomCount()
        {
            var roomCount = _context.Rooms.Count();
            ViewBag.RoomCount = roomCount;
            return View();
        }
        // GET: Dashboard/Rooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // GET: Dashboard/Rooms/Create
        public IActionResult Create
            ()
        {
            return View();
        }

        // POST: Dashboard/Rooms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Room room)
        {
            if (ModelState.IsValid)
            {
                _context.Add(room);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(room);
        }

        // GET: Dashboard/Rooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms.FindAsync(id);
            if (room == null)
            {
                return NotFound();
            }
            return View(room);
        }

        // POST: Dashboard/Rooms/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomNumber,Floor,Description,ImageUrl,RoomCapacity,RoomBreakfast,PricePerNight,HasBalcony,HasMinibar,Reservations,Type,PackageType,HasAirConditioning,HasTV,HasHairDryer,HasWiFi,DataStasus,Id,MasterId,CreatedDate,EntryDate,UpdatedDate,SelectedStatus,UpdatedComputerName")] Room updatedRoom)
        {
            if (id != updatedRoom.Id)
            {
                return NotFound();
            }

            // Remove Reservations from ModelState if present  
            ModelState.Remove("Reservations");

            if (ModelState.IsValid)
            {
                try
                {
                    // Use RoomService to update the room (which uses RoomRepo internally)  
                    var originalRoom = _roomService.GetById(id);
                    if (originalRoom == null)
                    {
                        return NotFound();
                    }
                    await _roomService.UptadeRoom(originalRoom, updatedRoom);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(updatedRoom.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(updatedRoom);
        }

        // GET: Dashboard/Rooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var room = await _context.Rooms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (room == null)
            {
                return NotFound();
            }

            return View(room);
        }

        // POST: Dashboard/Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var room = await _context.Rooms.FindAsync(id);
            if (room != null)
            {
                _context.Rooms.Remove(room);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool RoomExists(int id)
        {
            return _context.Rooms.Any(e => e.Id == id);
        }
        // This method allows a manager to update all properties of a room using RoomService and RoomRepo.
        // It loads the room, populates ViewBag with its properties, and allows updating all fields.
        [HttpGet]
        public async Task<IActionResult> ManageRoom(int? id)
        {
            if (id == null)
                return NotFound();

            var room = _roomService.GetById(id.Value);
            if (room == null)
                return NotFound();

            // Populate ViewBag with all room properties for the view
            ViewBag.RoomNumber = room.RoomNumber;
            ViewBag.Floor = room.Floor;
            ViewBag.Description = room.Description;
            ViewBag.ImageUrl = room.ImageUrl;
            ViewBag.RoomCapacity = room.RoomCapacity;
            ViewBag.RoomBreakfast = room.RoomBreakfast;
            ViewBag.PricePerNight = room.PricePerNight;
            ViewBag.HasBalcony = room.HasBalcony;
            ViewBag.HasMinibar = room.HasMinibar;
            ViewBag.RoomType = room.Type;
            ViewBag.PackageType = room.PackageType;
            ViewBag.HasAirConditioning = room.HasAirConditioning;
            ViewBag.HasTV = room.HasTV;
            ViewBag.HasHairDryer = room.HasHairDryer;
            ViewBag.HasWiFi = room.HasWiFi;
            ViewBag.DataStasus = room.DataStasus;

            return View(room);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ManageRoom(int id, Room updatedRoom)
        {
            if (id != updatedRoom.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    // Use RoomService to update the room (which uses RoomRepo internally)
                    await _roomService.UpdateAsync(updatedRoom);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Rooms.Any(e => e.Id == updatedRoom.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction("Index");
            }

            // Repopulate ViewBag if model state is invalid
            ViewBag.RoomNumber = updatedRoom.RoomNumber;
            ViewBag.Floor = updatedRoom.Floor;
            ViewBag.Description = updatedRoom.Description;
            ViewBag.ImageUrl = updatedRoom.ImageUrl;
            ViewBag.RoomCapacity = updatedRoom.RoomCapacity;
            ViewBag.RoomBreakfast = updatedRoom.RoomBreakfast;
            ViewBag.PricePerNight = updatedRoom.PricePerNight;
            ViewBag.HasBalcony = updatedRoom.HasBalcony;
            ViewBag.HasMinibar = updatedRoom.HasMinibar;
            ViewBag.RoomType = updatedRoom.Type;
            ViewBag.PackageType = updatedRoom.PackageType;
            ViewBag.HasAirConditioning = updatedRoom.HasAirConditioning;
            ViewBag.HasTV = updatedRoom.HasTV;
            ViewBag.HasHairDryer = updatedRoom.HasHairDryer;
            ViewBag.HasWiFi = updatedRoom.HasWiFi;
            ViewBag.DataStasus = updatedRoom.DataStasus;

            return View(updatedRoom);
        }
        // Boş odaları ve özelliklerini listele
        public IActionResult AvailableRooms(DateTime? checkIn, DateTime? checkOut)
        {
            if (!checkIn.HasValue || !checkOut.HasValue)
                return Json(new { data = new List<Room>(), message = "Check-in and check-out dates are required." });

            var rooms = _roomService.GetAvailableRooms(checkIn.Value, checkOut.Value);
            return Json(new { data = rooms });
        }

        // Oda durum takibi ve hatırlatma
        public IActionResult RoomReminders()
        {
            var reminders = _roomService.GetRoomReminders();
            return View(reminders);
        }

        // Fiyat hesaplama
        public decimal CalculatePrice(int roomId, string packageType, int days)
        {
            var room = _roomService.GetById(roomId);
            decimal basePrice = room.PricePerNight * days;
            decimal packageMultiplier = packageType == "Herşey Dahil" ? 1.5m : 1.2m;
            return basePrice * packageMultiplier;
        }
    }
}
