using Bogus;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.FakeData
{
    public class EmployeeFakeData
    {
        public static List<Employee> Employees()
        {
            var faker = new Faker();
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                var CreatedDate = faker.Date.Between(DateTime.Now, DateTime.Now.AddYears(1));  // Ensure the date is valid
                var UpdatedDate = faker.Date.Between(CreatedDate.AddDays(1), CreatedDate.AddYears(1));  // Ensure a valid range for CheckOut

                employees.Add(new Employee
                {
                    Id = i + 1,
                    EmployeeFirstName = faker.Name.FirstName(),
                    EmployeeLastName = faker.Name.LastName(),
                    Email = faker.Internet.Email(),
                    EmployeePhoneNumber = faker.Phone.PhoneNumber(),
                    EmployeeAddres = faker.Address.FullAddress(),
                    City = faker.Address.City(),
                    Country = faker.Address.Country(),
                    PostalCode = faker.Address.ZipCode(),
                    CreatedDate = CreatedDate,
                    UpdatedDate = UpdatedDate,
                    Shifts = new List<Shift>() // Initialize the required Shifts property
                });
            }
            return employees;
        }
    }
}
