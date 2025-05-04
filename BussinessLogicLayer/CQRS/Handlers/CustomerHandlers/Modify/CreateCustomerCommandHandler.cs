using DataAccessLayer.Contracts.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessLogicLayer.CQRS.Commands.CustomerCommands;

namespace BussinessLogicLayer.CQRS.Handlers.CustomerHandlers.Modify
{
    public class CreateCustomerCommandHandler
    {
        IManagerRepository<Customer> _customerRepo;
        public CreateCustomerCommandHandler(IManagerRepository<Customer> customerRepo)
        {
            _customerRepo = customerRepo;
        }
        public async Task Handle(CreateCustomerCommand createCustomer)
        {
            await _customerRepo.CreateAsync(new Customer
            {
                FirstName = createCustomer.FirstName,
                LastName = createCustomer.LastName,

            });
        }
    }
}
