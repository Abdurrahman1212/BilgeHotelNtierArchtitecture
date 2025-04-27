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
namespace BussinessLogicLayer.Services.Concretes
{
    public class RoomService : ManagerService<Room>, IRoomService
    {
        private readonly ProjectDatabaseContext _context;
        public RoomService(IManagerRepository<Room> repository,ProjectDatabaseContext context) : base(repository)
        {
            _context = context;
        }
        public async Task CreateReservationAsync(Reservation reservation)
        {
            await _context.Reservations.AddAsync(reservation);
            await _context.SaveChangesAsync();
        }




    }
}
