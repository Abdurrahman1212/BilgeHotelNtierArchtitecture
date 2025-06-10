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
    public class CustomerRepo : ManagerRepository<Customer>,ICustomerRepo
    {
        private readonly ProjectDatabaseContext _context;
        public CustomerRepo(ProjectDatabaseContext context):base (context)
        {
            _context = context;
        }

        public async Task<bool> CustomerExistsAsync(string email, string identityNumber)
        {
            return await _context.Customers
                .AnyAsync(c => c.Email == email || c.CustomerIdentityNumber == identityNumber);
        }

        public async Task<Customer?> GetByEmailAsync(string email)
        {
            return await _context.Customers
                .FirstOrDefaultAsync(c => c.Email == email);
        }
    }
}
