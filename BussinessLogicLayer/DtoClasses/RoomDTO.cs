using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.DtoClasses
{
    public class RoomDTO :BaseDTO
    {
        public string RoomNumber { get; set; }
        public int Floor { get; set; }
        public string Description { get; set; }
    }
}
