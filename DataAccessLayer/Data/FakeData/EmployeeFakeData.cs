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
        public static List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            int idCounter = 1;

            // Resepsiyon Görevlisi (Receptionist) - 7
            var receptionistFaker = new Faker<Employee>("tr")
                .RuleFor(e => e.Id, f => idCounter++)
                .RuleFor(e => e.EmployeeFirstName, f => f.Name.FirstName())
                .RuleFor(e => e.EmployeeLastName, f => f.Name.LastName())
                .RuleFor(e => e.City, f => f.Address.City())
                .RuleFor(e => e.EmployeePhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(e => e.Email, f => f.Internet.Email())
                 .RuleFor(e => e.EmployeeAddres, f => f.Address.FullAddress())
                .RuleFor(e => e.Country, f => f.Address.Country())
                 .RuleFor(e => e.PostalCode, f => f.Random.Number().ToString())
                .RuleFor(e => e.Position, f => "Resepsiyon Görevlisi");
            employees.AddRange(receptionistFaker.Generate(7));

            // Temizlik Görevlisi (Cleaner) - 11
            var cleanerFaker = new Faker<Employee>("tr")
                .RuleFor(e => e.Id, f => idCounter++)
                .RuleFor(e => e.EmployeeFirstName, f => f.Name.FirstName())
                .RuleFor(e => e.EmployeeLastName, f => f.Name.LastName())
                .RuleFor(e => e.City, f => f.Address.City())
                .RuleFor(e => e.EmployeePhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(e => e.Email, f => f.Internet.Email())
                 .RuleFor(e => e.PostalCode, f => f.Random.Number().ToString())
                 .RuleFor(e => e.EmployeeAddres, f => f.Address.FullAddress())
                .RuleFor(e => e.Country, f => f.Address.Country())
                .RuleFor(e => e.Position, f => "Temizlik Görevlisi");
            employees.AddRange(cleanerFaker.Generate(11));

            // Aşçı (Chef) - 11
            var chefFaker = new Faker<Employee>("tr")
                .RuleFor(e => e.Id, f => idCounter++)
                .RuleFor(e => e.EmployeeFirstName, f => f.Name.FirstName())
                .RuleFor(e => e.EmployeeLastName, f => f.Name.LastName())
                .RuleFor(e => e.City, f => f.Address.City())
                 .RuleFor(e => e.EmployeeAddres, f => f.Address.FullAddress())
                .RuleFor(e => e.EmployeePhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(e => e.Email, f => f.Internet.Email())
                .RuleFor(e=>e.PostalCode,f=>f.Random.Number().ToString())
                .RuleFor(e => e.Country, f => f.Address.Country())
                .RuleFor(e => e.Position, f => "Aşçı");
            employees.AddRange(chefFaker.Generate(11));

            // Garson (Waiter) - 13
            var waiterFaker = new Faker<Employee>("tr")
                .RuleFor(e => e.Id, f => idCounter++)
                .RuleFor(e => e.EmployeeFirstName, f => f.Name.FirstName())
                .RuleFor(e => e.EmployeeLastName, f => f.Name.LastName())
                .RuleFor(e => e.City, f => f.Address.City())
                .RuleFor(e=>e.EmployeeAddres,f=>f.Address.FullAddress())
                .RuleFor(e => e.EmployeePhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(e => e.Email, f => f.Internet.Email())
                 .RuleFor(e => e.PostalCode, f => f.Random.Number().ToString())
                  .RuleFor(e => e.Country, f => f.Address.Country())
                .RuleFor(e => e.Position, f => "Garson");
            employees.AddRange(waiterFaker.Generate(13));

            // Elektrikçi (Electrician) - 1
            var electricianFaker = new Faker<Employee>("tr")
                .RuleFor(e => e.Id, f => idCounter++)
                .RuleFor(e => e.EmployeeFirstName, f => f.Name.FirstName())
                .RuleFor(e => e.EmployeeLastName, f => f.Name.LastName())
                .RuleFor(e => e.City, f => f.Address.City())
                .RuleFor(e => e.EmployeePhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(e => e.Email, f => f.Internet.Email())
                 .RuleFor(e => e.PostalCode, f => f.Random.Number().ToString())
                 .RuleFor(e => e.EmployeeAddres, f => f.Address.FullAddress())
                .RuleFor(e => e.Country, f => f.Address.Country())
                .RuleFor(e => e.Position, f => "Elektrikçi");
            employees.Add(electricianFaker.Generate());

            // Bilgi İşlem Sorumlusu (IT Responsible) - 1
            var itFaker = new Faker<Employee>("tr")
                .RuleFor(e => e.Id, f => idCounter++)
                .RuleFor(e => e.EmployeeFirstName, f => f.Name.FirstName())
                .RuleFor(e => e.EmployeeLastName, f => f.Name.LastName())
                .RuleFor(e => e.Country, f => f.Address.Country())
                 .RuleFor(e => e.PostalCode, f => f.Random.Number().ToString())
                 .RuleFor(e => e.EmployeeAddres, f => f.Address.FullAddress())
                .RuleFor(e => e.EmployeePhoneNumber, f => f.Phone.PhoneNumber())
                .RuleFor(e => e.Email, f => f.Internet.Email())
                .RuleFor(e => e.City, f => f.Address.City())
                .RuleFor(e => e.Position, f => "Bilgi İşlem Sorumlusu");
            employees.Add(itFaker.Generate());

            return employees;
        }
    }
}
