using BusinessLogicLayer.Services;
using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Context;
using DataAccessLayer.Contracts.Interfaces;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Services.Concretes
{
    public class ReservationService : ManagerService<Reservation>, IReservationService
    {
        private readonly ProjectDatabaseContext _context;
   
        public ReservationService(ProjectDatabaseContext context,IManagerRepository<Reservation> repository): base(repository)
        {
            _context = context;
        }
        public IEnumerable<Reservation> GetReservationsByCustomerId(int customerId)
        {
            return _context.Reservations.Where(r => r.CustomerId == customerId).ToList();
        }

        public bool IsRoomReserved(int roomId, DateTime checkInDate, DateTime checkOutDate)
        {
            return _context.Reservations.Any(r =>
                r.RoomId == roomId &&
                r.CheckOutDate > checkInDate &&
                r.CheckInDate < checkOutDate);
        }

        public Reservation GetReservation(int reservationId)
        {
            return _context.Reservations.FirstOrDefault(r => r.Id == reservationId);
        }

        public Reservation CreateReservation(DateTime checkInDate, DateTime checkOutDate)
        {
            var fixedCheckIn = checkInDate.Date.AddHours(14);   // 14:00
            var fixedCheckOut = checkOutDate.Date.AddHours(10); // 10:00

            var reservation = new Reservation
            {
                CheckInDate = fixedCheckIn,
                CheckOutDate = fixedCheckOut,
                // diğer alanlar
            };
            // Kaydetme işlemleri
            return reservation;
        }
    }


}

