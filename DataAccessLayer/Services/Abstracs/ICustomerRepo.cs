using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Abstracs
{
    public interface ICustomerRepo<T>where T : Customer
    {
        Task<IEnumerable<T>> GetAllCustomers();
        Task GetCustomerById(int id);
        Task CreateCustomer(T customer);
        Task UpdateCustomer(T customer);
        Task DeleteCustomer(int id);
    }
}
