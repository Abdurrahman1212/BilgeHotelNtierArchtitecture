using BilgeoHotel.Models;
using Bogus;
using BusinessLogicLayer.Services;
using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Context;
using DataAccessLayer.Data.FakeData;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Enums;
using System.Diagnostics;

namespace BilgeoHotel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRoomService _roomservice;


        public HomeController(ILogger<HomeController> logger,IRoomService roomService)
        {
            _logger = logger;
            _roomservice = roomService;

        }

        public IActionResult Index()
        {

            return View(_roomservice.GetAll().ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Room room)
        {
            try
            {
                await _roomservice.CreateAsync(room);
                var faker = new Faker();

                TempData["Success"] = "Room Created Successfully";
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
                return View();
            }

        }
        public async Task<IActionResult> DeleteFromRooms(int id)
        {
            Room C=_roomservice.GetById(id);
            await _roomservice.DeleteAsync(C);
            return View("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
