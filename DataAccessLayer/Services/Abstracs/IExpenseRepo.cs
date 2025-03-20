using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Abstracs
{
    public interface IExpenseRepo<T> where T : Expense
    {
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
