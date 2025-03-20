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
    public class CustomerRepo<T> : ICustomerRepo<T> where T : Customer
    {
        private readonly ProjectDatabaseContext _context;
        private readonly DbSet<T> _dbSet;
        public CustomerRepo(ProjectDatabaseContext context,DbSet<T>dbset)
        {
            _context = context;
            _dbSet = dbset;
        }   
        public async Task CreateCustomer(T customer)
        {
            _dbSet.Add(customer);   
            await  _context.SaveChangesAsync(); 
        }

        public Task DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public Task GetCustomerById(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomer(T customer)
        {
            throw new NotImplementedException();
        }
    }
}
