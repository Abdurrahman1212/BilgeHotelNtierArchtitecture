using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Abstracs
{
    public interface IShiftsRepo<T> where T : Shift
    {
        Task<IEnumerable<T>> GetAllShifts();
        Task<T> GetShiftById(int id);
        Task<T> CreateShift(T shift);
        Task<T> UpdateShift(T shift);
        Task<T> DeleteShift(int id);
    }
}
