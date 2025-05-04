using Models.Abstracts;
using Models.Entities;
using Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Contracts.Interfaces
{
    public interface IManagerRepository<T> where T :  IEntity
    {
        //IEnumerable
    
        //IEnumerable<T> GetFakeRooms();
        T GetById(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetActives();
        IQueryable<T> GetPassives();
        Task CreateAsync(T entity);
        Task CreateRangeAsync(List<T> entities);
        Task UpdateAsync(T entity);
        Task UpdateRangeAsync(List<T> entities);
        Task DeleteAsync(T entity);
        Task DeleteAllAsync(List<T> entities);
        Task DestroyAsync(T entity);
        Task DestroyRangeAsync(List<T> entities);
    }
}
