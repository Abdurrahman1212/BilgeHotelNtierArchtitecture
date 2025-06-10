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
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using BussinessLogicLayer.Services.Concretes;
using Microsoft.AspNetCore.Authorization;

namespace Presentation.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize(Roles = "Admin")]

    public class ShiftsController : Controller
    {
        private readonly ProjectDatabaseContext _context;
        private readonly IShiftService _shiftService;
        public ShiftsController(ProjectDatabaseContext context,IShiftService Shiftservice)
        {
            _context = context;
            _shiftService = Shiftservice;
        }

        // GET: Dashboard/Shifts
        public  IActionResult Index()
        {
            return View(_shiftService.GetAll().ToList());
        }

        [HttpGet]
        public async Task<IActionResult> AllShifts()
        {
            var allShifts = _shiftService.GetAll();

            if (allShifts == null)
                return Json(new { data = NotFound(), message = "Error while retrieving data." });

            return  Json(new { data = allShifts });
        }
        // GET: Dashboard/Shifts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shift = await _context.Shifts
                .Include(s => s.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shift == null)
            {
                return NotFound();
            }

            return View(shift);
        }

        // GET: Dashboard/Shifts/Create
        public IActionResult Create()
        {
            ViewData["Id"] = new SelectList(_context.Employees, "Id", "City");
            return View();
        }

        // POST: Dashboard/Shifts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ShiftType,StartTime,EndTime,EmployeeId,Id,MasterId,CreatedDate,EntryDate,UpdatedDate,SelectedStatus,UpdatedComputerName")] Shift shift)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shift);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Id"] = new SelectList(_context.Employees, "Id", "City", shift.Id);
            return View(shift);
        }

        // GET: Dashboard/Shifts/Edit/5
        public async Task<IActionResult> Edit(int? id)
            {
            if (id == null)
            {
                return NotFound();
            }

            var shift = await _context.Shifts.FindAsync(id);
            if (shift == null)
            {
                return NotFound();
            }
            ViewData["Id"] = new SelectList(_context.Employees, "Id", "City", shift.Id);
            return View(shift);
        }

        // POST: Dashboard/Shifts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ShiftType,StartTime,EndTime,EmployeeId,Id,MasterId,CreatedDate,EntryDate,UpdatedDate,SelectedStatus,UpdatedComputerName")] Shift shift)
        {
            if (id != shift.Id)
            {
                return NotFound();
            }
            @ModelState.Remove("Employee");
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shift);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShiftExists(shift.Id))
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
            ViewData["Id"] = new SelectList(_context.Employees, "Id", "City", shift.Id);
            return View(shift);
        }

        // GET: Dashboard/Shifts/Delete/5


        // GET: Dashboard/Users/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shift = await _context.Shifts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shift == null)
            {
                return NotFound();
            }

            return View(shift);
        }

        // POST: Dashboard/Users/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shift = await _context.Shifts.FindAsync(id);
            if (shift != null)
            {
                _context.Shifts.Remove(shift);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

      

        private bool ShiftExists(int id)
        {
            return _context.Shifts.Any(e => e.Id == id);
        }
    }
}
