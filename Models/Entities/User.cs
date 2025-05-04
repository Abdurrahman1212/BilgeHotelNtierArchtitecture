using Microsoft.AspNetCore.Identity;
using Models.Abstracts;
using Models.Enums;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class User:IdentityUser<int>,IEntity
    {
        public User()
        {
            ActivationCode = new Guid();
        }
        public Guid? ActivationCode { get; set; }
        public string Address { get; set; }
        public int MasterId { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime EntryDate { get ; set ; }
        public DateTime UpdatedDate { get ; set ; }
        public DataStasus SelectedStatus { get ; set ; }
        public string UpdatedComputerName { get ; set ; }

        // Relational properties
        // 1 order -> 1 user // 1 user -> n order

    }
}
