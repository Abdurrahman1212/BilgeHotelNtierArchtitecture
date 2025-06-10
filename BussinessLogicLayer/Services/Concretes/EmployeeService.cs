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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo _employeeRepo;
        public EmployeeService(IEmployeeRepo employeeRepo) 
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<decimal> CalculateMonthlyWageAsync(int employeeId)
        {
            return await _employeeRepo.CalculateMonthlySalaryAsync(employeeId, DateTime.Now.Year, DateTime.Now.Month);
        }

        public IEnumerable<Employee> GetAllEmployeesAsync()
        {
           return _employeeRepo.GetAllEmployeesAsync();
           
        }

        public async Task<Employee> GetEmployeeByEmailAsync(string email)
        {
            return await _employeeRepo.GetEmployeeByEmailAsync(email);
                }

        public async Task<IEnumerable<Employee>> GetEmployeesByCityAsync(string city)
        {
            return await _employeeRepo.GetEmployeesByCityAsync(city);
                

        }

        public async Task<IEnumerable<Employee>> GetEmployeesByPositionAsync(string position)
        {
            return await _employeeRepo.GetEmployeesByPositionAsync(position);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesByStatusAsync(DataStasus status)
        {
            return await _employeeRepo.GetEmployeesByStatusAsync(status); 
        }

        public async Task<IEnumerable<Shift>> GetEmployeeShiftsAsync(int employeeId)
        {
            return await _employeeRepo.GetShiftsByEmployeeIdAsync(employeeId);
        }

        public async Task<IEnumerable<Employee>> GetEmployeesWithOvertimeAsync()
        {
            return await _employeeRepo.GetEmployeesWithOvertimeAsync();
        }

        public async Task UpdateManagerEmployeeInfo(Employee employee)
        {
            await _employeeRepo.UpdateManagerInfoAsync(employee); // Assuming UpdateAsync is implemented in IEmployeeRepo
        }
    }
}
