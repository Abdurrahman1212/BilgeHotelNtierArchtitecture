using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using System.Collections.Generic;

namespace DataAccessLayer.Data.FakeData
{
    public static class ShiftsFakeData
    {
        public static List<Shift> NewShifts()
        {
            Faker faker = new Faker();
            List<Shift> shifts = new List<Shift>();
            for (int i = 0; i < 10; i++)
            {
                Shift shift = new Shift
                {
                    Id = i + 1,
                    ShiftType = Random.Shared.Next(0, 2) == 0 ? Models.Enums.ShiftType.Day :
                                Random.Shared.Next(1, 3) == 1 ? Models.Enums.ShiftType.Mid :
                                Models.Enums.ShiftType.Night,
                    StartTime = faker.Date.Past(),
                    EndTime = faker.Date.Future(),
                    EmployeeId = faker.Random.Int(1, 10)
                };
                shifts.Add(shift);
            }

            return shifts;
        }
    }
}

