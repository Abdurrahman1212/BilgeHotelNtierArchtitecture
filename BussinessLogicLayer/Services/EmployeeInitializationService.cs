using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;

namespace BussinessLogicLayer.Services
{
    public class EmployeeInitializationService
    {
        private readonly ShiftManagementService _shiftManagementService;

        public EmployeeInitializationService()
        {
            _shiftManagementService = new ShiftManagementService();
        }

        public List<Employee> InitializeHotelEmployees()
        {
            var employees = new List<Employee>();

            // Resepsiyon görevlileri - 7 kişi
            for (int i = 1; i <= 7; i++)
            {
                var employee = CreateReceptionist(i);
                _shiftManagementService.AssignWeeklyOffDay(employee);
                employees.Add(employee);
            }

            // Temizlik görevlileri - 11 kişi
            for (int i = 1; i <= 11; i++)
            {
                var employee = CreateCleaningStaff(i);
                _shiftManagementService.AssignWeeklyOffDay(employee);
                employees.Add(employee);
            }

            // Aşçılar - 11 kişi
            for (int i = 1; i <= 11; i++)
            {
                var employee = CreateChef(i);
                _shiftManagementService.AssignWeeklyOffDay(employee);
                employees.Add(employee);
            }

            // Garsonlar - 13 kişi
            for (int i = 1; i <= 13; i++)
            {
                var employee = CreateWaiter(i);
                _shiftManagementService.AssignWeeklyOffDay(employee);
                employees.Add(employee);
            }

            // Elektrikçi - 1 kişi
            var electrician = CreateElectrician();
            _shiftManagementService.AssignWeeklyOffDay(electrician);
            employees.Add(electrician);

            // IT Sorumlusu - 1 kişi
            var itManager = CreateITManager();
            _shiftManagementService.AssignWeeklyOffDay(itManager);
            employees.Add(itManager);

            return employees;
        }

        private Employee CreateReceptionist(int number)
        {
            return new Employee
            {
                EmployeeFirstName = $"Resepsiyonist{number}",
                EmployeeLastName = $"Çalışan{number}",
                EmployeePhoneNumber = $"+90 5{new Random().Next(30, 39)}{new Random().Next(1000000, 9999999)}",
                Email = $"resepsiyonist{number}@bilgehotel.com",
                Position = EmployeePosition.Receptionist,
                EmployeeType = EmployeeType.ShiftWorker,
                EmployeeAddres = $"Kemer, Antalya",
                City = "Antalya",
                Country = "Türkiye",
                PostalCode = "07980",
                StandardShift = number <= 2 ? StandardShift.Morning :
                               number <= 4 ? StandardShift.Evening : StandardShift.Night,
                HourlyWage = 75,
                MonthlyWage = 0, // Saat başı çalışan
                OvertimeRate = 1.5m,
                MinWeeklyHours = 40,
                MaxWeeklyHours = 48,
                RequiredShiftsPerWeek = 5,
                Status = DataStasus.Active
            };
        }

        private Employee CreateCleaningStaff(int number)
        {
            return new Employee
            {
                EmployeeFirstName = $"Temizlik{number}",
                EmployeeLastName = $"Çalışan{number}",
                EmployeePhoneNumber = $"+90 5{new Random().Next(30, 39)}{new Random().Next(1000000, 9999999)}",
                Email = $"temizlik{number}@bilgehotel.com",
                Position = EmployeePosition.CleaningStaff,
                EmployeeType = EmployeeType.ShiftWorker,
                EmployeeAddres = $"Kemer, Antalya",
                City = "Antalya",
                Country = "Türkiye",
                PostalCode = "07980",
                StandardShift = number % 2 == 1 ? StandardShift.Morning : StandardShift.Evening,
                HourlyWage = 60,
                MonthlyWage = 0,
                OvertimeRate = 1.5m,
                MinWeeklyHours = 40,
                MaxWeeklyHours = 48,
                RequiredShiftsPerWeek = 5,
                Status = DataStasus.Active
            };
        }

