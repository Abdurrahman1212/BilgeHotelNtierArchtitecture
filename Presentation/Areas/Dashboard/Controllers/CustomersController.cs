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
using Microsoft.AspNetCore.Authorization;

namespace Presentation.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize(Roles = "Admin")]
    public class CustomersController : Controller
    {
        private readonly ProjectDatabaseContext _context;
        private readonly ICustomerService _customerService;

        public CustomersController(ProjectDatabaseContext context, ICustomerService customerService)
        {
            _customerService = customerService;
            _context = context;
        }

        // GET: Dashboard/Customers
        public IActionResult Index()
        {
            return View(_customerService.GetAll().ToList());
        }

     
        [HttpGet]
        public async Task<IActionResult> AllCustomers()
        {
            var allCustomers = _customerService.GetAll();

            if (allCustomers == null)
                return Json(new { data = NotFound(), message = "Error while retrieving data." });

            return Json(new { data = allCustomers });
        }
        // GET: Dashboard/Customers/Details/5
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Dashboard/Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dashboard/Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,LastName,Email,City,County,PostalCode,CustomerPhone,CustomerAddress,CustomerIdentityNumber,CustomerPaymentDetails,Id,MasterId,CreatedDate,EntryDate,UpdatedDate,SelectedStatus,UpdatedComputerName")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Dashboard/Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Dashboard/Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FirstName,LastName,Email,City,County,PostalCode,CustomerPhone,CustomerAddress,CustomerIdentityNumber,CustomerPaymentDetails,Id,MasterId,CreatedDate,EntryDate,UpdatedDate,SelectedStatus,UpdatedComputerName")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
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
            return View(customer);
        }

        // GET: Dashboard/Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Dashboard/Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
