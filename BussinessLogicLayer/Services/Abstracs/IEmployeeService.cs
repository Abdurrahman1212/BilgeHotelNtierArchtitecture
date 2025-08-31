using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Services.Abstracs
{
    public interface IEmployeeService:IManagerService<Employee>
    {
        // Custom Employee-specific service methods

        //Get All Employees
        IEnumerable<Employee> GetAllEmployeesAsync();
        Task<IEnumerable<Employee>> GetEmployeesByPositionAsync(string position);
        Task<Employee> GetEmployeeByEmailAsync(string email);
        Task<IEnumerable<Employee>> GetEmployeesByCityAsync(string city);
        Task<IEnumerable<Employee>> GetEmployeesWithOvertimeAsync();
        Task<decimal> CalculateMonthlyWageAsync(int employeeId);
        Task<IEnumerable<Shift>> GetEmployeeShiftsAsync(int employeeId);
        Task<IEnumerable<Employee>> GetEmployeesByStatusAsync(DataStasus status);
        Task UpdateManagerEmployeeInfo(Employee employee);
    }
}
