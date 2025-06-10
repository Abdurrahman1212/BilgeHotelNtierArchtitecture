using DataAccessLayer.Contracts.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Abstracs
{
    public interface ICustomerRepo : IManagerRepository<Customer>
    {
        /// <summary>
        /// Checks if a customer with the given email or identity number already exists.
        /// </summary>
        /// <param name="email">Customer email address.</param>
        /// <param name="identityNumber">Customer identity number.</param>
        /// <returns>True if customer exists, otherwise false.</returns>
        Task<bool> CustomerExistsAsync(string email, string identityNumber);

        /// <summary>
        /// Gets a customer by email.
        /// </summary>
        /// <param name="email">Customer email address.</param>
        /// <returns>Customer entity if found, otherwise null.</returns>
        Task<Customer?> GetByEmailAsync(string email);
    }
}
