using DataAccessLayer.Services.Abstracs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Concretes
{
    public class ExpenseRepo<T> : IExpenseRepo<T> where T : Expense
    {
        public Task<T> CreateExpense(T expense)
        {
            throw new NotImplementedException();
        }

        public Task<T> DeleteExpense(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllExpenses()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetExpenseById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateExpense(T expense)
        {
            throw new NotImplementedException();
        }
    }
}
