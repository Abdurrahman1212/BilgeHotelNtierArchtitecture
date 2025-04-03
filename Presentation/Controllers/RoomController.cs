using BussinessLogicLayer.Services.Abstracs;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;

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
          var rooms = GetRooms(null).Result;


            return View(rooms);
        }

        public IActionResult RoomDetail(int? id)
        {
            if (id==null)
            {
                id = 1;
            }
            var rooms = GetRooms(id).Result;
            
            return View(rooms.FirstOrDefault());
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
    }
}
