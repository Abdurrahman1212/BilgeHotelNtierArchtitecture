using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data.FakeData
{
    public class PaymentFakeData
    {
        public int Id { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; }

        public static List<PaymentFakeData> GetFakePayments()
        {
            return new List<PaymentFakeData>
            {
                new PaymentFakeData { Id = 1, PaymentMethod = "Credit Card", Amount = 120.50m, PaymentDate = DateTime.Now.AddDays(-5), Status = "Completed" },
                new PaymentFakeData { Id = 2, PaymentMethod = "PayPal", Amount = 75.00m, PaymentDate = DateTime.Now.AddDays(-2), Status = "Pending" },
                new PaymentFakeData { Id = 3, PaymentMethod = "Bank Transfer", Amount = 200.00m, PaymentDate = DateTime.Now.AddDays(-10), Status = "Failed" },
                new PaymentFakeData { Id = 4, PaymentMethod = "Credit Card", Amount = 50.00m, PaymentDate = DateTime.Now.AddDays(-1), Status = "Completed" },
                new PaymentFakeData { Id = 5, PaymentMethod = "Cash", Amount = 30.00m, PaymentDate = DateTime.Now, Status = "Completed" }
            };
        }
    }
}
