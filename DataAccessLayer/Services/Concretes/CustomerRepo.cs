using DataAccessLayer.Context;
using DataAccessLayer.Services.Abstracs;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Concretes
{
    public class CustomerRepo :ManagerRepository<Customer>,ICustomerRepo
    {
        public CustomerRepo(ProjectDatabaseContext context):base (context)
        {
            
        }

        public Task<bool> CustomerExistsAsync(string email, string identityNumber)
        {
            throw new NotImplementedException();
        }

        public Task<Customer?> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }
    }


    
}
