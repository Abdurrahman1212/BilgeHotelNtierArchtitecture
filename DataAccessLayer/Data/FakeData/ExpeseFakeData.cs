using Bogus;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.FakeData
{
    public class ExpeseFakeData
    {
        public static List<Expense> Expenses()
        {
            Faker faker = new Faker();
            List<Expense> expenses = new List<Expense>();
            for (int i = 0; i < 10; i++)
            {
                Expense expense = new Expense
                {
                    MasterId = Guid.NewGuid().ToString(),
                    Id = i + 1,
                    ExpenseName = faker.Commerce.ProductName(),
                    ExpenseAmount = faker.Finance.Amount(),
                    ExpenseDate = faker.Date.Past(),
                    ExpenseDescription = faker.Lorem.Sentence(),
                    ExpenseStatus = Models.Enums.DataStasus.Active,
                    ReservationId = faker.Random.Int(1,10),
                };
                expenses.Add(expense);
            }

            return expenses;
        }


    }
}


