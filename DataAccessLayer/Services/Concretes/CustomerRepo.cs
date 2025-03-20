using DataAccessLayer.Services.Abstracs;
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
        public Task CreateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task CreateRangeAsync(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAllAsync(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DestroyAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DestroyRangeAsync(List<T> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetActives()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetPassives()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(List<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
