using Models.Abstracts;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Shift : BaseEntity
    {

        public ShiftType ShiftType { get; set; }
        public DateTime StartTime { get; set; } // Vardiya başlangıç saati
        public DateTime EndTime { get; set; } // Vardiya bitiş saati


        // Navigation property
        public  Employee Employee { get; set; } // Vardiyanın ilişkili olduğu çalışan
        public int EmployeeId { get; set; }
        public DateTime ShiftDate { get; set; }
    }
}
