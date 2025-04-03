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
    public class ReservationRepo<T> : IReservationsRepo<T> where T : Reservation
    {
        private readonly ProjectDatabaseContext _context;
        private readonly DbSet<T> _reservations;
        public ReservationRepo(ProjectDatabaseContext context)
        {
            _context = context;
            _reservations = _context.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            _reservations.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task CreateRangeAsync(List<T> entities)
        {
            _reservations.AddRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAllAsync(List<T> entities)
        {
            foreach (var entity in entities)
            {
                entity.SelectedStatus = Models.Enums.DataStasus.Passive;
                entity.UpdatedDate = DateTime.Now;
                entity.UpdatedComputerName = System.Environment.MachineName;
            }
            _reservations.UpdateRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            entity.SelectedStatus = Models.Enums.DataStasus.Passive;
            entity.UpdatedDate = DateTime.Now;
            entity.UpdatedComputerName = System.Environment.MachineName;
            await _context.SaveChangesAsync();
        }

        public async Task DestroyAsync(T entity)
        {
            _reservations.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DestroyRangeAsync(List<T> entities)
        {
            _reservations.RemoveRange(entities);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                var entries = ex.Entries;
                var databaseValues = await entries[0].GetDatabaseValuesAsync();
                if (databaseValues == null)
                {
                    Console.WriteLine("The entity deleted by another user..");
                }
                else
                {
                    Console.WriteLine("The entity updated by another user..");
                    foreach (var entry in entries)
                    {
                        entry.OriginalValues.SetValues(databaseValues);
                    }
                }
            }
        }

        public IQueryable<T> GetActives()
        {
            return _reservations.Where(x => x.SelectedStatus == Models.Enums.DataStasus.Active);
        }

        public IQueryable<T> GetAll()   
        {
            return _reservations;
        }

        public T GetById(int id)
        {
            return _reservations.FirstOrDefault(x=>x.Id==id);
        }

        public IQueryable<T> GetPassives()
        {
            return _reservations.Where(x => x.SelectedStatus == Models.Enums.DataStasus.Passive);
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(List<T> entities)
        {
            throw new NotImplementedException();
        }
    }
}
