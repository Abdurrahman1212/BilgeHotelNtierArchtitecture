using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.DtoClasses
{
    public class ShiftDTO :BaseDTO
    {
        public ShiftType ShiftType { get; set; }
        public DateTime StartTime { get; set; } // Vardiya başlangıç saati
        public DateTime EndTime { get; set; } // Vardiya bitiş saati
    }
}
