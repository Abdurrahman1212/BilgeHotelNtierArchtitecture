using BusinessLogicLayer.Services;
using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Contracts.Interfaces;
using DataAccessLayer.Services.Abstracs;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Services.Concretes
{
    public class EmployeeService(IEmployeeRepo employeeRepo) : ManagerService<Employee>(employeeRepo), IEmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo = employeeRepo;

        public Task<decimal> CalculateMonthlyWageAsync(int employeeId)
        {
            // Assuming current month and year for calculation
            var now = DateTime.Now;
            return _employeeRepo.CalculateMonthlySalaryAsync(employeeId, now.Year, now.Month);
        }

        public IEnumerable<Employee> GetAllEmployeesAsync()
        {
            return _employeeRepo.GetAllEmployeesAsync();
        }

        public Task<Employee> GetEmployeeByEmailAsync(string email)
        {
            return _employeeRepo.GetEmployeeByEmailAsync(email);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByCityAsync(string city)
        {
            var result = await _employeeRepo.GetEmployeesByCityAsync(city);
            return result;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByPositionAsync(string position)
        {
            var result = await _employeeRepo.GetEmployeesByPositionAsync(position);
            return result;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByStatusAsync(DataStasus status)
        {
            var result = await _employeeRepo.GetEmployeesByStatusAsync(status);
            return result;
        }

        public async Task<IEnumerable<Shift>> GetEmployeeShiftsAsync(int employeeId)
        {
            var result = await _employeeRepo.GetShiftsByEmployeeIdAsync(employeeId);
            return result;
        }

        public async Task<IEnumerable<Employee>> GetEmployeesWithOvertimeAsync()
        {
            var result = await _employeeRepo.GetEmployeesWithOvertimeAsync();
            return result;
        }

        public async Task UpdateManagerEmployeeInfo(Employee employee)
        {
            // Fetch the original employee from the database
            var originalEmployee = await _employeeRepo.GetEmployeeByIdAsync(employee.Id);
            if (originalEmployee != null)
            {
                await _employeeRepo.UpdateManagerInfoAsync(originalEmployee, employee);
            }
        }
    }
}
