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
using Models.Enums;

namespace Presentation.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize(Roles = "Admin")]

    public class EmployeesController : Controller
    {
        private readonly ProjectDatabaseContext _context;
        private readonly IEmployeeService _employeeService;
        private readonly IManagerService<Employee> _managerService;

        public EmployeesController(ProjectDatabaseContext context, IEmployeeService employee, IManagerService<Employee> managerService)
        {
            _context = context;
            _employeeService = employee;
            _managerService = managerService;
        }

        // GET: Dashboard/Employees
        public IActionResult Index()
        {
            return View(_employeeService.GetAllEmployeesAsync());
        }

        [HttpGet]
        public async Task<IActionResult> AllEmployees()
        {
            var allEmployees = _employeeService.GetAllEmployeesAsync().ToList();

            if (allEmployees == null)
                return Json(new { data = NotFound(), message = "Error while retrieving data." });

            return Json(new { data = allEmployees });
        }
        // GET: Dashboard/Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Dashboard/Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dashboard/Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeFirstName,EmployeeLastName,EmployeePhoneNumber,Email,Position,EmployeeAddres,City,Country,PostalCode,ShiftStart,ShiftEnd,WeeklyOfDate,HasOverTime,WeeklyWorkedHours,TotalWorkedHours,HourlyWage,MonthlyWage,Status,Id,MasterId,CreatedDate,EntryDate,UpdatedDate,SelectedStatus,UpdatedComputerName")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Dashboard/Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Dashboard/Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeFirstName,EmployeeLastName,EmployeePhoneNumber,Email,Position,EmployeeAddres,City,Country,PostalCode,ShiftStart,ShiftEnd,WeeklyOfDate,HasOverTime,WeeklyWorkedHours,TotalWorkedHours,HourlyWage,MonthlyWage,Status,Id,MasterId,CreatedDate,EntryDate,UpdatedDate,SelectedStatus,UpdatedComputerName")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            // Set HasOverTime based on WeeklyWorkedHours
            employee.HasOverTime = employee.WeeklyWorkedHours > 48;
            ModelState.Remove("Shifts");
            // ModelState validation
            if (ModelState.IsValid)
            {
                try
                {
                    // Update the employee in the database
                    await _employeeService.UpdateManagerEmployeeInfo(employee);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
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

            // Repopulate dropdowns in case of error
            ViewBag.Positions = new SelectList(new List<string> { "Manager", "Staff", "Intern" }, employee.Position);
            ViewBag.Cities = new SelectList(new List<string> { "New York", "London", "Istanbul" }, employee.City);
            ViewBag.Countries = new SelectList(new List<string> { "USA", "UK", "Turkey" }, employee.Country);
            ViewBag.Statuses = new SelectList(Enum.GetValues(typeof(DataStasus)).Cast<DataStasus>(), employee.Status);
            ViewBag.WeeklyWorkedHours = new SelectList(Enumerable.Range(0, 81), employee.WeeklyWorkedHours);
            ViewBag.SelectedStatus = new SelectList(Enum.GetValues(typeof(DataStasus)).Cast<DataStasus>(), employee.SelectedStatus);
            ViewBag.ShiftTypes = new SelectList(new List<string> { "Morning", "Evening", "Night" }, employee.WeeklyOfDate);
            ViewBag.HourlyWage = employee.HourlyWage;
            return View(employee);
        }

        // GET: Dashboard/Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Dashboard/Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
