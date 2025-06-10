using DataAccessLayer.Context;
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
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly DbSet<Employee> _dbset;
        private readonly ProjectDatabaseContext _context;

        public EmployeeRepo(ProjectDatabaseContext context)
        {
            _context = context;
            _dbset = _context.Set<Employee>();
        }

        public async Task<decimal> CalculateManagerMonthlySalaryAsync(int managerId, int year, int month)
        {
            var manager = await _context.Employees.FindAsync(managerId);
            if (manager == null) return 0;

            // Assuming managers have a fixed monthly wage stored in HourlyWage as monthly wage
            // If managers are paid hourly, you may need to sum their shifts like regular employees
            // Here, we assume managers are paid a fixed monthly wage
            return manager.MonthlyWage;
        }

        public async Task<decimal> CalculateMonthlySalaryAsync(int employeeId, int year, int month)
        {
            var employee = await _context.Employees.FindAsync(employeeId);
            if (employee == null) return 0;

            var shifts = await _context.Shifts
                .Where(s => s.EmployeeId == employeeId &&
                            s.ShiftDate.Year == year &&
                            s.ShiftDate.Month == month)
                .ToListAsync();

            decimal totalHours = 0;
            foreach (var shift in shifts)
            {
                totalHours += (decimal)(shift.EndTime - shift.StartTime).TotalHours;
            }

            return totalHours * employee.HourlyWage;
        }

        public IEnumerable<Employee> GetAllEmployeesAsync()
        {
            return _dbset;
        }

        public async Task<Employee> GetEmployeeByEmailAsync(string email)
        {
            return await _context.Employees
                .Include(e => e.Shifts)
                .FirstOrDefaultAsync(e => e.Email == email);
        }

        public async Task<Employee> GetEmployeeByIdAsync(int employeeId)
        {
            return await _context.Employees.FindAsync(employeeId);
        }

        public async Task<ICollection<Employee>> GetEmployeesByCityAsync(string city)
        {
            return await _context.Employees
                .Where(e => e.City == city)
                .ToListAsync();
        }

        public async Task<ICollection<Employee>> GetEmployeesByPositionAsync(string position)
        {
            return await _context.Employees
                .Where(e => e.Position == position)
                .ToListAsync();
        }

        public async Task<ICollection<Employee>> GetEmployeesByStatusAsync(DataStasus status)
        {
            return await _context.Employees
                .Where(e => e.Status == status)
                .ToListAsync();
        }

        public async Task<ICollection<Employee>> GetEmployeesOffByDateAsync(DateTime date)
        {
            var employeesWithShifts = await _context.Shifts
                .Where(s => s.ShiftDate.Date == date.Date)
                .Select(s => s.EmployeeId)
                .Distinct()
                .ToListAsync();

            var employeesOff = await _context.Employees
                .Where(e => !employeesWithShifts.Contains(e.Id))
                .ToListAsync();

            return employeesOff;
        }

        public async Task<ICollection<Employee>> GetEmployeesWithOvertimeAsync()
        {
            return await _context.Employees
                .Include(e => e.Shifts)
                .Where(e => e.Shifts.Any(s => (s.EndTime - s.StartTime).TotalHours > 8))
                .ToListAsync();
        }

        public async Task<ICollection<Employee>> GetEmployeesWithShiftsByDateAsync(DateTime date)
        {
            var employees = await _context.Employees
                .Include(e => e.Shifts.Where(s => s.ShiftDate.Date == date.Date))
                .Where(e => e.Shifts.Any(s => s.ShiftDate.Date == date.Date))
                .ToListAsync();

            return employees;
        }

        public async Task<Employee> GetEmployeeWithShiftsAsync(int employeeId)
        {
            return await _context.Employees
                .Include(e => e.Shifts)
                .FirstOrDefaultAsync(e => e.Id == employeeId);
        }

        public async Task<ICollection<Shift>> GetOvertimeShiftsByEmployeeIdAsync(int employeeId)
        {
            // Fetch all shifts for the employee from the database
            var shifts = await _context.Shifts
                .Where(s => s.EmployeeId == employeeId)
                .ToListAsync();

            // Filter overtime shifts in memory (shifts longer than 8 hours)
            var overtimeShifts = shifts
                .Where(s => (s.EndTime - s.StartTime).TotalHours > 8)
                .ToList();

            return overtimeShifts;
        }

        public async Task<ICollection<Shift>> GetShiftsByEmployeeIdAsync(int employeeId)
        {
            return await _context.Shifts
                .Where(s => s.EmployeeId == employeeId)
                .ToListAsync();
        }

        public async Task UpdateManagerInfoAsync(Employee employee)
        {
            var originalEntity = await _dbset.FirstOrDefaultAsync(x => x.Id == employee.Id);
            if (originalEntity != null)
            {
                // Update audit fields
                originalEntity.UpdatedDate = DateTime.Now;
                originalEntity.UpdatedComputerName = Environment.MachineName;

                // Update other fields
                _context.Entry(originalEntity).CurrentValues.SetValues(employee);

                await _context.SaveChangesAsync();
            }
        }
    }
}
