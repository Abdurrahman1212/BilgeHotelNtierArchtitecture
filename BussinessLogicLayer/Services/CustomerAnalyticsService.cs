using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BussinessLogicLayer.Services
{
    public class PricingManagementService
    {
        private List<EarlyBookingDiscount> _earlyBookingDiscounts;

        public PricingManagementService()
        {
            InitializeEarlyBookingDiscounts();
        }

        private void InitializeEarlyBookingDiscounts()
        {
            _earlyBookingDiscounts = new List<EarlyBookingDiscount>
            {
                // En az 3 ay önce yapılan rezervasyonlarda %23 indirim
                new EarlyBookingDiscount
                {
                    PackageType = PackageType.AllInclusive,
                    DaysInAdvance = 90,
                    DiscountPercentage = 23,
                    EffectiveFrom = DateTime.Now,
                    EffectiveTo = DateTime.Now.AddYears(1),
                    IsActive = true
                },
                new EarlyBookingDiscount
                {
                    PackageType = PackageType.FullBoard,
                    DaysInAdvance = 90,
                    DiscountPercentage = 23,
                    EffectiveFrom = DateTime.Now,
                    EffectiveTo = DateTime.Now.AddYears(1),
                    IsActive = true
                },
                // En az 1 ay önce yapılan herşey dahil rezervasyonlarda %18 indirim
                new EarlyBookingDiscount
                {
                    PackageType = PackageType.AllInclusive,
                    DaysInAdvance = 30,
                    DiscountPercentage = 18,
                    EffectiveFrom = DateTime.Now,
                    EffectiveTo = DateTime.Now.AddYears(1),
                    IsActive = true
                },
                // En az 1 ay önce yapılan tam pansiyon rezervasyonlarda %16 indirim
                new EarlyBookingDiscount
                {
                    PackageType = PackageType.FullBoard,
                    DaysInAdvance = 30,
                    DiscountPercentage = 16,
                    EffectiveFrom = DateTime.Now,
                    EffectiveTo = DateTime.Now.AddYears(1),
                    IsActive = true
                }
            };
        }

        public decimal CalculatePriceWithEarlyBookingDiscount(Room room, PackageType packageType, DateTime checkInDate, DateTime bookingDate)
        {
            var daysInAdvance = (checkInDate - bookingDate).Days;

            // Uygulanabilir erken rezervasyon indirimini bul
            var applicableDiscount = _earlyBookingDiscounts
                .Where(d => d.PackageType == packageType && d.IsActive)
                .Where(d => d.EffectiveFrom <= bookingDate && d.EffectiveTo >= bookingDate)
                .Where(d => daysInAdvance >= d.DaysInAdvance)
                .OrderByDescending(d => d.DaysInAdvance)
                .FirstOrDefault();

            // Temel fiyatı al
            decimal basePrice = packageType == PackageType.AllInclusive ?
                room.AllInclusivePricePerNight : room.BasePricePerNight;

            if (applicableDiscount != null)
            {
                // İndirim uygula
                var discountAmount = basePrice * (applicableDiscount.DiscountPercentage / 100);
                return basePrice - discountAmount;
            }

            return basePrice;
        }

        public decimal CalculateTotalPrice(Room room, PackageType packageType, DateTime checkInDate, DateTime checkOutDate, DateTime bookingDate)
        {
            var nights = (checkOutDate - checkInDate).Days;
            var pricePerNight = CalculatePriceWithEarlyBookingDiscount(room, packageType, checkInDate, bookingDate);

            return pricePerNight * nights;
        }

        public EarlyBookingDiscount GetEarlyBookingDiscount(PackageType packageType, int daysInAdvance, DateTime bookingDate)
        {
            return _earlyBookingDiscounts
                .Where(d => d.PackageType == packageType && d.IsActive)
                .Where(d => d.EffectiveFrom <= bookingDate && d.EffectiveTo >= bookingDate)
                .Where(d => daysInAdvance >= d.DaysInAdvance)
                .OrderByDescending(d => d.DaysInAdvance)
                .FirstOrDefault();
        }

        public List<EarlyBookingDiscount> GetAllEarlyBookingDiscounts()
        {
            return _earlyBookingDiscounts.Where(d => d.IsActive).ToList();
        }

        public void UpdateEarlyBookingDiscount(EarlyBookingDiscount discount)
        {
            var existing = _earlyBookingDiscounts.FirstOrDefault(d => d.Id == discount.Id);
            if (existing != null)
            {
                existing.PackageType = discount.PackageType;
                existing.DaysInAdvance = discount.DaysInAdvance;
                existing.DiscountPercentage = discount.DiscountPercentage;
                existing.EffectiveFrom = discount.EffectiveFrom;
                existing.EffectiveTo = discount.EffectiveTo;
                existing.IsActive = discount.IsActive;
            }
        }

        public void AddEarlyBookingDiscount(EarlyBookingDiscount discount)
        {
            discount.Id = _earlyBookingDiscounts.Any() ? _earlyBookingDiscounts.Max(d => d.Id) + 1 : 1;
            _earlyBookingDiscounts.Add(discount);
        }
    }

    public class CustomerAnalyticsService
    {
        public CustomerVisitSummary GetCustomerVisitSummary(Customer customer)
        {
            return new CustomerVisitSummary
            {
                CustomerId = customer.Id,
                CustomerName = $"{customer.FirstName} {customer.LastName}",
                FirstVisitDate = customer.FirstVisitDate,
                LastVisitDate = customer.LastVisitDate,
                TotalVisits = customer.TotalVisits,
                TotalNightsStayed = customer.TotalNightsStayed,
                TotalSpent = customer.TotalSpent,
                IsVIPCustomer = customer.IsVIPCustomer,
                AverageSpendingPerNight = customer.TotalVisits > 0 ? customer.TotalSpent / customer.TotalVisits : 0,
                AverageStayDuration = customer.TotalVisits > 0 ? customer.TotalNightsStayed / customer.TotalVisits : 0
            };
        }

        public List<Customer> GetVIPCustomers(List<Customer> customers)
        {
            return customers.Where(c => c.IsVIPCustomer).ToList();
        }

        public List<Customer> GetRepeatCustomers(List<Customer> customers)
        {
            return customers.Where(c => c.TotalVisits > 1).ToList();
        }

        public List<Customer> GetCustomersByRoom(int roomId, List<Customer> customers)
        {
            return customers.Where(c =>
                c.Reservations.Any(r => r.RoomId == roomId)
            ).ToList();
        }

        public CustomerOccupancyInfo GetCurrentRoomOccupancy(int roomId, DateTime date)
        {
            // Bu kısım veritabanından gerçek rezervasyonları kontrol edecek
            // Şimdilik örnek veri döndürüyoruz
            return new CustomerOccupancyInfo
            {
                RoomId = roomId,
                RoomNumber = $"Room {roomId}",
                CurrentOccupants = new List<CustomerOccupant>(),
                IsOccupied = false,
                CheckInDate = null,
                CheckOutDate = null
            };
        }
    }

    public class CustomerVisitSummary
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime? FirstVisitDate { get; set; }
        public DateTime? LastVisitDate { get; set; }
        public int TotalVisits { get; set; }
        public int TotalNightsStayed { get; set; }
        public decimal TotalSpent { get; set; }
        public bool IsVIPCustomer { get; set; }
        public decimal AverageSpendingPerNight { get; set; }
        public decimal AverageStayDuration { get; set; }
    }

    public class CustomerOccupancyInfo
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; }
        public List<CustomerOccupant> CurrentOccupants { get; set; }
        public bool IsOccupied { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
    }

    public class CustomerOccupant
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string IdentityNumber { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
    }
}