        private Employee CreateChef(int number)
        {
            return new Employee
            {
                EmployeeFirstName = $"Aşçı{number}",
                EmployeeLastName = $"Usta{number}",
                EmployeePhoneNumber = $"+90 5{new Random().Next(30, 39)}{new Random().Next(1000000, 9999999)}",
                Email = $"asci{number}@bilgehotel.com",
                Position = EmployeePosition.Chef,
                EmployeeType = EmployeeType.ShiftWorker,
                EmployeeAddres = $"Kemer, Antalya",
                City = "Antalya",
                Country = "Türkiye",
                PostalCode = "07980",
                StandardShift = number % 2 == 1 ? StandardShift.Morning : StandardShift.Evening,
                HourlyWage = 90,
                MonthlyWage = 0,
                OvertimeRate = 1.5m,
                MinWeeklyHours = 40,
                MaxWeeklyHours = 48,
                RequiredShiftsPerWeek = 5,
                Status = DataStasus.Active
            };
        }

        private Employee CreateWaiter(int number)
        {
            return new Employee
            {
                EmployeeFirstName = $"Garson{number}",
                EmployeeLastName = $"Hizmetli{number}",
                EmployeePhoneNumber = $"+90 5{new Random().Next(30, 39)}{new Random().Next(1000000, 9999999)}",
                Email = $"garson{number}@bilgehotel.com",
                Position = EmployeePosition.Waiter,
                EmployeeType = EmployeeType.ShiftWorker,
                EmployeeAddres = $"Kemer, Antalya",
                City = "Antalya",
                Country = "Türkiye",
                PostalCode = "07980",
                StandardShift = number % 2 == 1 ? StandardShift.Morning : StandardShift.Evening,
                HourlyWage = 65,
                MonthlyWage = 0,
                OvertimeRate = 1.5m,
                MinWeeklyHours = 40,
                MaxWeeklyHours = 48,
                RequiredShiftsPerWeek = 5,
                Status = DataStasus.Active
            };
        }

        private Employee CreateElectrician()
        {
            return new Employee
            {
                EmployeeFirstName = "Ahmet",
                EmployeeLastName = "Elektrikçi",
                EmployeePhoneNumber = $"+90 5{new Random().Next(30, 39)}{new Random().Next(1000000, 9999999)}",
                Email = "elektrikci@bilgehotel.com",
                Position = EmployeePosition.Electrician,
                EmployeeType = EmployeeType.HourlyWorker,
                EmployeeAddres = $"Kemer, Antalya",
                City = "Antalya",
                Country = "Türkiye",
                PostalCode = "07980",
                StandardShift = StandardShift.ExtendedMorning,
                HourlyWage = 100,
                MonthlyWage = 0,
                OvertimeRate = 1.5m,
                MinWeeklyHours = 40,
                MaxWeeklyHours = 60,
                RequiredShiftsPerWeek = 5,
                Status = DataStasus.Active
            };
        }

        private Employee CreateITManager()
        {
            return new Employee
            {
                EmployeeFirstName = "Mehmet",
                EmployeeLastName = "IT Sorumlusu",
                EmployeePhoneNumber = $"+90 5{new Random().Next(30, 39)}{new Random().Next(1000000, 9999999)}",
                Email = "it@bilgehotel.com",
                Position = EmployeePosition.ITManager,
                EmployeeType = EmployeeType.SalariedEmployee, // Yönetici - aylık ücret
                EmployeeAddres = $"Kemer, Antalya",
                City = "Antalya",
                Country = "Türkiye",
                PostalCode = "07980",
                StandardShift = StandardShift.ExtendedMorning,
                HourlyWage = 0, // Saat başı çalışmıyor
                MonthlyWage = 15000, // Aylık 15.000 TL
                OvertimeRate = 0, // Ek mesai ücreti almıyor
                MinWeeklyHours = 40,
                MaxWeeklyHours = 60,
                RequiredShiftsPerWeek = 5,
                Status = DataStasus.Active
            };
        }
    }
}
