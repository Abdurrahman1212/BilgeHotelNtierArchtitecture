using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using Bogus;
using Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer.Data.FakeData
{
    public static class RoomFakeData
    {

        public static List<Room> GetFakeRoom()
        {
            var faker = new Faker();
            List<Room> roomList = new List<Room>();
            int totalRooms = 50;
            for (int i = 0; i < totalRooms; i++)
            {
                var room = new Room()
                {
                    MasterId = Guid.NewGuid().ToString(),
                    Id=i+1,
                    RoomNumber = (i + 1).ToString(),
                    Floor = (i % 5) + 1,
                    Description = faker.Lorem.Sentence(5),
                    RoomCapacity = (i % 5) + 1,
                    PricePerNight = faker.Finance.Amount(1500, 2500),
                    HasBalcony = (i % 5 == 0) ? false : true,
                    HasAirConditioning = i % 1 == 0,
                    HasHairDryer = i % 1 == 0,
                    HasMinibar = i % 1 == 0,
                    HasTV = i % 1 == 0,
                    RoomBreakfast = (i % 5 == 0) ? false : true,
                    HasWiFi = i % 1 == 0,
                    RoomType = (RoomType)(i % Enum.GetValues(typeof(RoomType)).Length),
                    DataStasus = (DataStasus)(i % Enum.GetValues(typeof(DataStasus)).Length),
                    ImageUrl = faker.Image.PicsumUrl()
                };
                roomList.Add(room);
            }

            return roomList;
        }
    }
}












