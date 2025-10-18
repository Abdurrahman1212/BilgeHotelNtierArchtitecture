using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BussinessLogicLayer.Services
{
    public class PricingService
    {
        public decimal CalculateTotalPrice(Room room, PackageType packageType, int nights, DateTime checkInDate)
        {
            decimal basePrice = 0;

            // Paket tipine göre fiyat belirleme
            switch (packageType)
            {
                case PackageType.FullBoard:
                    basePrice = room.BasePricePerNight;
                    break;
                case PackageType.AllInclusive:
                    basePrice = room.AllInclusivePricePerNight;
                    break;
            }

            decimal totalPrice = basePrice * nights;

            // İnternet üzerinden rezervasyon indirimi (checkInDate web'den geliyorsa)
            if (IsOnlineReservation(checkInDate))
            {
                totalPrice *= 0.9m; // %10 indirim
            }

            return Math.Round(totalPrice, 2);
        }

        public decimal CalculatePricePerNight(Room room, PackageType packageType)
        {
            switch (packageType)
            {
                case PackageType.FullBoard:
                    return room.BasePricePerNight;
                case PackageType.AllInclusive:
                    return room.AllInclusivePricePerNight;
                default:
                    return room.BasePricePerNight;
            }
        }

        public List<Room> GetAvailableRooms(List<Room> allRooms, DateTime checkInDate, DateTime checkOutDate)
        {
            return allRooms.Where(room =>
                room.IsAvailable &&
                !IsRoomOccupied(room, checkInDate, checkOutDate)
            ).ToList();
        }

        private bool IsRoomOccupied(Room room, DateTime checkInDate, DateTime checkOutDate)
        {
            // Bu kısım veritabanından rezervasyonları kontrol edecek
            // Şimdilik basit bir kontrol
            return room.Reservations?.Any(r =>
                (r.CheckInDate < checkOutDate && r.CheckOutDate > checkInDate) &&
                r.ReservationStatus != ReservationStatus.Cancelled
            ) ?? false;
        }

        private bool IsOnlineReservation(DateTime checkInDate)
        {
            // Web rezervasyonları için kontrol - bu kısım geliştirilecek
            // Şimdilik basit bir tarih kontrolü
            return checkInDate > DateTime.Now.AddDays(1);
        }

        public List<string> GetRoomFeatures(Room room)
        {
            var features = new List<string>();

            if (room.HasAirConditioning) features.Add("Klima");
            if (room.HasTV) features.Add("TV");
            if (room.HasHairDryer) features.Add("Saç Kurutma Makinesi");
            if (room.HasWiFi) features.Add("Kablosuz İnternet");
            if (room.HasBalcony) features.Add("Balkon");
            if (room.HasMinibar) features.Add("Minibar");

            return features;
        }

        public string GetRoomTypeDescription(RoomType roomType)
        {
            switch (roomType)
            {
                case RoomType.Single:
                    return "Tek Kişilik";
                case RoomType.Double:
                    return "İki Kişilik (Duble)";
                case RoomType.Triple:
                    return "Üç Kişilik";
                case RoomType.Quadruple:
                    return "Dört Kişilik";
                case RoomType.KingSuite:
                    return "Kral Dairesi";
                default:
                    return "Bilinmiyor";
            }
        }
    }
}
