using Microsoft.EntityFrameworkCore;
using RoomControlsApi.Models.DataSeedExtensions;
using RoomControlsApi.Models.Entities;

namespace RoomControlsApi.Models.ContextClasses
{
    public class MyContext(DbContextOptions<MyContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        public DbSet<RoomsControl> RoomInfo { get; set; }
    }
}
