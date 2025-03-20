using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Abstracs
{
    public interface IEmployeeRepo<T> where T : Employee
    {
        Task<IEnumerable<T>> GetAllEmployees();
        Task<T> GetEmployeeById(int id);
        Task<T> CreateEmployee(T employee);
        Task<T> UpdateEmployee(T employee);
        Task<T> DeleteEmployee(int id);
    }
}
