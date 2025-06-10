using BusinessLogicLayer.Services;
using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Contracts.Interfaces;
using DataAccessLayer.Services.Abstracs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Services.Concretes
{
    public class CustomerService: ManagerService<Customer>, ICustomerService
    {
        private readonly ICustomerRepo _customerRepo;
        public CustomerService(ICustomerRepo customerRepo,IManagerRepository<Customer> repository) : base(repository)
        {
            _customerRepo = customerRepo;
        }
        public async Task<bool> CustomerExistsAsync(string email, string identityNumber)
        {
            return await _customerRepo.CustomerExistsAsync(email, identityNumber);
        }
        public async Task<Customer?> GetByEmailAsync(string email)
        {
            return await _customerRepo.GetByEmailAsync(email);
        }
    }   
   
}
