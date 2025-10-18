﻿﻿﻿using Models.Abstracts;
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
        public EmployeePosition Position { get; set; }
        public  string EmployeeAddres { get; set; }
        public  string City { get; set; }
        public  string Country { get; set; }
        public  string PostalCode { get; set; }
        public DateTime ShiftStart { get; set; }
        public DateTime ShiftEnd { get; set; }
        public string ? WeeklyOfDate { get; set; }
        public bool HasOverTime { get; set; }
        public int  WeeklyWorkedHours { get; set; }
        public int TotalWorkedHours { get; set; }

        public decimal HourlyWage { get; set; }
        public decimal MonthlyWage { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public StandardShift StandardShift { get; set; }
        public decimal OvertimeRate { get; set; }
        public int MinWeeklyHours { get; set; }
        public int MaxWeeklyHours { get; set; }
        public int RequiredShiftsPerWeek { get; set; }
        public int OvertimeHours { get; set; }
        public bool HasOvertime { get; set; }
        public DateTime? OffDay { get; set; }

        public DataStasus Status { get; set; }
        //Relational Properties

        public  ICollection<Shift>  Shifts { get; set; }

    }
}
