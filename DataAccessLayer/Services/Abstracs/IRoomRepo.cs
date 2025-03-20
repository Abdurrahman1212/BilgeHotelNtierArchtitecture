using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Abstracs
{
    public interface IRoomRepo<T> where T : Room
    {
        Task<IEnumerable<T>> GetAllRooms();
        Task<T> GetRoomById(int id);
        Task<T> CreateRoom(T room);
        Task<T> UpdateRoom(T room);
        Task<T> DeleteRoom(int id);
    }
}
