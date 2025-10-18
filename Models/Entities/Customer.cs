﻿﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Models.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Customer : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerIdentityNumber { get; set; }
        public string CustomerPaymentDetails { get; set; }
        public DateTime? FirstVisitDate { get; set; }
        public DateTime? LastVisitDate { get; set; }
        public int TotalVisits { get; set; }
        public int TotalNightsStayed { get; set; }
        public decimal TotalSpent { get; set; }
        public bool IsVIPCustomer { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
        public ICollection<CustomerVisit> VisitHistory { get; set; }
    }
}
