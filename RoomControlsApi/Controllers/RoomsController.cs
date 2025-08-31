using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Enums;
using RoomControlsApi.Models.RequestModels;
using RoomControlsApi.Models.Entities;

namespace RoomControlsApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly ProjectDatabaseContext _context;
        private readonly IdRequest _ıdRequest;
        private readonly RoomsControl _roomsControl1;

        public RoomsController(ProjectDatabaseContext context,IdRequest ıdRequest,RoomsControl roomsControl)
        {
            _context = context;
            _ıdRequest = ıdRequest;
            _roomsControl1= roomsControl;
        }

        // To help diagnose the cause of the 500 error, add logging and exception handling to your controller methods.
        // Example for GetRooms:


        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoomById(int id)
        {
            try
            {
                var room = await _context.Rooms.FindAsync(id);
                if (room == null) return NotFound();
                return Ok(room);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "An error occurred while retrieving the room.");
            }
        }

        [HttpPost]
        public async Task<IActionResult>UpdateRoom(RoomsControl roomsControl)
        {
            if (roomsControl == null || roomsControl.Id <= 0)
            {

                return BadRequest("Invalid room data.");
            }
            else
            {
            
            }
                return Ok();
        }


























        //[HttpPost]
        //public async Task<IActionResult> StartTransaction(PaymentRequestModel item)
        //{
        //    if(_db.CardInfoes.Any(x => x.CardNumber == item.CardNumber && x.CVC == item.CVC && x.CardUserName == item.CardUserName)) //Kart bilgileri tutuyorsa(Aslında burada daha ayrıntılı bir kontrol yapılır)
        //    {
        //        UserCardInfo? uCInfo = await _db.CardInfoes.SingleOrDefaultAsync(x => x.CardNumber == item.CardNumber && x.CVC == item.CVC && x.CardUserName == item.CardUserName);
        //        #region TarihKontrolleri
        //        //if(uCInfo.ExpiryYear > DateTime.Now.Year)
        //        //{

        //        //}
        //        //else if(uCInfo.ExpiryYear == DateTime.Now.Year)
        //        //{
        //        //    if(uCInfo.ExpiryMonth > DateTime.Now.Month)
        //        //    {

        //        //    }
        //        //}
        //        //else
        //        //{
        //        //    return Ok("Kartınızın tarihi gecersiz");
        //        //} 
        //        #endregion

        //        if (uCInfo.Balance >= item.ShoppingPrice)
        //        {
        //            #region UOW

        //            //Unit Of Works
        //            //Öncelikle kullanicinin balance'i düsürülür
        //            //Komisyon alınır
        //            //satıcıya net miktar gönderilir
        //            //Ondan sonra kaydedilir 
        //            #endregion
        //            uCInfo.Balance -= item.ShoppingPrice; //Fiyat, kartın balance'inden düsüyor
        //            await _db.SaveChangesAsync();

        //            return Ok("Odeme basarıyla alındı");
        //        }
        //        else return StatusCode(400, "Kart bakiyesi yetersiz bulundu");
        //    }

        //    return StatusCode(400, "Kart bulunamadı");
        //}










        [HttpPost("get-by-id")]
        public async Task<ActionResult<Room>> GetRoomById([FromBody] IdRequest request)
        {
            try
            {
                var room = await _context.Rooms.FindAsync(request.Id);
                if (room == null) return NotFound();
                return Ok(room);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return StatusCode(500, "An error occurred while retrieving the room.");
            }
        }
    }




}
