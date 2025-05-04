using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.DtoClasses
{
    public class ReservationDTO:BaseDTO
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate   { get; set; }
        public decimal TotalPrice { get; set; }
        public PackageType PackageType { get; set; }
        public DataStasus Stasus { get; set; }
        public string? RoomNumber { get; set; }
    }
}
