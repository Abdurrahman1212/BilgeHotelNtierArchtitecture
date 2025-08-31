using Bogus;
using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.FakeData
{
    public class ReservationsFakeData
    {
        public static List<Reservation> GetFakeReservations()
        {
            var faker = new Faker();
            List<Reservation> ReservartionLists = new List<Reservation>();
            int TotalReservations = 10;
            for (int i = 0; i < TotalReservations; i++)
            {
                var checkInDate = faker.Date.Between(DateTime.Now, DateTime.Now.AddYears(1));  // Ensure the date is valid
                var checkOutDate = faker.Date.Between(checkInDate.AddDays(1), checkInDate.AddYears(1));  // Ensure a valid range for CheckOut
                var reservation = new Reservation()
                {
                    MasterId = Guid.NewGuid().ToString(),
                    Id = i + 1,
                    CheckInDate = checkInDate,
                    CheckOutDate = checkOutDate,
                    PaymentMethod= (PaymentMethod)(i % Enum.GetValues(typeof(PaymentMethod)).Length),
                    ReservationStatus = (ReservationStatus)(i % Enum.GetValues(typeof(ReservationStatus)).Length),
                    PackageType = (PackageType)(i % Enum.GetValues(typeof(PackageType)).Length),
                    TotalAmount = decimal.Parse(faker.Commerce.Price(1500, 2500)),
                    status = (DataStasus)(i % Enum.GetValues(typeof(DataStasus)).Length),
                    CustomerId = faker.Random.Int(1, 10),
                    RoomId = faker.Random.Int(1, 50),
                    Expenses=new List<Expense>(),
                };
                ReservartionLists.Add(reservation);
            }

            return ReservartionLists;
        }
    }
}
