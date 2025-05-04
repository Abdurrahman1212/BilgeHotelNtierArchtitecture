using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.DtoClasses
{
    public class UserDTO:BaseDTO
    {
        public string UserName { get; set; }
        //public string UserLastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DataStasus SelectedStatus { get; set; }
        public string UpdatedComputerName { get; set; }

    }
}
