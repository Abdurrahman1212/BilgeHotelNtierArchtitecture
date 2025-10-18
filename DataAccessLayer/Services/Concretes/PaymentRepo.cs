using DataAccessLayer.Configurations.Context;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Enums;

namespace DataAccessLayer.Services.Concretes
{
    public class PaymentRepo : ManagerRepository<Payment>
    {
        private readonly ProjectDatabaseContext _context;

        public PaymentRepo(ProjectDatabaseContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Payment> CreatePaymentAsync(Payment payment)
        {
            await _context.Payments.AddAsync(payment);
            await _context.SaveChangesAsync();
            return payment;
        }

        public async Task<Payment> UpdatePaymentAsync(Payment payment)
        {
            _context.Payments.Update(payment);
            await _context.SaveChangesAsync();
            return payment;
        }

        public async Task<Payment> DeletePaymentAsync(Payment payment)
        {
            _context.Payments.Remove(payment);
            await _context.SaveChangesAsync();
            return payment;
        }

        public async Task<List<Payment>> GetPaymentsByReservationIdAsync(int reservationId)
        {
            return _context.Payments
                .Where(p => p.ReservationId == reservationId)
                .ToList();
        }

        public async Task<List<Payment>> GetPaymentsByCustomerIdAsync(int customerId)
        {
            return _context.Payments
                .Include(p => p.Reservation)
                .Where(p => p.Reservation.CustomerId == customerId)
                .ToList();
        }

        public async Task<List<Payment>> GetPaymentsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return _context.Payments
                .Where(p => p.PaymentDate >= startDate && p.PaymentDate <= endDate)
                .ToList();
        }
    }
}
