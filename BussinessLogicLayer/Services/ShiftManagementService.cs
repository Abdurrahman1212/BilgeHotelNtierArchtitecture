using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BussinessLogicLayer.Services
{
    public class ShiftManagementService
    {
        private readonly Dictionary<EmployeePosition, ShiftRule> _positionRules;

        public ShiftManagementService()
        {
            _positionRules = InitializePositionRules();
        }

        private Dictionary<EmployeePosition, ShiftRule> InitializePositionRules()
        {
            return new Dictionary<EmployeePosition, ShiftRule>
            {
                // Resepsiyon görevlileri - 7 kişi, her vardiyede 2 kişi, haftada 1 gün off
                {
                    EmployeePosition.Receptionist,
                    new ShiftRule
                    {
                        RequiredStaffPerShift = 2,
                        TotalStaff = 7,
                        WeeklyOffDays = 1,
                        AllowedShifts = new[] { StandardShift.Morning, StandardShift.Evening, StandardShift.Night },
                        CanWorkNightShift = true,
                        MinWeeklyHours = 40,
                        MaxWeeklyHours = 48
                    }
                },
                // Temizlik görevlileri - 11 kişi, gece hariç çift vardiye
                {
                    EmployeePosition.CleaningStaff,
                    new ShiftRule
                    {
                        RequiredStaffPerShift = 2, // Her vardiyede 2 kişi (sabah ve akşam için ayrı ayrı düşünülebilir)
                        TotalStaff = 11,
                        WeeklyOffDays = 1,
                        AllowedShifts = new[] { StandardShift.Morning, StandardShift.Evening },
                        CanWorkNightShift = false,
                        MinWeeklyHours = 40,
                        MaxWeeklyHours = 48
                    }
                },
                // Aşçılar - 11 kişi, gece hariç çift vardiye
                {
                    EmployeePosition.Chef,
                    new ShiftRule
                    {
                        RequiredStaffPerShift = 2,
                        TotalStaff = 11,
                        WeeklyOffDays = 1,
                        AllowedShifts = new[] { StandardShift.Morning, StandardShift.Evening },
                        CanWorkNightShift = false,
                        MinWeeklyHours = 40,
                        MaxWeeklyHours = 48
                    }
                },
                // Garsonlar - 13 kişi, gece hariç çift vardiye
                {
                    EmployeePosition.Waiter,
                    new ShiftRule
                    {
                        RequiredStaffPerShift = 3,
                        TotalStaff = 13,
                        WeeklyOffDays = 1,
                        AllowedShifts = new[] { StandardShift.Morning, StandardShift.Evening },
                        CanWorkNightShift = false,
                        MinWeeklyHours = 40,
                        MaxWeeklyHours = 48
                    }
                },
                // Elektrikçi - 1 kişi, normal mesai + ek mesai
                {
                    EmployeePosition.Electrician,
                    new ShiftRule
                    {
                        RequiredStaffPerShift = 1,
                        TotalStaff = 1,
                        WeeklyOffDays = 2, // Haftada 2 gün off
                        AllowedShifts = new[] { StandardShift.ExtendedMorning },
                        CanWorkNightShift = false,
                        MinWeeklyHours = 40,
                        MaxWeeklyHours = 60, // Ek mesai ile
                        StandardHours = 40,
                        OvertimeMultiplier = 1.5m
                    }
                },
                // IT Sorumlusu - 1 kişi, normal mesai + ek mesai
                {
                    EmployeePosition.ITManager,
                    new ShiftRule
                    {
                        RequiredStaffPerShift = 1,
                        TotalStaff = 1,
                        WeeklyOffDays = 2,
                        AllowedShifts = new[] { StandardShift.ExtendedMorning },
                        CanWorkNightShift = false,
                        MinWeeklyHours = 40,
                        MaxWeeklyHours = 60,
                        StandardHours = 40,
                        OvertimeMultiplier = 1.5m
                    }
                }
            };
        }

        public ShiftRule GetShiftRule(EmployeePosition position)
        {
            return _positionRules.TryGetValue(position, out var rule) ? rule : null;
        }

        public List<StandardShift> GetAllowedShifts(Employee employee)
        {
            var rule = GetShiftRule(employee.Position);
            return rule?.AllowedShifts?.ToList() ?? new List<StandardShift>();
        }

        public bool CanWorkShift(Employee employee, StandardShift shift)
        {
            var rule = GetShiftRule(employee.Position);
            return rule?.AllowedShifts?.Contains(shift) ?? false;
        }

        public bool IsOffDay(Employee employee, DateTime date)
        {
            if (!employee.OffDay.HasValue) return false;

            // Haftalık off gününü kontrol et
            var dayOfWeek = (int)date.DayOfWeek;
            var offDayOfWeek = ((DateTime)employee.OffDay).DayOfWeek;

            return dayOfWeek == (int)offDayOfWeek;
        }

        public TimeSpan GetShiftDuration(StandardShift shift)
        {
            return shift switch
            {
                StandardShift.Morning => TimeSpan.FromHours(8),      // 08:00 - 16:00
                StandardShift.Evening => TimeSpan.FromHours(8),      // 16:00 - 00:00
                StandardShift.Night => TimeSpan.FromHours(8),        // 00:00 - 08:00
                StandardShift.ExtendedMorning => TimeSpan.FromHours(10), // 08:00 - 18:00
                _ => TimeSpan.FromHours(8)
            };
        }

        public DateTime GetShiftStartTime(StandardShift shift)
        {
            return shift switch
            {
                StandardShift.Morning => new DateTime(1, 1, 1, 8, 0, 0),
                StandardShift.Evening => new DateTime(1, 1, 1, 16, 0, 0),
                StandardShift.Night => new DateTime(1, 1, 1, 0, 0, 0),
                StandardShift.ExtendedMorning => new DateTime(1, 1, 1, 8, 0, 0),
                _ => new DateTime(1, 1, 1, 8, 0, 0)
            };
        }

        public DateTime GetShiftEndTime(StandardShift shift)
        {
            var startTime = GetShiftStartTime(shift);
            var duration = GetShiftDuration(shift);
            return startTime.Add(duration);
        }

        public decimal CalculateMonthlySalary(Employee employee, int year, int month)
        {
            // Bu ayın çalışma günlerini al
            var daysInMonth = DateTime.DaysInMonth(year, month);
            var monthlyHours = 0m;
            var overtimeHours = 0m;

            for (int day = 1; day <= daysInMonth; day++)
            {
                var date = new DateTime(year, month, day);

                // Off günü değilse çalışmış kabul et
                if (!IsOffDay(employee, date))
                {
                    var rule = GetShiftRule(employee.Position);
                    if (rule != null)
                    {
                        monthlyHours += rule.StandardHours / 5; // Günlük standart saat

                        // Ek mesai kontrolü
                        if (employee.HasOvertime && employee.OvertimeHours > 0)
                        {
                            overtimeHours += Math.Min(employee.OvertimeHours / 30, 2); // Günlük max 2 saat ek mesai
                        }
                    }
                }
            }

            decimal baseSalary = 0;

            if (employee.EmployeeType == EmployeeType.HourlyWorker)
            {
                baseSalary = monthlyHours * employee.HourlyWage;
                if (overtimeHours > 0)
                {
                    baseSalary += overtimeHours * employee.HourlyWage * employee.OvertimeRate;
                }
            }
            else if (employee.EmployeeType == EmployeeType.SalariedEmployee)
            {
                baseSalary = employee.MonthlyWage;
            }

            return Math.Round(baseSalary, 2);
        }

        public void AssignWeeklyOffDay(Employee employee)
        {
            // Rastgele bir gün seç (Pazartesi=1, Pazar=7)
            var random = new Random();
            var offDayOfWeek = random.Next(1, 8); // 1-7 arası

            employee.OffDay = new DateTime(2024, 1, offDayOfWeek); // Yıl ve ay önemli değil, sadece gün önemli
        }

        public List<ShiftAssignment> GenerateWeeklySchedule(List<Employee> employees, DateTime weekStartDate)
        {
            var assignments = new List<ShiftAssignment>();

            foreach (var employee in employees)
            {
                var rule = GetShiftRule(employee.Position);
                if (rule == null) continue;

                // Çalışanın standart vardiyasını al
                var standardShift = employee.StandardShift;

                for (int day = 0; day < 7; day++)
                {
                    var date = weekStartDate.AddDays(day);

                    // Off günü değilse vardiya ata
                    if (!IsOffDay(employee, date))
                    {
                        assignments.Add(new ShiftAssignment
                        {
                            EmployeeId = employee.Id,
                            ShiftDate = date,
                            ShiftType = standardShift,
                            IsAssigned = true
                        });
                    }
                    else
                    {
                        assignments.Add(new ShiftAssignment
                        {
                            EmployeeId = employee.Id,
                            ShiftDate = date,
                            ShiftType = StandardShift.Off,
                            IsAssigned = false
                        });
                    }
                }
            }

            return assignments;
        }
    }

    public class ShiftRule
    {
        public int RequiredStaffPerShift { get; set; }
        public int TotalStaff { get; set; }
        public int WeeklyOffDays { get; set; }
        public StandardShift[] AllowedShifts { get; set; }
        public bool CanWorkNightShift { get; set; }
        public int MinWeeklyHours { get; set; }
        public int MaxWeeklyHours { get; set; }
        public int StandardHours { get; set; } = 40; // Varsayılan haftalık 40 saat
        public decimal OvertimeMultiplier { get; set; } = 1.5m; // Varsayılan %50 ek ücret
    }

    public class ShiftAssignment
    {
        public int EmployeeId { get; set; }
        public DateTime ShiftDate { get; set; }
        public StandardShift ShiftType { get; set; }
        public bool IsAssigned { get; set; }
    }
}
