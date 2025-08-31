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
    public class RoomRepo(ProjectDatabaseContext context) : ManagerRepository<Room>(context), IRoomRepo
    {

        public decimal CalculateRoomPrice(Models.Enums.RoomType roomType, Models.Enums.PackageType packageType, int numberOfDays)
        {
            if (numberOfDays <= 0)
                throw new ArgumentException("Number of days must be greater than zero.", nameof(numberOfDays));

            // Base price per night by room type
            decimal basePricePerNight = roomType switch
            {
                Models.Enums.RoomType.Single => 100m,
                Models.Enums.RoomType.Double => 150m,
                Models.Enums.RoomType.Triple => 160m,
                Models.Enums.RoomType.Quadruple => 200m,
                Models.Enums.RoomType.KingSuite => 400m,
                _ => 100m
            };

            // Package multiplier
            decimal packageMultiplier = packageType switch
            {
                Models.Enums.PackageType.FullBoard => 1.0m,
                Models.Enums.PackageType.AllInclusive => 1.3m,
                _ => 1.0m
            };

            decimal totalPrice = basePricePerNight * packageMultiplier * numberOfDays;
            return totalPrice;
        }

        #region GetRoomsNeedingMaintenanceReminderAsync
        public async Task<List<Room>> GetRoomsNeedingMaintenanceReminderAsync(DateTime date)
        {
            var roomsToRemind = await context.Rooms
                .Where(room =>
                    room.Reservations.Any(r =>
                        r.CheckOutDate.Date == date.Date &&
                        r.status == Models.Enums.DataStasus.Active
                    )
                    ||
                    !room.Reservations.Any(r =>
                        r.CheckInDate <= date && r.CheckOutDate > date && r.status == Models.Enums.DataStasus.Active
                    )
                )
                .ToListAsync();
            return roomsToRemind;
        }
        #endregion

        #region GetRoomsToBeVacatedAsync
        public async Task<List<Room>> GetRoomsToBeVacatedAsync(DateTime date)
        {
            var roomsToBeVacated = await context.Rooms
                .Where(room =>
                    room.Reservations.Any(r =>
                        r.CheckOutDate.Date == date.Date &&
                        r.status == Models.Enums.DataStasus.Active
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
            var vacantRooms = await context.Rooms
                .Where(room =>
                    !room.Reservations.Any(r =>
                        r.CheckInDate <= today && r.CheckOutDate > today && r.status == Models.Enums.DataStasus.Active
                    )
                )
                .ToListAsync();
            return vacantRooms;
        }

        public async Task<List<Room>> GetVacantRoomsWithDetailsAsync()
        {
            var today = DateTime.Today;
            var vacantRoomsWithDetails = await context.Rooms
                .Include(r => r.Reservations)
                .Where(room =>
                    !room.Reservations.Any(res =>
                        res.CheckInDate <= today && res.CheckOutDate > today && res.ReservationStatus == Models.Enums.ReservationStatus.Canceled
                    )
                )
                .ToListAsync();
            return vacantRoomsWithDetails;
        }

        public async Task UpdateRoom(Room OriginalRoom, Room UpdatedRoom)
        {
            if (UpdatedRoom.RoomNumber != default && OriginalRoom.RoomNumber != UpdatedRoom.RoomNumber)
                OriginalRoom.RoomNumber = UpdatedRoom.RoomNumber;

            if (UpdatedRoom.Floor != default && OriginalRoom.Floor != UpdatedRoom.Floor)
                OriginalRoom.Floor = UpdatedRoom.Floor;

            if (!string.IsNullOrWhiteSpace(UpdatedRoom.Description) && OriginalRoom.Description != UpdatedRoom.Description)
                OriginalRoom.Description = UpdatedRoom.Description;

            if (!string.IsNullOrWhiteSpace(UpdatedRoom.ImageUrl) && OriginalRoom.ImageUrl != UpdatedRoom.ImageUrl)
                OriginalRoom.ImageUrl = UpdatedRoom.ImageUrl;

            if (UpdatedRoom.RoomCapacity != default && OriginalRoom.RoomCapacity != UpdatedRoom.RoomCapacity)
                OriginalRoom.RoomCapacity = UpdatedRoom.RoomCapacity;

            // For bools, update only if different (since default is false)
            if (OriginalRoom.RoomBreakfast != UpdatedRoom.RoomBreakfast)
                OriginalRoom.RoomBreakfast = UpdatedRoom.RoomBreakfast;

            if (UpdatedRoom.PricePerNight != default && OriginalRoom.PricePerNight != UpdatedRoom.PricePerNight)
                OriginalRoom.PricePerNight = UpdatedRoom.PricePerNight;

            if (OriginalRoom.HasBalcony != UpdatedRoom.HasBalcony)
                OriginalRoom.HasBalcony = UpdatedRoom.HasBalcony;

            if (OriginalRoom.HasMinibar != UpdatedRoom.HasMinibar)
                OriginalRoom.HasMinibar = UpdatedRoom.HasMinibar;

            if (OriginalRoom.Type != UpdatedRoom.Type)
                OriginalRoom.Type = UpdatedRoom.Type;

            if (OriginalRoom.PackageType != UpdatedRoom.PackageType)
                OriginalRoom.PackageType = UpdatedRoom.PackageType;

            if (OriginalRoom.HasAirConditioning != UpdatedRoom.HasAirConditioning)
                OriginalRoom.HasAirConditioning = UpdatedRoom.HasAirConditioning;

            if (OriginalRoom.HasTV != UpdatedRoom.HasTV)
                OriginalRoom.HasTV = UpdatedRoom.HasTV;

            if (OriginalRoom.HasHairDryer != UpdatedRoom.HasHairDryer)
                OriginalRoom.HasHairDryer = UpdatedRoom.HasHairDryer;

            if (OriginalRoom.HasWiFi != UpdatedRoom.HasWiFi)
                OriginalRoom.HasWiFi = UpdatedRoom.HasWiFi;

            if (OriginalRoom.DataStasus != UpdatedRoom.DataStasus)
                OriginalRoom.DataStasus = UpdatedRoom.DataStasus;

            // Reservations: update only if not null and different
            if (UpdatedRoom.Reservations != null && !ReferenceEquals(OriginalRoom.Reservations, UpdatedRoom.Reservations))
                OriginalRoom.Reservations = UpdatedRoom.Reservations;

            // BaseEntity properties
            if (UpdatedRoom.UpdatedDate != default && OriginalRoom.UpdatedDate != UpdatedRoom.UpdatedDate)
                OriginalRoom.UpdatedDate = UpdatedRoom.UpdatedDate;

            if (UpdatedRoom.SelectedStatus != default && OriginalRoom.SelectedStatus != UpdatedRoom.SelectedStatus)
                OriginalRoom.SelectedStatus = UpdatedRoom.SelectedStatus;

            if (!string.IsNullOrWhiteSpace(UpdatedRoom.UpdatedComputerName) && OriginalRoom.UpdatedComputerName != UpdatedRoom.UpdatedComputerName)
                OriginalRoom.UpdatedComputerName = UpdatedRoom.UpdatedComputerName;

            await context.SaveChangesAsync();
        }
        #endregion
    }

}
