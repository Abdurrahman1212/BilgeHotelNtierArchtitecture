using Bogus;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.FakeData
{
    public static class CustomerFakeData
    {
        public static List<Customer> Customers()
        {
            Faker faker = new Faker();
            List<Customer> customers = new List<Customer>();
            for (int i = 0; i < 10; i++)
            {
                Customer Customers = new Customer
                {
                    MasterId = Guid.NewGuid().ToString(),
                    Id = i + 1,
                    FirstName = faker.Name.FirstName(),
                    LastName = faker.Name.LastName(),
                    Email = faker.Internet.Email(),
                    City = faker.Address.City(),
                    County = faker.Address.Country(),
                    PostalCode = faker.Address.ZipCode(),
                    CustomerPhone = faker.Phone.PhoneNumber(),
                    CustomerAddress = faker.Address.FullAddress(),
                    CustomerIdentityNumber = faker.Random.Number(1, 11).ToString(),
                    CustomerPaymentDetails = faker.Finance.Iban(),
                    Reservations = new List<Reservation>()

                };
                customers.Add(Customers);
            }

            return customers;
        }



    }
}






