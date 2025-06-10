using DataAccessLayer.Services.Concretes;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using Microsoft.EntityFrameworkCore.InMemory; // Add this using directive for InMemoryDatabase support
using System.Threading.Tasks;
using Bogus;
using Microsoft.IdentityModel.Tokens;
using Models.Enums;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Setup in-memory database
            var options = new DbContextOptionsBuilder<ProjectDatabaseContext>()
                .UseInMemoryDatabase(databaseName: "TestDb")
                .Options;

            using var context = new ProjectDatabaseContext(options);

            // Add a test employee
            var employee = new Employee
            {
                Id = 1,
                EmployeeFirstName = "John",
                EmployeeLastName = "Doe",
                Position = "Manager",
                EmployeePhoneNumber = "1234567890",
                Email = "0",
                EmployeeAddres = "123 Main St",
                City = "Anytown",
                Country = "USA",
                PostalCode = "12345",
                ShiftStart = DateTime.Now.AddHours(-8),
                ShiftEnd = DateTime.Now.AddHours(8),
                WeeklyOfDate = "Monday",
                HasOverTime = false,
                WeeklyWorkedHours = 40,
                TotalWorkedHours = 160,
                HourlyWage = 20.00m,
                MonthlyWage = 3200.00m,
                Status = DataStasus.Active,
                UpdatedDate = DateTime.MinValue,
                UpdatedComputerName = ""
            };
            context.Employees.Add(employee);
            await context.SaveChangesAsync();

            // Request employee id from user
            Console.Write("Enter employee id to update: ");
            if (!int.TryParse(Console.ReadLine(), out int empId))
            {
                Console.WriteLine("Invalid id.");
                return;
            }

            // Fetch employee by id
            var empToUpdate = await context.Employees.FirstOrDefaultAsync(e => e.Id == empId);
            if (empToUpdate == null)
            {
                Console.WriteLine("Employee not found.");
                return;
            }

            // Display current employee data
            Console.WriteLine($"Current Data: {empToUpdate.EmployeeFirstName} {empToUpdate.EmployeeLastName}, Position: {empToUpdate.Position}");

            // Request new data from user
            Console.Write("Enter new first name: ");
            empToUpdate.EmployeeFirstName = Console.ReadLine();

            Console.Write("Enter new last name: ");
            empToUpdate.EmployeeLastName = Console.ReadLine();

            Console.Write("Enter new position: ");
            empToUpdate.Position = Console.ReadLine();

            // You can add more fields as needed

            // Update employee
            await UpdateManagerInfoAsync(context, empToUpdate);

            // Fetch and print updated employee
            var result = await context.Employees.FirstOrDefaultAsync(e => e.Id == empId);
            if (result != null)
            {
                Console.WriteLine($"Id: {result.Id}, Name: {result.EmployeeFirstName} {result.EmployeeLastName}, Position: {result.Position}, UpdatedDate: {result.UpdatedDate}, UpdatedComputerName: {result.UpdatedComputerName}");
            }
        }

        public static async Task UpdateManagerInfoAsync(ProjectDatabaseContext context, Employee employee)
        {
            employee.UpdatedDate = DateTime.Now;
            employee.UpdatedComputerName = Environment.MachineName;

            var originalEntity = await context.Employees.FirstOrDefaultAsync(x => x.Id == employee.Id);

            if (originalEntity != null)
            {
                context.Entry(originalEntity).CurrentValues.SetValues(employee);
                await context.SaveChangesAsync();
            }
        }
    }
}

//public static async Task UpdateManagerInfoAsync(ProjectDatabaseContext context, Employee employee)
//        {
//            employee.UpdatedDate = DateTime.Now;
//            employee.UpdatedComputerName = Environment.MachineName;

//            var originalEntity = await context.Employees.FirstOrDefaultAsync(x => x.Id == employee.Id);

//            if (originalEntity != null)
//            {
//                context.Entry(originalEntity).CurrentValues.SetValues(employee);
//                await context.SaveChangesAsync();
//            }
//        }
//    }
//}
