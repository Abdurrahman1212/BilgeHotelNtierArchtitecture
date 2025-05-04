using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Presentation.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly ProjectDatabaseContext _context;
        private readonly IRoomService _controller;
        public HomeController(ProjectDatabaseContext context,IRoomService controller)
        {
            _context = context;
            _controller = controller;
        }
      

        // GET: HomeController
        public ActionResult Index()
        {
           var roomCount = _context.Rooms.Count();
            ViewBag.RoomCount = roomCount;
            var EmployeeCount = _context.Employees.Count();
            ViewBag.EmployeeCount = EmployeeCount;
            var TotalReservations = _context.Reservations.Count();
            ViewBag.TotalReservations = TotalReservations;
            var averagePricePerNight = _context.Rooms.Average(r => r.PricePerNight);
            ViewBag.TotalRevenue = averagePricePerNight;
            
            return View();
        }
  
        // GET: HomeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
