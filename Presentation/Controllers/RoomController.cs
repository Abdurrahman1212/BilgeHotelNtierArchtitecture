using BussinessLogicLayer.Services.Abstracs;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Enums;

namespace Presentation.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomService _roomService;
        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
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
                return RedirectToAction("Index", "Room"); // Redirect to the room list if no ID is provided
            }

            var room =  _roomService.GetById(id.Value);
            if (room == null)
            {
                return NotFound(); // Return a 404 page if the room is not found
            }

            return View(room);
        }



        public async Task <List<Room>> GetRooms(int? id)
        {
            
            var room = new List<Room>();
            if (id==null)
            {
                room = _roomService.GetAll().ToList();

            }
            else
            {
                room.Add(_roomService.GetById((int)id)); 

            }
            
            return room;
        }
        [HttpPost]
        public async Task<IActionResult> CreateReservation(Reservation reservation)
        {
            if (!ModelState.IsValid)
            {
                // Log validation errors
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage); // Log the error messages
                }

                TempData["ErrorMessage"] = "Rezervasyon oluşturulurken bir hata oluştu.";
                return RedirectToAction("RoomDetail");
            }

            reservation.CreatedDate = DateTime.Now;
            reservation.status = DataStasus.Reserved;
            
            await _roomService.CreateReservationAsync(reservation);
            TempData["SuccessMessage"] = "Rezervasyonunuz başarıyla oluşturuldu!";
            return RedirectToAction("RoomDetail");
        }
    }
}
