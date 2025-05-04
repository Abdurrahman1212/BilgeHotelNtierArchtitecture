using DataAccessLayer.Contracts.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.CQRS.Commands.CustomerCommands
{
    public class CreateCustomerCommand
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
