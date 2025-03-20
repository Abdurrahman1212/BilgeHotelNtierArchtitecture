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
        Task<IEnumerable<T>> GetAllExpenses();
        Task<T> GetExpenseById(int id);
        Task<T> CreateExpense(T expense);
        Task<T> UpdateExpense(T expense);
        Task<T> DeleteExpense(int id);
    }
}
