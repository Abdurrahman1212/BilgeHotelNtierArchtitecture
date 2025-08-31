using DataAccessLayer.Context;
using DataAccessLayer.Services.Abstracs;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Concretes
{
    public class ReservationRepo : ManagerRepository<Reservation>, IReservationsRepo
    {
        private readonly ProjectDatabaseContext project;
        public ReservationRepo(ProjectDatabaseContext project) : base(project)
        {
            this.project = project;
        }
        /// <summary>
        /// Gets all reservations.
        /// </summary>
        public IEnumerable<Reservation> GetAllReservationsAsync()
        {
            return project.Reservations
                .Include(r => r.Room)
                .Include(r => r.Customer)
                .Include(r => r.Expenses)
                .AsNoTracking()
                .ToList();
        }
        /// <summary>
        /// Gets reservation by ID.
        /// </summary>
        public Reservation GetReservationById(int reservationId)
        {
            return project.Reservations
                .Include(r => r.Room)
                .Include(r => r.Customer)
                .Include(r => r.Expenses)
                .FirstOrDefault(r => r.Id == reservationId);
        }

    }
}
