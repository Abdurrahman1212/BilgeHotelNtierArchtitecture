using Models.Entities;
using Models.Enums;
using System;
using System.Collections.Generic;

namespace BussinessLogicLayer.Services
{
    public class RoomInitializationService
    {
        public List<Room> InitializeHotelRooms()
        {
            var rooms = new List<Room>();

            // 1. Kat: 10 tek kişilik + 10 üç kişilik
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(CreateSingleRoom(100 + i, 1));
            }
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(CreateTripleRoom(130 + i, 1));
            }

            // 2. Kat: 10 tek kişilik + 10 iki kişilik
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(CreateSingleRoom(200 + i, 2));
            }
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(CreateDoubleRoom(220 + i, 2));
            }

            // 3. Kat: 10 iki kişilik + 10 üç kişilik
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(CreateDoubleRoom(300 + i, 3));
            }
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(CreateTripleRoom(320 + i, 3));
            }

            // 4. Kat: 10 iki kişilik + 6 dört kişilik + 1 kral dairesi
            for (int i = 1; i <= 10; i++)
            {
                rooms.Add(CreateDoubleRoom(400 + i, 4));
            }
            for (int i = 1; i <= 6; i++)
            {
                rooms.Add(CreateQuadrupleRoom(420 + i, 4));
            }
            rooms.Add(CreateKingSuiteRoom(426, 4));

            return rooms;
        }

        private Room CreateSingleRoom(int roomNumber, int floor)
        {
            return new Room
            {
                RoomNumber = roomNumber,
                Floor = floor,
                RoomCapacity = 1,
                BedCount = 1,
                BasePricePerNight = 300, // Tam pansiyon fiyatı
                AllInclusivePricePerNight = 400, // Herşey dahil fiyatı
                Type = RoomType.Single,
                HasBalcony = floor >= 3, // 3. ve 4. katlarda balkon var
                HasMinibar = false, // Tek kişilik odalarda minibar yok
                HasAirConditioning = true,
                HasTV = true,
                HasHairDryer = true,
                HasWiFi = true,
                Status = RoomStatus.Empty,
                DataStatus = DataStasus.Active,
                Description = $"Tek kişilik standart oda - {floor}. kat",
                ImageUrl = $"/images/rooms/single_{floor}_{roomNumber}.jpg"
            };
        }

        private Room CreateDoubleRoom(int roomNumber, int floor)
        {
            return new Room
            {
                RoomNumber = roomNumber,
                Floor = floor,
                RoomCapacity = 2,
                BedCount = 1, // Duble yatak
                BasePricePerNight = 500,
                AllInclusivePricePerNight = 650,
                Type = RoomType.Double,
                HasBalcony = floor >= 3,
                HasMinibar = true,
                HasAirConditioning = true,
                HasTV = true,
                HasHairDryer = true,
                HasWiFi = true,
                Status = RoomStatus.Empty,
                DataStatus = DataStasus.Active,
                Description = $"İki kişilik duble oda - {floor}. kat",
                ImageUrl = $"/images/rooms/double_{floor}_{roomNumber}.jpg"
            };
        }

        private Room CreateTripleRoom(int roomNumber, int floor)
        {
            return new Room
            {
                RoomNumber = roomNumber,
                Floor = floor,
                RoomCapacity = 3,
                BedCount = 3, // Bir tek, bir duble yatak
                BasePricePerNight = 700,
                AllInclusivePricePerNight = 900,
                Type = RoomType.Triple,
                HasBalcony = floor >= 3,
                HasMinibar = true,
                HasAirConditioning = true,
                HasTV = true,
                HasHairDryer = true,
                HasWiFi = true,
                Status = RoomStatus.Empty,
                DataStatus = DataStasus.Active,
                Description = $"Üç kişilik oda - {floor}. kat",
                ImageUrl = $"/images/rooms/triple_{floor}_{roomNumber}.jpg"
            };
        }

        private Room CreateQuadrupleRoom(int roomNumber, int floor)
        {
            return new Room
            {
                RoomNumber = roomNumber,
                Floor = floor,
                RoomCapacity = 4,
                BedCount = 3, // Bir duble, iki tek yatak
                BasePricePerNight = 900,
                AllInclusivePricePerNight = 1200,
                Type = RoomType.Quadruple,
                HasBalcony = true, // 4. katta balkon var
                HasMinibar = true,
                HasAirConditioning = true,
                HasTV = true,
                HasHairDryer = true,
                HasWiFi = true,
                Status = RoomStatus.Empty,
                DataStatus = DataStasus.Active,
                Description = $"Dört kişilik aile odası - {floor}. kat",
                ImageUrl = $"/images/rooms/quadruple_{floor}_{roomNumber}.jpg"
            };
        }

        private Room CreateKingSuiteRoom(int roomNumber, int floor)
        {
            return new Room
            {
                RoomNumber = roomNumber,
                Floor = floor,
                RoomCapacity = 2,
                BedCount = 1, // King size yatak
                BasePricePerNight = 1500,
                AllInclusivePricePerNight = 2000,
                Type = RoomType.KingSuite,
                HasBalcony = true,
                HasMinibar = true,
                HasAirConditioning = true,
                HasTV = true,
                HasHairDryer = true,
                HasWiFi = true,
                Status = RoomStatus.Empty,
                DataStatus = DataStasus.Active,
                Description = $"Kral dairesi - {floor}. kat",
                ImageUrl = $"/images/rooms/kingsuite_{floor}_{roomNumber}.jpg"
            };
        }
    }
}
