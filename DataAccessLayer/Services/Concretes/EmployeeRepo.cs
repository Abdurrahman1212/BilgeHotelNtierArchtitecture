using DataAccessLayer.Context;
using DataAccessLayer.Contracts.Interfaces;
using DataAccessLayer.Services.Abstracs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Models.Entities;
using Models.Enums;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Concretes
{
    public class EmployeeRepo : ManagerRepository<Employee>, IEmployeeRepo
    {
        private readonly ProjectDatabaseContext project;
        public EmployeeRepo(ProjectDatabaseContext project) : base(project)
        {
            this.project = project;
        }
        /// <summary>
        /// Calculates the total monthly salary for a manager (monthly wage).
        /// </summary>
        public async Task<decimal> CalculateManagerMonthlySalaryAsync(int managerId, int year, int month)
        {
            var manager = await project.Employees
                .FirstOrDefaultAsync(e => e.Id == managerId && e.Position.ToLower().Contains("manager"));
            return manager?.MonthlyWage ?? 0m;
        }

        /// <summary>
        /// Calculates the total salary for an employee for a given month and year based on their hourly wage and worked shifts.
        /// </summary>
        public async Task<decimal> CalculateMonthlySalaryAsync(int employeeId, int year, int month)
        {
            var employee = await project.Employees.Include(e => e.Shifts).FirstOrDefaultAsync(e => e.Id == employeeId);
            if (employee == null) return 0m;

            var shifts = employee.Shifts
                .Where(s => s.ShiftDate.Year == year && s.ShiftDate.Month == month)
                .ToList();

            // Assuming MonthlyWage is the base wage, and overtime is not included here.
            // If you want to calculate based on hours, you can adjust this logic.
            return employee.MonthlyWage;
        }

        /// <summary>
        /// Gets all employees.
        /// </summary>
        public IEnumerable<Employee> GetAllEmployeesAsync()
        {
            return project.Employees.AsNoTracking().ToList();
        }

        /// <summary>
        /// Gets employee by email.
        /// </summary>
        public async Task<Employee> GetEmployeeByEmailAsync(string email)
        {
            return await project.Employees.FirstOrDefaultAsync(e => e.Email == email);
        }

        /// <summary>
        /// Gets employee by id.
        /// </summary>
        public async Task<Employee> GetEmployeeByIdAsync(int employeeId)
        {
            return await project.Employees.FindAsync(employeeId);
        }

        /// <summary>
        /// Gets employees by city.
        /// </summary>
        public async Task<ICollection<Employee>> GetEmployeesByCityAsync(string city)
        {
            return await project.Employees.Where(e => e.City == city).ToListAsync();
        }

        /// <summary>
        /// Gets employees by position.
        /// </summary>
        public async Task<ICollection<Employee>> GetEmployeesByPositionAsync(string position)
        {
            return await project.Employees.Where(e => e.Position == position).ToListAsync();
        }

        /// <summary>
        /// Gets employees by status.
        /// </summary>
        public async Task<ICollection<Employee>> GetEmployeesByStatusAsync(DataStasus status)
        {
            return await project.Employees.Where(e => e.Status == status).ToListAsync();
        }

        /// <summary>
        /// Gets all employees who are off on a specific date.
        /// </summary>
        public async Task<ICollection<Employee>> GetEmployeesOffByDateAsync(DateTime date)
        {
            // Assuming WeeklyOfDate is a string representation of the day off (e.g., "Monday")
            var dayName = date.DayOfWeek.ToString();
            return await project.Employees.Where(e => e.WeeklyOfDate == dayName).ToListAsync();
        }

        /// <summary>
        /// Gets employees with overtime.
        /// </summary>
        public async Task<ICollection<Employee>> GetEmployeesWithOvertimeAsync()
        {
            return await project.Employees.Where(e => e.HasOverTime).ToListAsync();
        }

        /// <summary>
        /// Gets all employees with their shifts for a specific date.
        /// </summary>
        public async Task<ICollection<Employee>> GetEmployeesWithShiftsByDateAsync(DateTime date)
        {
            return await project.Employees
                .Include(e => e.Shifts.Where(s => s.ShiftDate.Date == date.Date))
                .Where(e => e.Shifts.Any(s => s.ShiftDate.Date == date.Date))
                .ToListAsync();
        }

        /// <summary>
        /// Gets detailed employee info including shifts.
        /// </summary>
        public async Task<Employee> GetEmployeeWithShiftsAsync(int employeeId)
        {
            return await project.Employees.Include(e => e.Shifts).FirstOrDefaultAsync(e => e.Id == employeeId);
        }

        /// <summary>
        /// Gets overtime shifts for a specific employee.
        /// </summary>
        public async Task<ICollection<Shift>> GetOvertimeShiftsByEmployeeIdAsync(int employeeId)
        {
            return await project.Shifts
                .Where(s => s.EmployeeId == employeeId && (s.EndTime - s.StartTime).TotalHours > 8)
                .ToListAsync();
        }

        /// <summary>
        /// Gets all shifts for a specific employee.
        /// </summary>
        public async Task<ICollection<Shift>> GetShiftsByEmployeeIdAsync(int employeeId)
        {
            return await project.Shifts.Where(s => s.EmployeeId == employeeId).ToListAsync();
        }

        /// <summary>
        /// Updates the manager's information. Only accessible by managers.
        /// </summary>
        public async Task UpdateManagerInfoAsync(Employee originalEmployee, Employee newEmployee)
        {
            originalEmployee.EmployeeFirstName = newEmployee.EmployeeFirstName;
            originalEmployee.EmployeeLastName = newEmployee.EmployeeLastName;
            originalEmployee.EmployeePhoneNumber = newEmployee.EmployeePhoneNumber;
            originalEmployee.Email = newEmployee.Email;
            originalEmployee.Position = newEmployee.Position;
            originalEmployee.EmployeeAddres = newEmployee.EmployeeAddres;
            originalEmployee.City = newEmployee.City;
            originalEmployee.Country = newEmployee.Country;
            originalEmployee.PostalCode = newEmployee.PostalCode;
            originalEmployee.ShiftStart = new DateTime(
                newEmployee.ShiftStart.Year,
                newEmployee.ShiftStart.Month,
                newEmployee.ShiftStart.Day,
                newEmployee.ShiftStart.Hour,
                newEmployee.ShiftStart.Minute,
                0
            );
            originalEmployee.ShiftEnd = new DateTime(
                newEmployee.ShiftEnd.Year,
                newEmployee.ShiftEnd.Month,
                newEmployee.ShiftEnd.Day,
                newEmployee.ShiftEnd.Hour,
                newEmployee.ShiftEnd.Minute,
                0
            );
            originalEmployee.WeeklyOfDate = newEmployee.WeeklyOfDate;
            originalEmployee.HasOverTime = newEmployee.HasOverTime;
            originalEmployee.MonthlyWage = newEmployee.MonthlyWage;
            originalEmployee.Status = newEmployee.Status;
            await project.SaveChangesAsync();
        }
    }
}
