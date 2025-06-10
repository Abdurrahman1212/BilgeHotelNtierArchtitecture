using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Services.Abstracs
{
    public interface IRoomService:IManagerService<Room>
    {
        Task CreateReservationAsync(Reservation reservation);
        Task<List<Room>> GetRoomsNeedingMaintenanceReminderAsync(DateTime date);

    }
}
