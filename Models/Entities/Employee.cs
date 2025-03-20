using Models.Abstracts;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Employee:BaseEntity
    {

        public  string EmployeeFirstName  { get; set; }
        public  string EmployeeLastName { get; set; }
        public  string EmployeePhoneNumber { get; set; }
        public  string Email { get; set; }
        public  string EmployeeAddres { get; set; }
        public  string City { get; set; }
        public  string Country { get; set; }
        public  string PostalCode { get; set; }

        public decimal HourlyWage { get; set; }

        public DataStasus Status { get; set; }
        //Relational Properties

        public  ICollection<Shift>  Shifts { get; set; }

    }
}
