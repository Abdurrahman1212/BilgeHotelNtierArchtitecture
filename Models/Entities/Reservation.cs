using Models.Abstracts;
using Models.Enums;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Reservation : BaseEntity
    {
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public PackageType PackageType { get; set; }
        public decimal TotalAmount { get; set; }

        public DataStasus status { get; set; }
        //Relational Properties
        public int RoomId { get; set; }
        public Room? Room { get; set; } // Navigation property
        public Customer? Customer { get; set; } // Navigation property
        public int CustomerId { get; set; }
        public ICollection<Payment> Payment { get; set; } // Navigation property (One-to-one relationship with Payment) 
       
        public ICollection<Expense>? Expenses { get; set; } // Navigation property (One-to-many relationship with Expense)
    }
}

