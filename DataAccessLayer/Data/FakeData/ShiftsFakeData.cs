using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using System.Collections.Generic;
using Models.Enums;

namespace DataAccessLayer.Data.FakeData
{
    public static class ShiftsFakeData
    {
        public static List<Shift> GetFakeShifts()
        {
            // Define shift time ranges
            var shiftTimes = new List<(TimeSpan Start, TimeSpan End, ShiftType Type)>
                {
                    (new TimeSpan(8, 0, 0), new TimeSpan(16, 0, 0), ShiftType.Morning),
                    (new TimeSpan(16, 0, 0), new TimeSpan(0, 0, 0), ShiftType.Evening),
                    (new TimeSpan(0, 0, 0), new TimeSpan(8, 0, 0), ShiftType.Night)
                };

            var shifts = new List<Shift>();
            int shiftId = 1;

            // Generate fake shifts for 7 receptionists, 1 off per day, 2 per shift
            var receptionistIds = Enumerable.Range(1, 7).ToList();
            var days = Enumerable.Range(0, 7).Select(d => DateTime.Today.AddDays(d)).ToList();

            foreach (var day in days)
            {
                var offReceptionist = receptionistIds[day.DayOfWeek.GetHashCode() % 7];
                var availableReceptionists = receptionistIds.Where(id => id != offReceptionist).ToList();
                int recIndex = 0;

                foreach (var (Start, End, Type) in shiftTimes)
                {
                    if (Type == ShiftType.Night) continue; // Receptionists do not work night shift

                    for (int i = 0; i < 2; i++)
                    {
                        if (recIndex >= availableReceptionists.Count) break;
                        shifts.Add(new Shift
                        {
                            Id = shiftId++,
                            EmployeeId = availableReceptionists[recIndex++],
                            ShiftDate = day,
                            StartTime = day.Date.Add(Start),
                            EndTime = day.Date.Add(End == TimeSpan.Zero ? new TimeSpan(23, 59, 59) : End),
                            ShiftType = Type
                        });
                    }
                }
            }

            // Other staff (e.g., cook, cleaner) work morning and evening shifts only
            var otherStaffIds = new List<int> { 8, 9, 10 }; // Example IDs for other staff
            foreach (var day in days)
            {
                foreach (var staffId in otherStaffIds)
                {
                    foreach (var (Start, End, Type) in shiftTimes)
                    {
                        if (Type == ShiftType.Night) continue;
                        shifts.Add(new Shift
                        {
                            Id = shiftId++,
                            EmployeeId = staffId,
                            ShiftDate = day,
                            StartTime = day.Date.Add(Start),
                            EndTime = day.Date.Add(End == TimeSpan.Zero ? new TimeSpan(23, 59, 59) : End),
                            ShiftType = Type
                        });
                    }
                }
            }

            // Electrician and IT staff: 8:00-18:00, sometimes with overtime
            var specialStaff = new List<(int Id, string Role)> { (11, "Electrician"), (12, "IT") };
            var rand = new Random();
            foreach (var day in days)
            {
                foreach (var (Id, Role) in specialStaff)
                {
                    shifts.Add(new Shift
                    {
                        Id = shiftId++,
                        EmployeeId = Id,
                        ShiftDate = day,
                        StartTime = day.Date.Add(new TimeSpan(8, 0, 0)),
                        EndTime = day.Date.Add(new TimeSpan(18, 0, 0)),
                        ShiftType = ShiftType.Morning // Use Morning as a placeholder for "Day"
                    });

                    // Randomly add overtime
                    if (rand.NextDouble() > 0.7)
                    {
                        shifts.Add(new Shift
                        {
                            Id = shiftId++,
                            EmployeeId = Id,
                            ShiftDate = day,
                            StartTime = day.Date.Add(new TimeSpan(18, 0, 0)),
                            EndTime = day.Date.Add(new TimeSpan(20, 0, 0)),
                            ShiftType = ShiftType.Evening // Use Evening as a placeholder for "Overtime"
                        });
                    }
                }
            }

            return shifts;
        }
    }
}

