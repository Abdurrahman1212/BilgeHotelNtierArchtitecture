using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Abstracts;
using Models.Enums;

namespace Models.Entities
{
    public class Expense:BaseEntity
    {
        public string ExpenseName { get; set; }
        public decimal ExpenseAmount { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string ExpenseDescription { get; set; }

        // Navigation property
        public int ReservationId { get; set; } // Foreign Key to Reservation
        public Reservation Reservation { get; set; } // Navigation property (One-to-many relationship with Reservation)
    }
}

