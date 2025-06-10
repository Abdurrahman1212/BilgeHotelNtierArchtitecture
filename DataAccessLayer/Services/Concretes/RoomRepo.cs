using DataAccessLayer.Context;
using DataAccessLayer.Services.Abstracs;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Concretes
{
    public class RoomRepo : ManagerRepository<Room>, IRoomRepo
    {
        private readonly   DbSet<Room> _dbSet;
        public RoomRepo(ProjectDatabaseContext project):base(project)
        {
            _dbSet = project.Set<Room>();
        }

        public decimal CalculateRoomPrice(RoomType roomType, PackageType packageType, int numberOfDays)
        {
            if (numberOfDays <= 0)
                throw new ArgumentException("Number of days must be greater than zero.", nameof(numberOfDays));

            // Base price per night by room type
            decimal basePricePerNight = roomType switch
            {
                RoomType.Single => 100m,
                RoomType.Double => 150m,
                RoomType.Triple => 160m,
                RoomType.Quadruple => 200m,
                RoomType.KingSuite => 400m,
                _ => 100m
            };

            // Package multiplier
            decimal packageMultiplier = packageType switch
            {
                PackageType.FullBoard => 1.0m,
                PackageType.AllIncluesive => 1.3m,
                _ => 1.0m
            };

            decimal totalPrice = basePricePerNight * packageMultiplier * numberOfDays;
            return totalPrice;
        }

        #region GetRoomsNeedingMaintenanceReminderAsync
        public async Task<List<Room>> GetRoomsNeedingMaintenanceReminderAsync(DateTime date)
        {
            // Rooms that have just been vacated (CheckOutDate == date and reservation is active)
            // or rooms that are currently vacant (no active reservation overlapping with 'date')
            var roomsToRemind = await _dbSet
                .Where(room =>
                    room.Reservations.Any(r =>
                        r.CheckOutDate.Date == date.Date &&
                        r.status == DataStasus.Active
                    )
                    ||
                    !room.Reservations.Any(r =>
                        r.CheckInDate <= date && r.CheckOutDate > date && r.status == DataStasus.Active
                    )
                )
                .ToListAsync();
            return roomsToRemind;
        }

#endregion

        #region GetRoomsToBeVacatedAsync
        public async Task<List<Room>> GetRoomsToBeVacatedAsync(DateTime date)
        {
            // Rooms with a reservation ending on the given date
            var roomsToBeVacated = await _dbSet
                .Where(room =>
                    room.Reservations.Any(r =>
                        r.CheckOutDate.Date == date.Date &&
                        r.status == DataStasus.Active
                    )
                )
                .ToListAsync();
            return roomsToBeVacated;
        }

#endregion

        #region GetVacantRoomsAsync
        public async Task<List<Room>> GetVacantRoomsAsync()
        {
            var today = DateTime.Today;
            // Rooms with no active reservation for today
            var vacantRooms = await _dbSet
                .Where(room =>
                    !room.Reservations.Any(r =>
                        r.CheckInDate <= today && r.CheckOutDate > today && r.status == DataStasus.Active
                    )
                )
                .ToListAsync();
            return vacantRooms;
        }

        public async Task<List<Room>> GetVacantRoomsWithDetailsAsync()
        {
            var today = DateTime.Today;
            // Get rooms with no active reservation for today, including all details and navigation properties
            var vacantRoomsWithDetails = await _dbSet
                .Include(r => r.Reservations)
                .Where(room =>
                    !room.Reservations.Any(res =>
                        res.CheckInDate <= today && res.CheckOutDate > today && res.status == DataStasus.Active
                    )
                )
                .ToListAsync();
            return vacantRoomsWithDetails;
        }
        #endregion
    }

}
