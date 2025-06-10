using DataAccessLayer.Configurations;
using DataAccessLayer.Context;
using DataAccessLayer.Contracts.Interfaces;
using DataAccessLayer.Data.FakeData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models.Abstracts;
using Models.Entities;
using Models.Enums;
using Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Concretes
{
    public class ManagerRepository<T> : IManagerRepository<T> where T : class , IEntity
    {
        private readonly ProjectDatabaseContext _context;
        private readonly DbSet<T> _dbSet;

        public ManagerRepository(ProjectDatabaseContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        T IManagerRepository<T>.GetById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public IQueryable<T> GetActives()
        {
            return _dbSet.Where(x => x.SelectedStatus == Models.Enums.DataStasus.Inserted);
        }

        public IQueryable<T> GetPassives()
        {
            return _dbSet.Where(x => x.SelectedStatus == Models.Enums.DataStasus.Updated);
        }

        public async Task CreateAsync(T entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task CreateRangeAsync(List<T> entities)
        {
            _dbSet.AddRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            entity.UpdatedComputerName = System.Environment.MachineName;

            T originalEntity = _dbSet.FirstOrDefault(x => x.Id == entity.Id);

            if (originalEntity != null)
            {
                _context.Entry(originalEntity).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task UpdateRangeAsync(List<T> entities)
        {
            foreach (var entity in entities)
            {
                await UpdateAsync(entity);
            }
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            entity.SelectedStatus = Models.Enums.DataStasus.Active;
            entity.UpdatedDate = DateTime.Now;
            await UpdateAsync(entity);
        }

        public async Task DeleteAllAsync(List<T> entities)
        {
            entities.RemoveAll(x => x.SelectedStatus == DataStasus.Passive);
            _dbSet.RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async Task DestroyAsync(T entity)
        {
            _dbSet.Remove(entity);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                // Handle the concurrency conflict
                var entry = ex.Entries.Single();
                var databaseValues = await entry.GetDatabaseValuesAsync();
                if (databaseValues == null)
                {
                    // The entity was deleted by another user
                    Console.WriteLine("The entity was deleted by another user.");
                }
                else
                {
                    // The entity was updated by another user
                    Console.WriteLine("The entity was updated by another user.");
                    entry.OriginalValues.SetValues(databaseValues);
                }
            }
        }

        public async Task DestroyRangeAsync(List<T> entities)
        {
            foreach (var entity in entities)
            {
                await DestroyAsync(entity);
            }
            await _context.SaveChangesAsync();
        }


    }
}
