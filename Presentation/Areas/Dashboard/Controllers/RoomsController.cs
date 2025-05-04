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
        public async Task<IActionResult> Edit(int id, [Bind("RoomNumber,Floor,Description,ImageUrl,RoomCapacity,RoomBreakfast,PricePerNight,HasBalcony,HasMinibar,RoomType,HasAirConditioning,HasTV,HasHairDryer,HasWiFi,DataStasus,Id,MasterId,CreatedDate,EntryDate,UpdatedDate,SelectedStatus,UpdatedComputerName")] Room room)
        {
            if (id != room.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(room);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomExists(room.Id))
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
            return View(room);
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
    }
}
