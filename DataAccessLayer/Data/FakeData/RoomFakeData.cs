using System;
using System.Collections.Generic;
using Models.Entities;
using Bogus;
using Models.Enums;
using static System.Net.WebRequestMethods;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Data.FakeData
{
    public static class RoomFakeData
    {
        public static List<Room> GenerateRooms()
        {
            var rooms = new List<Room>();
            int roomNumber = 100;
            int id = 1;

            // 1st Floor: 10 Single, 10 Triple (3 single beds)
            for (int i = 0; i < 10; i++)
            {
                var room = CreateRoom(++roomNumber, 1, RoomType.Single, 1, hasMinibar: false, hasBalcony: false);
                room.Id = id++;
                room.RoomNumber = roomNumber;
                room.Floor = 1;
                room.Description = $"Room {roomNumber} - Single, Floor 1";
                room.ImageUrl = $"https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg";
                room.RoomCapacity = 1;
                room.RoomBreakfast = false;
                room.PricePerNight = 100m;
                room.HasBalcony = false;
                room.HasMinibar = false;
                room.Type = (Models.Enums.RoomType)RoomType.Single;
                room.PackageType = PackageType.FullBoard;
                room.HasAirConditioning = true;
                room.HasTV = true;
                room.HasHairDryer = true;
                room.HasWiFi = true;
                room.DataStasus = DataStasus.Inserted;
                room.Reservations = new List<Reservation>();
                rooms.Add(room);
            }
            for (int i = 0; i < 10; i++)
            {
                var room = CreateRoom(++roomNumber, 1, RoomType.TripleSingle, 3, hasMinibar: true, hasBalcony: false);
                room.Id = id++;
                room.RoomNumber = roomNumber;
                room.Floor = 1;
                room.Description = $"Room {roomNumber} - Triple (3 single beds), Floor 1";
                room.ImageUrl = $"https://www.louisfitzgeraldhotel.com/wp-content/uploads/2020/03/hotel-louis-fitzgerald-082-1366x768-fp_mm-fpoff_0_0.jpg";
                room.RoomCapacity = 3;
                room.RoomBreakfast = false;
                room.PricePerNight = 180m;
                room.HasBalcony = false;
                room.HasMinibar = true;
                room.Type = Models.Enums.RoomType.Triple;
                room.PackageType = PackageType.AllIncluesive;
                room.HasAirConditioning = true;
                room.HasTV = true;
                room.HasHairDryer = true;
                room.HasWiFi = true;
                room.DataStasus = DataStasus.Inserted;
                room.Reservations = new List<Reservation>();
                rooms.Add(room);
            }

            // 2nd Floor: 10 Single, 10 Double (2 single beds)
            for (int i = 0; i < 10; i++)
            {
                var room = CreateRoom(++roomNumber, 2, RoomType.Single, 1, hasMinibar: false, hasBalcony: false);
                room.Id = id++;
                room.RoomNumber = roomNumber;
                room.Floor = 2;
                room.Description = $"Room {roomNumber} - Single, Floor 2";
                room.ImageUrl = "https://rushotel.com.tr/wp-content/uploads/2019/07/r3.jpg";
                room.RoomCapacity = 1;
                room.RoomBreakfast = false;
                room.PricePerNight = 110m;
                room.HasBalcony = false;
                room.HasMinibar = false;
                room.Type = Models.Enums.RoomType.Single;
                room.PackageType = PackageType.FullBoard;
                room.HasAirConditioning = true;
                room.HasTV = true;
                room.HasHairDryer = true;
                room.HasWiFi = true;
                room.DataStasus = DataStasus.Inserted;
                room.Reservations = new List<Reservation>();
                rooms.Add(room);
            }
            for (int i = 0; i < 10; i++)
            {
                var room = CreateRoom(++roomNumber, 2, RoomType.DoubleSingle, 2, hasMinibar: true, hasBalcony: false);
                room.Id = id++;
                room.RoomNumber = roomNumber;
                room.Floor = 2;
                room.Description = $"Room {roomNumber} - Double (2 single beds), Floor 2";
                room.ImageUrl = $"https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png";
                room.RoomCapacity = 2;
                room.RoomBreakfast = false;
                room.PricePerNight = 150m;
                room.HasBalcony = false;
                room.HasMinibar = true;
                room.Type = Models.Enums.RoomType.Double;
                room.PackageType = PackageType.AllIncluesive;
                room.HasAirConditioning = true;
                room.HasTV = true;
                room.HasHairDryer = true;
                room.HasWiFi = true;
                room.DataStasus = DataStasus.Inserted;
                room.Reservations = new List<Reservation>();
                rooms.Add(room);
            }

            // 3rd Floor: 10 Double (double bed), 10 Triple (1 single, 1 double bed) - All with balcony
            for (int i = 0; i < 10; i++)
            {
                var room = CreateRoom(++roomNumber, 3, RoomType.Double, 2, hasMinibar: true, hasBalcony: true);
                room.Id = id++;
                room.RoomNumber = roomNumber;
                room.Floor = 3;
                room.Description = $"Room {roomNumber} - Double (double bed), Floor 3";
                room.ImageUrl = $"https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg";
                room.RoomCapacity = 2;
                room.RoomBreakfast = true;
                room.PricePerNight = 170m;
                room.HasBalcony = true;
                room.HasMinibar = true;
                room.Type = Models.Enums.RoomType.Double;
                room.PackageType = PackageType.AllIncluesive;
                room.HasAirConditioning = true;
                room.HasTV = true;
                room.HasHairDryer = true;
                room.HasWiFi = true;
                room.DataStasus = DataStasus.Inserted;
                room.Reservations = new List<Reservation>();
                rooms.Add(room);
            }
            for (int i = 0; i < 10; i++)
            {
                var room = CreateRoom(++roomNumber, 3, RoomType.TripleMixed, 3, hasMinibar: true, hasBalcony: true);
                room.Id = id++;
                room.RoomNumber = roomNumber;
                room.Floor = 3;
                room.Description = $"Room {roomNumber} - Triple (1 double, 1 single), Floor 3";
                room.ImageUrl = $"https://winhotelsgroup.nl/properties/dam-hotel-amsterdam/images/rooms/triple-room-with-private-bathroom/triple-room-with-private-bathroom-6.jpg";
                room.RoomCapacity = 3;
                room.RoomBreakfast = true;
                room.PricePerNight = 200m;
                room.HasBalcony = true;
                room.HasMinibar = true;
                room.Type = Models.Enums.RoomType.Triple;
                room.PackageType = PackageType.AllIncluesive;
                room.HasAirConditioning = true;
                room.HasTV = true;
                room.HasHairDryer = true;
                room.HasWiFi = true;
                room.DataStasus = DataStasus.Inserted;
                room.Reservations = new List<Reservation>();
                rooms.Add(room);
            }

            // 4th Floor: 10 Double (double bed), 6 Quad (1 double, 2 single), 1 King Suite - All with balcony
            for (int i = 0; i < 10; i++)
            {
                var room = CreateRoom(++roomNumber, 4, RoomType.Double, 2, hasMinibar: true, hasBalcony: true);
                room.Id = id++;
                room.RoomNumber = roomNumber;
                room.Floor = 4;
                room.Description = $"Room {roomNumber} - Double (double bed), Floor 4";
                room.ImageUrl = $"https://roomraccoon.com/wp-content/uploads/2024/06/2-1.png";
                room.RoomCapacity = 2;
                room.RoomBreakfast = true;
                room.PricePerNight = 180m;
                room.HasBalcony = true;
                room.HasMinibar = true;
                room.Type = Models.Enums.RoomType.Double;
                room.PackageType = PackageType.AllIncluesive;
                room.HasAirConditioning = true;
                room.HasTV = true;
                room.HasHairDryer = true;
                room.HasWiFi = true;
                room.DataStasus = DataStasus.Inserted;
                room.Reservations = new List<Reservation>();
                rooms.Add(room);
            }
            for (int i = 0; i < 6; i++)
            {
                var room = CreateRoom(++roomNumber, 4, RoomType.Quad, 4, hasMinibar: true, hasBalcony: true);
                room.Id = id++;
                room.RoomNumber = roomNumber;
                room.Floor = 4;
                room.Description = $"Room {roomNumber} - Quad (1 double, 2 single), Floor 4";
                room.ImageUrl = $"https://setarehhotel.com/wp-content/uploads/2018/03/QuadRoom01.jpg";
                room.RoomCapacity = 4;
                room.RoomBreakfast = true;
                room.PricePerNight = 250m;
                room.HasBalcony = true;
                room.HasMinibar = true;
                room.Type = Models.Enums.RoomType.Quadruple;
                room.PackageType = PackageType.AllIncluesive;
                room.HasAirConditioning = true;
                room.HasTV = true;
                room.HasHairDryer = true;
                room.HasWiFi = true;
                room.DataStasus = DataStasus.Inserted;
                room.Reservations = new List<Reservation>();
                rooms.Add(room);
            }
            var kingSuite = CreateRoom(++roomNumber, 4, RoomType.KingSuite, 5, hasMinibar: true, hasBalcony: true);
            kingSuite.Id = id++;
            kingSuite.RoomNumber = roomNumber;
            kingSuite.Floor = 4;
            kingSuite.Description = $"Room {roomNumber} - King Suite, Floor 4";
            kingSuite.ImageUrl = $"https://calista.com.tr/media/xaug4yos/calista-resort-hotel-blog-king-suit-banner.jpg";
            kingSuite.RoomCapacity = 5;
            kingSuite.RoomBreakfast = true;
            kingSuite.PricePerNight = 500m;
            kingSuite.HasBalcony = true;
            kingSuite.HasMinibar = true;
            kingSuite.Type = Models.Enums.RoomType.KingSuite;
            kingSuite.PackageType = PackageType.AllIncluesive;
            kingSuite.HasAirConditioning = true;
            kingSuite.HasTV = true;
            kingSuite.HasHairDryer = true;
            kingSuite.HasWiFi = true;
            kingSuite.DataStasus = DataStasus.Inserted;
            kingSuite.Reservations = new List<Reservation>();
            rooms.Add(kingSuite);

            return rooms;
        }

        private static Room CreateRoom(int number, int floor, RoomType type, int capacity, bool hasMinibar, bool hasBalcony)
        {
            var faker = new Faker();
            return new Room
            {
                RoomNumber = number,
                Floor = floor,
                Type = (Models.Enums.RoomType)type,
                RoomCapacity = capacity,
                HasMinibar = hasMinibar,
                HasBalcony = hasBalcony,
                HasAirConditioning = true,
                HasTV = true,
                HasHairDryer = true,
                HasWiFi = true,
                PackageType = PackageType.FullBoard,
                Description = "",
                ImageUrl = "",
                RoomBreakfast = false,
                PricePerNight = 0m,
                DataStasus = DataStasus.Inserted,
                Reservations = new List<Reservation>()
            };
        }
    }

    // Example enums for RoomType and RoomPackage
    public enum RoomType
    {
        Single,
        Double,
        DoubleSingle, // 2 single beds
        TripleSingle, // 3 single beds
        TripleMixed,  // 1 double + 1 single
        Quad,         // 1 double + 2 single
        KingSuite
    }

    public enum RoomPackage
    {
        FullBoard,
        AllInclusive
    }
}
