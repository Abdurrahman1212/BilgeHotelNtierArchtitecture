using DataAccessLayer.Configurations.Context;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Enums;

namespace DataAccessLayer.Services.Concretes
{
    public class ExtraChargeRepo : ManagerRepository<ExtraCharge>
    {
        private readonly ProjectDatabaseContext _context;

        public ExtraChargeRepo(ProjectDatabaseContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ExtraCharge> CreateExtraChargeAsync(ExtraCharge extraCharge)
        {
            await _context.ExtraCharges.AddAsync(extraCharge);
            await _context.SaveChangesAsync();
            return extraCharge;
        }

        public async Task<ExtraCharge> UpdateExtraChargeAsync(ExtraCharge extraCharge)
        {
            _context.ExtraCharges.Update(extraCharge);
            await _context.SaveChangesAsync();
            return extraCharge;
        }

        public async Task<ExtraCharge> DeleteExtraChargeAsync(ExtraCharge extraCharge)
        {
            _context.ExtraCharges.Remove(extraCharge);
            await _context.SaveChangesAsync();
            return extraCharge;
        }

        public async Task<List<ExtraCharge>> GetExtraChargesByReservationIdAsync(int reservationId)
        {
            return await _context.ExtraCharges
                .Where(ec => ec.ReservationId == reservationId)
                .Include(ec => ec.Customer)
                .Include(ec => ec.CreatedByEmployee)
                .ToListAsync();
        }

        public async Task<List<ExtraCharge>> GetExtraChargesByCustomerIdAsync(int customerId)
        {
            return await _context.ExtraCharges
                .Where(ec => ec.CustomerId == customerId)
                .Include(ec => ec.Reservation)
                .ToListAsync();
        }

        public async Task<List<ExtraCharge>> GetUnpaidExtraChargesAsync()
        {
            return await _context.ExtraCharges
                .Where(ec => !ec.IsPaid)
                .Include(ec => ec.Customer)
                .Include(ec => ec.Reservation)
                .ToListAsync();
        }

        public async Task<List<ExtraCharge>> GetExtraChargesByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.ExtraCharges
                .Where(ec => ec.ChargeDate >= startDate && ec.ChargeDate <= endDate)
                .Include(ec => ec.Customer)
                .Include(ec => ec.Reservation)
                .ToListAsync();
        }

        public async Task<decimal> GetTotalExtraChargesByReservationAsync(int reservationId)
        {
            return _context.ExtraCharges
                .Where(ec => ec.ReservationId == reservationId)
                .Sum(ec => ec.TotalAmount);
        }
    }
}
