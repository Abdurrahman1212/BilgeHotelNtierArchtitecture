using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BussinessLogicLayer.Services
{
    public class ExtraChargesService
    {
        public ExtraCharge AddExtraCharge(int reservationId, int customerId, ExtraChargeType chargeType, string description, decimal amount, int quantity = 1, int employeeId = 0)
        {
            var extraCharge = new ExtraCharge
            {
                ReservationId = reservationId,
                CustomerId = customerId,
                ChargeType = chargeType,
                Description = description,
                Amount = amount,
                Quantity = quantity,
                ChargeDate = DateTime.Now,
                IsPaid = false,
                CreatedByEmployeeId = employeeId
            };

            // Burada veritabanına kaydetme işlemi yapılacak
            // Şimdilik örnek ID ataması
            extraCharge.Id = new Random().Next(1, 10000);

            return extraCharge;
        }

        public List<ExtraCharge> GetExtraChargesByReservation(int reservationId)
        {
            // Bu kısım veritabanından rezervasyonun ekstra harcamalarını getirecek
            // Şimdilik örnek veri döndürüyoruz
            return new List<ExtraCharge>
            {
                new ExtraCharge
                {
                    Id = 1,
                    ReservationId = reservationId,
                    CustomerId = 1,
                    ChargeType = ExtraChargeType.Minibar,
                    Description = "Minibar - 2 adet su, 1 adet meyve suyu",
                    Amount = 25.50m,
                    Quantity = 1,
                    ChargeDate = DateTime.Now,
                    IsPaid = false
                },
                new ExtraCharge
                {
                    Id = 2,
                    ReservationId = reservationId,
                    CustomerId = 1,
                    ChargeType = ExtraChargeType.RoomService,
                    Description = "Oda servisi - Hamburger menü",
                    Amount = 45.00m,
                    Quantity = 1,
                    ChargeDate = DateTime.Now,
                    IsPaid = false
                }
            };
        }

        public CheckoutSummary GenerateCheckoutSummary(int reservationId)
        {
            // Rezervasyon bilgilerini al
            var reservation = GetReservationById(reservationId);
            if (reservation == null)
                throw new ArgumentException("Rezervasyon bulunamadı");

            // Ekstra harcamaları al
            var extraCharges = GetExtraChargesByReservation(reservationId);

            // Ana ücretleri hesapla
            var roomTotal = CalculateRoomTotal(reservation);
            var packageTotal = CalculatePackageTotal(reservation);

            // Ekstra harcamaları topla
            var extraChargesTotal = extraCharges.Sum(ec => ec.TotalAmount);

            // Varsayılan vergi oranı
            var taxRate = 0.08m; // %8 KDV
            var taxAmount = (roomTotal + packageTotal + extraChargesTotal) * taxRate;

            var summary = new CheckoutSummary
            {
                ReservationId = reservationId,
                CustomerId = reservation.CustomerId,
                RoomTotal = roomTotal,
                PackageTotal = packageTotal,
                ExtraChargesTotal = extraChargesTotal,
                ExtraCharges = extraCharges,
                TaxAmount = taxAmount,
                TaxRate = taxRate,
                CheckoutDate = DateTime.Now,
                IsPaid = false,
                ProcessedByEmployeeId = 1 // Geçici olarak 1. çalışan
            };

            return summary;
        }

        public bool ProcessCheckout(CheckoutSummary summary, Models.Entities.PaymentMethod paymentMethod)
        {
            try
            {
                // Tüm ekstra harcamaları ödenmiş olarak işaretle
                foreach (var charge in summary.ExtraCharges)
                {
                    charge.IsPaid = true;
                    charge.PaidDate = DateTime.Now;
                }

                // Ödeme işlemini kaydet
                summary.PaymentMethod = paymentMethod;
                summary.IsPaid = true;
                summary.PaidDate = DateTime.Now;

                return true;
            }
            catch (Exception ex)
            {
                // Log the error
                Console.WriteLine($"Checkout error: {ex.Message}");
                return false;
            }
        }

        private Reservation GetReservationById(int reservationId)
        {
            // Bu kısım veritabanından rezervasyon bilgilerini getirecek
            // Şimdilik örnek veri döndürüyoruz
            return new Reservation
            {
                Id = reservationId,
                CustomerId = 1,
                RoomId = 1,
                CheckInDate = DateTime.Now.AddDays(-3),
                CheckOutDate = DateTime.Now,
                PackageType = PackageType.FullBoard,
                TotalAmount = 1500
            };
        }

        private decimal CalculateRoomTotal(Reservation reservation)
        {
            // Oda ücretini hesapla
            var nights = (reservation.CheckOutDate - reservation.CheckInDate).Days;
            var pricingService = new PricingService();

            // Oda bilgilerini al
            var roomInitService = new RoomInitializationService();
            var rooms = roomInitService.InitializeHotelRooms();
            var room = rooms.FirstOrDefault(r => r.Id == reservation.RoomId);

            if (room != null)
            {
                return pricingService.CalculatePricePerNight(room, reservation.PackageType) * nights;
            }

            return 0;
        }

        private decimal CalculatePackageTotal(Reservation reservation)
        {
            // Paket ücretini hesapla
            var nights = (reservation.CheckOutDate - reservation.CheckInDate).Days;
            var pricingService = new PricingService();

            // Oda bilgilerini al
            var roomInitService = new RoomInitializationService();
            var rooms = roomInitService.InitializeHotelRooms();
            var room = rooms.FirstOrDefault(r => r.Id == reservation.RoomId);

            if (room != null)
            {
                return pricingService.CalculatePricePerNight(room, reservation.PackageType) * nights;
            }

            return 0;
        }

        public string GetChargeTypeDescription(ExtraChargeType chargeType)
        {
            return chargeType switch
            {
                ExtraChargeType.Minibar => "Minibar",
                ExtraChargeType.RoomService => "Oda Servisi",
                ExtraChargeType.Laundry => "Çamaşırhane",
                ExtraChargeType.SpaService => "SPA Hizmeti",
                ExtraChargeType.Restaurant => "Restoran",
                ExtraChargeType.Phone => "Telefon",
                ExtraChargeType.Internet => "İnternet",
                ExtraChargeType.Parking => "Otopark",
                ExtraChargeType.Other => "Diğer",
                _ => "Bilinmiyor"
            };
        }

        public List<string> GetAvailableChargeTypes()
        {
            return Enum.GetValues(typeof(ExtraChargeType))
                .Cast<ExtraChargeType>()
                .Select(GetChargeTypeDescription)
                .ToList();
        }
    }
}
