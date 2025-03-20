using BussinessLogicLayer.Services.Abstracs;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Presentation.Models;
using System.Diagnostics;

namespace Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRoomService _roomService;
        public HomeController(ILogger<HomeController> logger, IRoomService roomService)
        {
            _logger = logger;
            _roomService = roomService;
        }

        public IActionResult Index()
        {
            return View(_roomService.GetAll().ToList());
        }

        public IActionResult About()
        {

            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult CheckInForms()
        {
            return View();
        }
        public  IActionResult Rooms(int id )
        {
            var rooms = _roomService.GetById(id).ToString().ToList();

            return View(rooms);
        }


       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
