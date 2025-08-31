using DataAccessLayer.Contracts.Interfaces;
using Models.Entities;
using Models.Enums;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Abstracs
{
    public interface IEmployeeRepo : IManagerRepository<Employee>
    {
        // Gets all employees  
        IEnumerable<Employee> GetAllEmployeesAsync();

        // Gets all shifts for a specific employee  
        Task<ICollection<Shift>> GetShiftsByEmployeeIdAsync(int employeeId);

        // Get Employees By Email  
        Task<Employee> GetEmployeeByEmailAsync(string email);

        // Gets detailed employee info including shifts  
        Task<Employee> GetEmployeeWithShiftsAsync(int employeeId);

        // Get Employees With Overtime  
        Task<ICollection<Employee>> GetEmployeesWithOvertimeAsync();

        // Get Employees By City  
        Task<ICollection<Employee>> GetEmployeesByCityAsync(string city);

        // Get Employees By Status  
        Task<ICollection<Employee>> GetEmployeesByStatusAsync(DataStasus status);

        // Get Employees By Position  
        Task<ICollection<Employee>> GetEmployeesByPositionAsync(string position);

        // Gets employee by id  
        Task<Employee> GetEmployeeByIdAsync(int employeeId);

        // Gets all employees with their shifts for a specific date  
        Task<ICollection<Employee>> GetEmployeesWithShiftsByDateAsync(DateTime date);

        // Gets all employees who are off on a specific date  
        Task<ICollection<Employee>> GetEmployeesOffByDateAsync(DateTime date);

        // Gets overtime shifts for a specific employee  
        Task<ICollection<Shift>> GetOvertimeShiftsByEmployeeIdAsync(int employeeId);

        // Calculates the total salary for an employee for a given month and year based on their hourly wage and worked shifts  
        Task<decimal> CalculateMonthlySalaryAsync(int employeeId, int year, int month);

        // Calculates the total monthly salary for a manager (monthly wage)  
        Task<decimal> CalculateManagerMonthlySalaryAsync(int managerId, int year, int month);

        // Updates the manager's information. Only accessible by managers.  
        Task UpdateManagerInfoAsync(Employee originalEmployee, Employee newEmployee);  
        }  

     
    
}
