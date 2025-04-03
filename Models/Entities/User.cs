using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class User:IdentityUser<int>
    {
        public User()
        {
            ActivationCode = Guid.NewGuid();
        }
        public Guid? ActivationCode { get; set; }
        public string Address { get; set; }

        // Relational properties
        // 1 order -> 1 user // 1 user -> n order
        public ICollection<Reservation> Reservations { get; set; }
    }
}
