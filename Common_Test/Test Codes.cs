using DataAccessLayer.Context;
using DataAccessLayer.Services.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Test
{
    internal class TestCodes
    {
        #region Repository Test Operations

        //// Create DbContext (ensure your connection string is set in ProjectDatabaseContext)
        //using var context = new ProjectDatabaseContext();

        //// Create repository instance
        //var repository = new ManagerRepository<Room>(context);

        //// 1. Test CreateAsync
        //var newRoom = new Room
        //{
        //    RoomNumber = 101,
        //    SelectedStatus = Models.Enums.DataStasus.Active,
        //    CreatedDate = DateTime.Now,
        //    Description = "Test Room",
        //    ImageUrl = "Test Image"
        //};
        //await repository.CreateAsync(newRoom);
        //Console.WriteLine("Room Created!");

        //// 2. Test GetAll
        //var allRooms = repository.GetAll().ToList();
        //Console.WriteLine($"Total Rooms: {allRooms.Count}");

        //// 3. Test UpdateAsync
        //var roomToUpdate = allRooms.FirstOrDefault();
        //if (roomToUpdate != null)
        //{
        //    roomToUpdate.Description = "Updated Room Description";
        //    await repository.UpdateAsync(roomToUpdate);
        //    Console.WriteLine("Room Updated!");
        //}

        //// 4. Test DeleteAsync (soft delete)
        //var roomToDelete = allRooms.LastOrDefault();
        //if (roomToDelete != null)
        //{
        //    await repository.DeleteAsync(roomToDelete);
        //    Console.WriteLine("Room Soft Deleted!");
        //}

        //// 5. Test DestroyAsync (hard delete)
        //var roomToDestroy = allRooms.FirstOrDefault();
        //if (roomToDestroy != null)
        //{
        //    await repository.DestroyAsync(roomToDestroy);
        //    Console.WriteLine("Room Hard Deleted!");
        //}

        #endregion
        #region GetRoomsNeedingMaintenanceReminderAsync
        //    // Test RoomRepo specific methods
        //    using var context = new ProjectDatabaseContext();
        //    var roomRepo = new RoomRepo(context);


        //public async Task<List<Room>> GetRoomsNeedingMaintenanceReminderAsync(DateTime date)
        //{
        //    // Rooms that have just been vacated (CheckOutDate == date and reservation is active)
        //    // or rooms that are currently vacant (no active reservation overlapping with 'date')
        //    var roomsToRemind = await _dbSet
        //        .Where(room =>
        //            room.Reservations.Any(r =>
        //                r.CheckOutDate.Date == date.Date &&
        //                r.status == DataStasus.Active
        //            )
        //            ||
        //            !room.Reservations.Any(r =>
        //                r.CheckInDate <= date && r.CheckOutDate > date && r.status == DataStasus.Active
        //            )
        //        )
        //        .ToListAsync();
        //    return roomsToRemind;
        //    // Prompt user for reminder date and time
        //    Console.Write("Enter reminder date (yyyy-MM-dd): ");
        //    var dateInput = Console.ReadLine();
        //    Console.Write("Enter reminder time (HH:mm, 24-hour format): ");
        //    var timeInput = Console.ReadLine();

        //    // List all rooms for selection
        //    var allRooms = await context.Rooms.ToListAsync();
        //    if (allRooms.Count == 0)
        //    {
        //        Console.WriteLine("No rooms found in the system.");
        //        return;
        //    }

        //    Console.WriteLine("Select a room for maintenance reminder:");
        //    for (int i = 0; i < allRooms.Count; i++)
        //    {
        //        Console.WriteLine($"{i + 1}. Room {allRooms[i].RoomNumber} - {allRooms[i].Description}");
        //    }
        //    Console.Write("Enter the number of the room: ");
        //    if (!int.TryParse(Console.ReadLine(), out int roomChoice) || roomChoice < 1 || roomChoice > allRooms.Count)
        //    {
        //        Console.WriteLine("Invalid room selection.");
        //        return;
        //    }
        //    var selectedRoom = allRooms[roomChoice - 1];

        //    if (DateTime.TryParse($"{dateInput} {timeInput}", out var reminderDateTime))
        //    {
        //        // Check if the selected room needs maintenance on the given date
        //        var roomsNeedingMaintenance = await roomRepo.GetRoomsNeedingMaintenanceReminderAsync(reminderDateTime.Date);
        //        var roomNeedsMaintenance = roomsNeedingMaintenance.Any(r => r.Id == selectedRoom.Id);

        //        if (roomNeedsMaintenance)
        //        {
        //            Console.WriteLine($"Room {selectedRoom.RoomNumber} - {selectedRoom.Description} needs maintenance reminder on {reminderDateTime:yyyy-MM-dd}.");

        //            // Wait until the specified reminder time
        //            var delay = reminderDateTime - DateTime.Now;
        //            if (delay > TimeSpan.Zero)
        //            {
        //                Console.WriteLine($"Waiting until {reminderDateTime} to show the reminder...");
        //                await Task.Delay(delay);
        //            }

        //            // Show the reminder at the specified time
        //            Console.WriteLine("=== MAINTENANCE REMINDER ===");
        //            Console.WriteLine($"Reminder: Room {selectedRoom.RoomNumber} - {selectedRoom.Description} needs maintenance.");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Room {selectedRoom.RoomNumber} does not require a maintenance reminder on {reminderDateTime:yyyy-MM-dd}.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid date or time format.");
        //    }
        #endregion
        #region GetRoomsToBeVacatedAsync
        //public async Task<List<Room>> GetRoomsToBeVacatedAsync(DateTime date)
        //{
        //    // Rooms with a reservation ending on the given date
        //    var roomsToBeVacated = await _dbSet
        //        .Where(room =>
        //            room.Reservations.Any(r =>
        //                r.CheckOutDate.Date == date.Date &&
        //                r.status == DataStasus.Active
        //            )
        //        )
        //        .ToListAsync();
        //    return roomsToBeVacated;
        //}
        //using var context = new ProjectDatabaseContext();
        //var roomRepo = new RoomRepo(context);

        //Console.Write("Enter date to check for rooms to be vacated (yyyy-MM-dd): ");
        //var input = Console.ReadLine();
        //if (DateTime.TryParse(input, out var dateToCheck))
        //{
        //    var roomsToBeVacated = await roomRepo.GetRoomsToBeVacatedAsync(dateToCheck);
        //    if (roomsToBeVacated.Count == 0)
        //    {
        //        Console.WriteLine("No rooms to be vacated on this date.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Rooms to be vacated:");
        //        foreach (var room in roomsToBeVacated)
        //        {
        //            Console.WriteLine($"Room {room.RoomNumber} - {room.Description}");
        //        }
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid date format.");
        //}


        #endregion
        #region
        //       public async Task<List<Room>> GetVacantRoomsAsync()
        //{
        //    var today = DateTime.Today;
        //    // Rooms with no active reservation for today
        //    var vacantRooms = await _dbSet
        //        .Where(room =>
        //            !room.Reservations.Any(r =>
        //                r.CheckInDate <= today && r.CheckOutDate > today && r.status == DataStasus.Active
        //            )
        //        )
        //        .ToListAsync();
        //    return vacantRooms;
        //var context = new ProjectDatabaseContext();
        //    var roomRepo = new RoomRepo(context);
        //    var vacantRooms = await roomRepo.GetVacantRoomsAsync();
        //    if (vacantRooms.Count == 0)
        //    {
        //        Console.WriteLine("No vacant rooms found for today.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Vacant rooms for today:");
        //        foreach (var room in vacantRooms)
        //        {
        //            Console.WriteLine($"Room {room.RoomNumber} - {room.Description}");
        //        }
        //    }
        //}
        #endregion

        #region GetVacantRoomsWithDetailsAsync
        //       public async Task<List<Room>> GetVacantRoomsWithDetailsAsync()
        //{
        //    var today = DateTime.Today;
        //    // Get rooms with no active reservation for today, including all details and navigation properties
        //    var vacantRoomsWithDetails = await _dbSet
        //        .Include(r => r.Reservations)
        //        .Where(room =>
        //            !room.Reservations.Any(res =>
        //                res.CheckInDate <= today && res.CheckOutDate > today && res.status == DataStasus.Active
        //            )
        //        )
        //        .ToListAsync();
        //    return vacantRoomsWithDetails;
        //}
        #endregion



        #region CalculateRoomPrice Test
        // Test for CalculateRoomPrice
        //static void TestCalculateRoomPrice()
        //{
        //    // Arrange
        //    var testCases = new[]
        //    {
        //        // roomType, packageType, numberOfDays, expectedPrice
        //        (Models.Enums.RoomType.Single, Models.Enums.PackageType.FullBoard, 2, 200m),
        //        (Models.Enums.RoomType.Double, Models.Enums.PackageType.AllIncluesive, 3, 585m),
        //        (Models.Enums.RoomType.KingSuite, Models.Enums.PackageType.FullBoard, 1, 400m),
        //        (Models.Enums.RoomType.Triple, Models.Enums.PackageType.AllIncluesive, 4, 832m),
        //        (Models.Enums.RoomType.Quadruple, Models.Enums.PackageType.FullBoard, 5, 1000m)
        //    };

        //    foreach (var (roomType, packageType, numberOfDays, expectedPrice) in testCases)
        //    {
        //        // Act
        //        decimal actualPrice = CalculateRoomPrice(roomType, packageType, numberOfDays);

        //        // Assert
        //        if (actualPrice == expectedPrice)
        //        {
        //            Console.WriteLine($"PASS: {roomType}, {packageType}, {numberOfDays} days => {actualPrice}");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"FAIL: {roomType}, {packageType}, {numberOfDays} days => Expected: {expectedPrice}, Actual: {actualPrice}");
        //        }
        //    }

        //    // Test for exception when numberOfDays <= 0
        //    try
        //    {
        //        CalculateRoomPrice(Models.Enums.RoomType.Single, Models.Enums.PackageType.FullBoard, 0);
        //        Console.WriteLine("FAIL: Exception not thrown for numberOfDays = 0");
        //    }
        //    catch (ArgumentException)
        //    {
        //        Console.WriteLine("PASS: Exception thrown for numberOfDays = 0");
        //    }
        #endregion
        #region GetEmployeesByıd
        //static async Task TestGetEmployeeByIdAsync()
        //{
        //    using var context = new ProjectDatabaseContext();
        //    int testEmployeeId = 1; // Use a valid employee ID from your test database

        //    // Simulate the method under test
        //    var employee = await context.Employees
        //        .Include(e => e.Shifts)
        //        .FirstOrDefaultAsync(e => e.Id == testEmployeeId);

        //    if (employee != null)
        //    {
        //        Console.WriteLine($"PASS: Employee found - ID: {employee.Id}");
        //        Console.WriteLine($"Name: {employee.EmployeeFirstName} {employee.EmployeeLastName}");
        //        Console.WriteLine($"Phone: {employee.EmployeePhoneNumber}");
        //        Console.WriteLine($"Email: {employee.Email}");
        //        Console.WriteLine($"Position: {employee.Position}");
        //        Console.WriteLine($"Address: {employee.EmployeeAddres}, {employee.City}, {employee.Country}, {employee.PostalCode}");
        //        Console.WriteLine($"Hourly Wage: {employee.HourlyWage}");
        //        Console.WriteLine($"Monthly Wage: {employee.MonthlyWage}");
        //        Console.WriteLine($"Status: {employee.Status}");
        //        Console.WriteLine($"Shifts ({employee.Shifts?.Count ?? 0}):");
        //        if (employee.Shifts != null)
        //        {
        //            foreach (var shift in employee.Shifts)
        //            {
        //                Console.WriteLine($"  - Shift ID: {shift.Id}, Date: {shift.ShiftDate:yyyy-MM-dd}, Type: {shift.ShiftType}, Start: {shift.StartTime:HH:mm}, End: {shift.EndTime:HH:mm}");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"FAIL: No employee found with ID {testEmployeeId}");
        //    }
        //}

        //// Call the test method in Main (add this line inside Main method)
        //await TestGetEmployeeByIdAsync();
        #endregion
        #region  SelectEmployeesForShiftDateAsync
        //    static async Task Main(string[] args)
        //    {
        //        //await SelectEmployeesForShiftDateAsync();
        //    }

        ////    // Example usage: select a date and display all properties of employees off on that date
        ////    static async Task SelectEmployeesForShiftDateAsync()
        ////    {
        ////        Console.Write("Enter shift date (yyyy-MM-dd): ");
        ////        var input = Console.ReadLine();
        ////        if (!DateTime.TryParse(input, out var shiftDate))
        ////        {
        ////            Console.WriteLine("Invalid date format.");
        ////            return;
        ////        }

        ////        var employeesOff = await EmployeeUtils.GetEmployeesOffByDateAsync(shiftDate);
        ////        if (employeesOff.Count == 0)
        ////        {
        ////            Console.WriteLine("All employees have shifts on this date.");
        ////        }
        ////        else
        ////        {
        ////            Console.WriteLine("Employees available for selection on {0:yyyy-MM-dd}:", shiftDate);
        ////            for (int i = 0; i < employeesOff.Count; i++)
        ////            {
        ////                var emp = employeesOff[i];
        ////                Console.WriteLine($@"
        ////    {i + 1}.
        ////      ID: {emp.Id}
        ////      First Name: {emp.EmployeeFirstName}
        ////      Last Name: {emp.EmployeeLastName}
        ////      Phone: {emp.EmployeePhoneNumber}
        ////      Email: {emp.Email}
        ////      Position: {emp.Position}
        ////      Address: {emp.EmployeeAddres}
        ////      City: {emp.City}
        ////      Country: {emp.Country}
        ////      Postal Code: {emp.PostalCode}
        ////      Shift Start: {emp.ShiftStart:yyyy-MM-dd HH:mm}
        ////      Shift End: {emp.ShiftEnd:yyyy-MM-dd HH:mm}
        ////      Weekly Off Date: {emp.WeeklyOfDate}
        ////      Has Overtime: {emp.HasOverTime}
        ////      Weekly Worked Hours: {emp.WeeklyWorkedHours}
        ////      Total Worked Hours: {emp.TotalWorkedHours}
        ////      Hourly Wage: {emp.HourlyWage}
        ////      Monthly Wage: {emp.MonthlyWage}
        ////      Status: {emp.Status}
        ////    ");
        ////            }
        ////        }
        ////    }
        ////}
        ////// Upgraded: GetEmployeesOffByDateAsync as a public static method in a utility class
        ////public static class EmployeeUtils
        ////{
        ////    public static async Task<List<Employee>> GetEmployeesOffByDateAsync(DateTime shiftDate)
        ////    {
        ////        using var context = new ProjectDatabaseContext();

        ////        // Fetch employees who are not assigned to any shift on the given date  
        ////        var employeesOff = await context.Employees
        ////            .Include(e => e.Shifts)
        ////            .Where(e => !e.Shifts.Any(s => s.ShiftDate.Date == shiftDate.Date))
        ////            .ToListAsync();

        ////        return employeesOff;
        ////    }
        ////}
        ///
        #endregion
        #region Employee Methods Test Run
        //        var options = new DbContextOptionsBuilder<ProjectDatabaseContext>()
        //            .UseInMemoryDatabase(databaseName: "TestDb")
        //            .Options;

        //        await using var context = new ProjectDatabaseContext(options);

        //            try
        //            {
        //                // Seed test data
        //                var employee = new Employee
        //                {
        //                    Id = 1,
        //                    EmployeeFirstName = "John",
        //                    EmployeeLastName = "Doe",
        //                    EmployeePhoneNumber = "123456789",
        //                    Email = "john.doe@example.com",
        //                    Position = "Staff",
        //                    EmployeeAddres = "123 Main St",
        //                    City = "CityName",
        //                    Country = "CountryName",
        //                    PostalCode = "12345",
        //                    HourlyWage = 20,
        //                    MonthlyWage = 0,
        //                    Status = Models.Enums.DataStasus.Active
        //                };

        //    var manager = new Employee
        //    {
        //        Id = 2,
        //        EmployeeFirstName = "Jane",
        //        EmployeeLastName = "Smith",
        //        EmployeePhoneNumber = "987654321",
        //        Email = "jane.smith@example.com",
        //        Position = "Manager",
        //        EmployeeAddres = "456 Main St",
        //        City = "CityName",
        //        Country = "CountryName",
        //        PostalCode = "54321",
        //        HourlyWage = 0,
        //        MonthlyWage = 4000,
        //        Status = Models.Enums.DataStasus.Active
        //    };

        //    var shift1 = new Shift { Id = 1, EmployeeId = 1, ShiftDate = DateTime.Today };
        //    var shift2 = new Shift { Id = 2, EmployeeId = 1, ShiftDate = DateTime.Today.AddDays(-1) };

        //    context.Employees.Add(employee);
        //                context.Employees.Add(manager);
        //                context.Shifts.AddRange(shift1, shift2);
        //                await context.SaveChangesAsync();

        //    var employeeService = new EmployeeRepo(context);

        //    Console.WriteLine("=== Employee Shift Tests ===");
        //                var shifts = await employeeService.GetShiftsByEmployeeIdAsync(1);
        //    Console.WriteLine($"Shifts for Employee 1: {shifts.Count}");

        //                var empWithShifts = await employeeService.GetEmployeeWithShiftsAsync(1);
        //    Console.WriteLine($"Employee {empWithShifts.EmployeeFirstName} has {empWithShifts.Shifts.Count} shifts.");

        //                var emp = await employeeService.GetEmployeeByIdAsync(1);
        //    Console.WriteLine($"Employee by ID 1: {emp.EmployeeFirstName}");

        //                var empsWithShiftsByDate = await employeeService.GetEmployeesWithShiftsByDateAsync(DateTime.Today);
        //    Console.WriteLine($"Employees with shifts today: {empsWithShiftsByDate.Count}");

        //                var empsOff = await employeeService.GetEmployeesOffByDateAsync(DateTime.Today);
        //    Console.WriteLine($"Employees off today: {empsOff.Count}");

        //                var overtimeShifts = await employeeService.GetOvertimeShiftsByEmployeeIdAsync(1);
        //    Console.WriteLine($"Overtime shifts for Employee 1: {overtimeShifts.Count}");

        //                var salary = await employeeService.CalculateMonthlySalaryAsync(1, DateTime.Today.Year, DateTime.Today.Month);
        //    Console.WriteLine($"Monthly salary for Employee 1: {salary}");

        //                var managerSalary = await employeeService.CalculateManagerMonthlySalaryAsync(2, DateTime.Today.Year, DateTime.Today.Month);
        //    Console.WriteLine($"Monthly salary for Manager 2: {managerSalary}");
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine("An error occurred during test execution:");
        //Console.WriteLine(ex);
        //            }


        #endregion Em

    }
    #region PaymentController
    //    using BussinessLogicLayer.DtoClasses;
    //using BussinessLogicLayer.Services.Abstracs;
    //using Microsoft.AspNetCore.Http;
    //using Microsoft.AspNetCore.Mvc;
    //using Models.Entities;
    //using Presentation.Models.Payments.ResponseModels;
    //using Presentation.Models.Payments.RequestModels;
    //using System.Security.Claims;
    //using Models.Enums;
    //namespace Presentation.Controllers
    //{
    //    public class PaymentController : Controller
    //    {
    //        private readonly IReservationService _reservationService;
    //        private readonly IUserService _userService;
    //        private readonly IExpenseService _expenseService;
    //        private readonly IPaymentService _paymentService;
    //        private readonly IRoomService _roomService;

    //        public PaymentController(IReservationService reservationService, IUserService userService, IExpenseService expenseService, IPaymentService paymentService, IRoomService roomService)
    //        {
    //            _reservationService = reservationService;
    //            _userService = userService;
    //            _expenseService = expenseService;
    //            _paymentService = paymentService;
    //            _roomService = roomService;
    //        }
    //        public IActionResult Index(int? id)
    //        {
    //            if (id == null)
    //            {
    //                return RedirectToAction("Index", "Home");
    //            }

    //            var room = _roomService.GetById(id.Value);
    //            if (room == null)
    //            {
    //                return NotFound();
    //            }

    //            return View(room);
    //        }




    //        [HttpGet]
    //        public async Task<IActionResult> CustomerReservationDetails(int customerId)
    //        {
    //            var reservations = _reservationService.GetReservationsByCustomerId(customerId);
    //            if (reservations == null || !reservations.Any())
    //            {
    //                return NotFound("No reservations found for the customer.");
    //            }

    //            var reservationDetails = reservations.Select(reservation => new
    //            {
    //                ReservationId = reservation.Id,
    //                CheckInDate = reservation.CheckInDate,
    //                CheckOutDate = reservation.CheckOutDate,
    //                RoomNumber = reservation.Room?.RoomNumber,
    //                TotalAmount = reservation.TotalAmount,
    //                Payments = _paymentService.GetAll()
    //                    .Where(payment => payment.ReservationId == reservation.Id)
    //                    .Select(payment => new
    //                    {
    //                        PaymentDate = payment.PaymentDate,
    //                        PaymentAmount = payment.PaymentAmount,
    //                        PaymentMethod = payment.PaymentMethod.ToString()
    //                    }).ToList()
    //            });

    //            return View(reservationDetails);
    //        }

    //        //public async Task<IActionResult> CompletePayment()
    //        //{
    //        //    return View();
    //        //}

    //        //[HttpPost]
    //        //[ValidateAntiForgeryToken]
    //        public async Task<IActionResult> CompletePayment(PaymentProcessRequestModel paymentRequest)
    //        {
    //            if (!ModelState.IsValid) return View(paymentRequest);


    //            var payment = new Payment
    //            {
    //                PaymentDate = DateTime.Now,
    //                PaymentAmount = paymentRequest.ShoppingPrice,
    //                ReservationId = paymentRequest.ReservationId,
    //                PaymentMethod = PaymentMethod.CreditCard
    //            };

    //            await _paymentService.CreateAsync(payment);

    //            Reservation getReservation = _reservationService.GetById(paymentRequest.ReservationId);
    //            getReservation.TotalAmount = payment.PaymentAmount;
    //            await _reservationService.UpdateAsync(getReservation);

    //            //return RedirectToAction(nameof(CustomerReservationDetails), new { reservationId = paymentRequest.ReservationId });
    //            return Json(payment);
    //        }
    //    }
    #endregion
}


