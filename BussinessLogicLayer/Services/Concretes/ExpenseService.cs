using BusinessLogicLayer.Services;
using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Contracts.Interfaces;
using DataAccessLayer.Services.Concretes;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Services.Concretes
{
    public class ExpenseService : ManagerService<Expense>, IExpenseService
    {
        public ExpenseService(IManagerRepository<Expense> manager):base(manager)
        {
            
        }
    }
}
