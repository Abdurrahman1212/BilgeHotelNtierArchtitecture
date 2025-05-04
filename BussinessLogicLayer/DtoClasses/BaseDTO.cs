using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.DtoClasses
{
    public class BaseDTO
    {
        public int Id { get; set; }
        public int MasterId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DataStasus SelectedStatus { get; set; }
        public string UpdatedComputerName { get; set; }
    }
}
