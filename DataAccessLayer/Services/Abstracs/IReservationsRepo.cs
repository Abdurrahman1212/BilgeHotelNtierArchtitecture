using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Abstracs
{
    public interface IReservationsRepo<T> where T : Reservation
    {
        Task<IEnumerable<T>> GetAllReservations();
        Task<T> GetReservationById(int id);
        Task<T> CreateReservation(T reservation);
        Task<T> UpdateReservation(T reservation);
        Task<T> DeleteReservation(int id);
    }
}
