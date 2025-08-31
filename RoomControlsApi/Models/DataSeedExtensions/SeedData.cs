using DataAccessLayer.Data.FakeData;
using Microsoft.EntityFrameworkCore;
using RoomControlsApi.Models.Entities;

namespace RoomControlsApi.Models.DataSeedExtensions
{
    public static class DataSeedExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomsControl>().HasData(RoomFakeData.GenerateRooms()
            );

        }
    }
}
