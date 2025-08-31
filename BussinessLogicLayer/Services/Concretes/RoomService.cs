using BusinessLogicLayer.Services;
using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Contracts.Interfaces;
using Models.Entities;
using DataAccessLayer.Data.FakeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using DataAccessLayer.Context;
using DataAccessLayer.Services.Abstracs;
using DataAccessLayer.Services.Concretes;
namespace BussinessLogicLayer.Services.Concretes
{
    public class RoomService : ManagerService<Room>, IRoomService
    {
        private readonly ProjectDatabaseContext _context;
        private readonly IRoomRepo _roomrepo;
        public RoomService(IManagerRepository<Room> repository,ProjectDatabaseContext context,IRoomRepo roomRepo) : base(repository)
        {
            _context = context;
            _roomrepo = roomRepo;
        }
        public async Task CreateReservationAsync(Reservation reservation)
        {
            await _context.Reservations.AddAsync(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Room>> GetAvailableRooms(DateTime checkIn, DateTime checkOut)
        {
            // Use repository method to get vacant rooms with details
            var rooms = await _roomrepo.GetVacantRoomsWithDetailsAsync();

            // Filter rooms that are vacant (based on room status)
            var availableRooms = rooms.Where(room =>
                room.Status == Models.Enums.RoomStatus.Empty
            ).ToList();

            return availableRooms;
        }

            public async Task GetRoomReminders()
        {
            // Example: Get rooms to be vacated and rooms needing maintenance reminders for today
            var today = DateTime.Today;
            var roomsToBeVacated = await _roomrepo.GetRoomsToBeVacatedAsync(today);
            var roomsNeedingMaintenance = await _roomrepo.GetRoomsNeedingMaintenanceReminderAsync(today);

            // You can process or return these lists as needed.
            // For now, just a placeholder to show reminders are fetched.
            // If you need to return them, change the return type accordingly.
        }

        public async Task<List<Room>> GetRoomsNeedingMaintenanceReminderAsync(DateTime date)
        {
            return await _roomrepo.GetRoomsNeedingMaintenanceReminderAsync(date);
        }

        public Task UptadeRoom(Room OriginalRoom, Room UpdatedRoom)
        {
           return _roomrepo.UpdateRoom(OriginalRoom, UpdatedRoom);
        }
    }
}
