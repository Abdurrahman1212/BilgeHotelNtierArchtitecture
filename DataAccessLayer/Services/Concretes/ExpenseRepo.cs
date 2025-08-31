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
    public class ExpenseRepo : ManagerRepository<Expense>, IExpenseRepo
    {
        private readonly ProjectDatabaseContext project;
        public ExpenseRepo(ProjectDatabaseContext project) : base(project)
        {
            this.project = project;
        }
        /// <summary>
        /// Gets all expenses for a specific reservation.
        /// </summary>
        public IEnumerable<Expense> GetAllExpensesByReservationId(int reservationId)
        {
            return project.Expenses
                .Where(e => e.ReservationId == reservationId)
                .ToList();
        }
        /// <summary>
        /// Gets an expense by its ID.
        /// </summary>
        public Expense GetExpenseById(int expense)
        {
            return project.Expenses
                .FirstOrDefault(e => e.Id == expense);
        }


    }
}
