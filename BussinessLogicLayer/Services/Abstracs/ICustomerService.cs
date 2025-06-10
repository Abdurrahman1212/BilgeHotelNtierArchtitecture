using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Services.Abstracs
{
    public interface ICustomerService: IManagerService<Customer>
    {
        Task<bool> CustomerExistsAsync(string email, string identityNumber);

        Task<Customer?> GetByEmailAsync(string email);
    }
}
