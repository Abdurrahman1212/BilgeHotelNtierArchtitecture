using DataAccessLayer.Contracts.Interfaces;
using DataAccessLayer.Data.FakeData;
using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Abstracs
{
    public interface IRoomRepo : IManagerRepository<Room>
    {
        // ...existing methods...

        /// <summary>
        /// Calculates the total price for a room based on room type, package type, and number of days.
        /// </summary>
        /// <param name="roomType">The type of the room.</param>
        /// <param name="packageType">The package type selected by the customer.</param>
        /// <param name="numberOfDays">The number of days for the stay.</param>
        /// <returns>The calculated total price.</returns>
        decimal CalculateRoomPrice(Models.Enums.RoomType roomType, PackageType packageType, int numberOfDays);
        /// <summary>
        /// Room Maintaince Reminder
        Task<List<Room>> GetRoomsNeedingMaintenanceReminderAsync(DateTime date);
        Task<List<Room>> GetRoomsToBeVacatedAsync(DateTime date);
        Task<List<Room>> GetVacantRoomsAsync();
        Task<List<Room>> GetVacantRoomsWithDetailsAsync();
        Task UpdateRoom(Room OriginalRoom,Room UpdatedRoom);
    }
}
