using DataAccessLayer.Context;
using DataAccessLayer.Services.Abstracs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Concretes
{
    public class ExpenseRepo:ManagerRepository<Expense>
    {
        public ExpenseRepo(ProjectDatabaseContext context):base (context)
        {
            
        }
    }
}
