using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BussinessLogicLayer.Services
{
    public class PayrollService
    {
        private readonly ShiftManagementService _shiftManagementService;

        public PayrollService()
        {
            _shiftManagementService = new ShiftManagementService();
        }

        public PayrollCalculation CalculateMonthlyPayroll(Employee employee, int year, int month)
        {
            var calculation = new PayrollCalculation
            {
                EmployeeId = employee.Id,
                EmployeeName = $"{employee.EmployeeFirstName} {employee.EmployeeLastName}",
                Position = employee.Position,
                Month = month,
                Year = year
            };

            // Çalışanın türüne göre maaş hesapla
            switch (employee.EmployeeType)
            {
                case EmployeeType.HourlyWorker:
                    calculation = CalculateHourlyWorkerPayroll(employee, year, month);
                    break;
                case EmployeeType.SalariedEmployee:
                    calculation = CalculateSalariedEmployeePayroll(employee, year, month);
                    break;
                case EmployeeType.ShiftWorker:
                    calculation = CalculateShiftWorkerPayroll(employee, year, month);
                    break;
            }

            return calculation;
        }

        private PayrollCalculation CalculateHourlyWorkerPayroll(Employee employee, int year, int month)
        {
            var calculation = new PayrollCalculation
            {
                EmployeeId = employee.Id,
                EmployeeName = $"{employee.EmployeeFirstName} {employee.EmployeeLastName}",
                Position = employee.Position,
                EmployeeType = employee.EmployeeType,
                Month = month,
                Year = year,
                HourlyRate = employee.HourlyWage,
                OvertimeRate = employee.HourlyWage * employee.OvertimeRate
            };

            // Bu ayın günlerini kontrol et
            var daysInMonth = DateTime.DaysInMonth(year, month);
            var regularHours = 0m;
            var overtimeHours = 0m;

            for (int day = 1; day <= daysInMonth; day++)
            {
                var date = new DateTime(year, month, day);

                // Off günü değilse çalışmış kabul et
                if (!_shiftManagementService.IsOffDay(employee, date))
                {
                    var rule = _shiftManagementService.GetShiftRule(employee.Position);
                    if (rule != null)
                    {
                        // Günlük standart saat
                        var dailyHours = rule.StandardHours / 5m; // 5 iş günü varsayımı
                        regularHours += dailyHours;

                        // Ek mesai varsa ekle
                        if (employee.HasOvertime)
                        {
                            var dailyOvertime = Math.Min(employee.OvertimeHours / 30m, 2m); // Günlük max 2 saat
                            overtimeHours += dailyOvertime;
                        }
                    }
                }
            }

            calculation.RegularHours = regularHours;
            calculation.OvertimeHours = overtimeHours;
            calculation.RegularPay = regularHours * employee.HourlyWage;
            calculation.OvertimePay = overtimeHours * employee.HourlyWage * employee.OvertimeRate;
            calculation.TotalPay = calculation.RegularPay + calculation.OvertimePay;

            return calculation;
        }

        private PayrollCalculation CalculateSalariedEmployeePayroll(Employee employee, int year, int month)
        {
            return new PayrollCalculation
            {
                EmployeeId = employee.Id,
                EmployeeName = $"{employee.EmployeeFirstName} {employee.EmployeeLastName}",
                Position = employee.Position,
                EmployeeType = employee.EmployeeType,
                Month = month,
                Year = year,
                MonthlySalary = employee.MonthlyWage,
                TotalPay = employee.MonthlyWage
            };
        }

        private PayrollCalculation CalculateShiftWorkerPayroll(Employee employee, int year, int month)
        {
            // Vardiyalı çalışanlar için saat başı hesaplama
            return CalculateHourlyWorkerPayroll(employee, year, month);
        }

        public List<PayrollCalculation> CalculateAllPayrolls(List<Employee> employees, int year, int month)
        {
            return employees.Select(emp => CalculateMonthlyPayroll(emp, year, month)).ToList();
        }

        public decimal GetTotalPayrollAmount(List<PayrollCalculation> calculations)
        {
            return calculations.Sum(c => c.TotalPay);
        }

        public PayrollSummary GeneratePayrollSummary(List<PayrollCalculation> calculations, int year, int month)
        {
            return new PayrollSummary
            {
                Year = year,
                Month = month,
                TotalEmployees = calculations.Count,
                TotalRegularPay = calculations.Sum(c => c.RegularPay),
                TotalOvertimePay = calculations.Sum(c => c.OvertimePay),
                TotalPayroll = calculations.Sum(c => c.TotalPay),
                AveragePayPerEmployee = calculations.Any() ? calculations.Sum(c => c.TotalPay) / calculations.Count : 0,
                Calculations = calculations
            };
        }
    }

    public class PayrollCalculation
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public EmployeePosition Position { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        // Saat başı çalışanlar için
        public decimal HourlyRate { get; set; }
        public decimal OvertimeRate { get; set; }
        public decimal RegularHours { get; set; }
        public decimal OvertimeHours { get; set; }
        public decimal RegularPay { get; set; }
        public decimal OvertimePay { get; set; }

        // Aylık çalışanlar için
        public decimal MonthlySalary { get; set; }

        // Toplam
        public decimal TotalPay { get; set; }
    }

    public class PayrollSummary
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int TotalEmployees { get; set; }
        public decimal TotalRegularPay { get; set; }
        public decimal TotalOvertimePay { get; set; }
        public decimal TotalPayroll { get; set; }
        public decimal AveragePayPerEmployee { get; set; }
        public List<PayrollCalculation> Calculations { get; set; }
    }
}
