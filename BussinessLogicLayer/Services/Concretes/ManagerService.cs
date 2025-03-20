using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Contracts.Interfaces;
using Models.Abstracts;
using Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ManagerService<T> : IManagerService<T> where T : BaseEntity
    {
        protected readonly IManagerRepository<T> _roomRepo;

        public ManagerService(IManagerRepository<T> roomRepo)
        {
            _roomRepo = roomRepo;
        }

        public async Task CreateAsync(T entity)
        {
            await _roomRepo.CreateAsync(entity);
        }

        public async Task CreateRangeAsync(List<T> entities)
        {
            await _roomRepo.CreateRangeAsync(entities);
        }

        public async Task DeleteAllAsync(List<T> entities)
        {
            await _roomRepo.DeleteAllAsync(entities);
        }

        public async Task DeleteAsync(T entity)
        {
            await _roomRepo.DeleteAsync(entity);
        }

        public async Task DestroyAsync(T entity)
        {
            await _roomRepo.DestroyAsync(entity);
        }

        public async Task DestroyRangeAsync(List<T> entities)
        {
            await _roomRepo.DestroyRangeAsync(entities);
        }

        public IEnumerable<T> GetActives()
        {
            return _roomRepo.GetActives();
        }

        public IEnumerable<T> GetAll()
        {
            return _roomRepo.GetAll();
        }

        public T GetById(int id)
        {
            return _roomRepo.GetById(id);
        }

        public IEnumerable<T> GetPassives()
        {
            return _roomRepo.GetPassives();
        }

        public async Task UpdateAsync(T entity)
        {
            await _roomRepo.UpdateAsync(entity);
        }
        public async Task UpdateRangeAsync(List<T> entities)
        {
            await _roomRepo.UpdateRangeAsync(entities);
        }
    }
}
