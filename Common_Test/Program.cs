using DataAccessLayer.Services.Concretes;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System;
using System.Threading.Tasks;
using Bogus;

namespace ConsoleApp
{
    class Program
    {
        static async Task Main(string[] args)
        {

            //    ProjectDatabaseContext context = new ProjectDatabaseContext();

            //    // Repository instance creation
            //    var repository = new ManagerRepository<Room>(context);
            //    var Entity = new Room();
            //    // Test create operation
            //    var newEntity = new Room
            //    {
            //        Id = 53,
            //        RoomNumber = "101",
            //        SelectedStatus = Models.Enums.DataStasus.Active,
            //        CreatedDate = DateTime.Now,
            //        Description = "Test Room",
            //        ImageUrl = "Test Image",

            //    };

            //    await repository.CreateAsync(newEntity);
            //    Console.WriteLine("Entity Created!");

            //    Test GetAll operation
            //   var allEntities = repository.GetAll();
            //    Console.WriteLine($"Total Entities: {allEntities.Count()}");

            //    Test update
            //newEntity.Id = 52;
            //    newEntity.RoomNumber = "101";
            //    newEntity.Description = "Updated Entity";
            //    await repository.UpdateAsync(newEntity);
            //    Console.WriteLine("Entity Updated!");
            //    Entity.Id = repository.UpdateAsync(newEntity).Id;
            //    Console.WriteLine(Entity);

            //    Test Delete operation
            //   await repository.DeleteAsync(newEntity);
            //    Console.WriteLine("Entity Deleted!");

            //    Test Destroy operation
            //   await repository.DestroyAsync(newEntity);
            //    Console.WriteLine("Entity Destroyed!");
            //}
        }
    }
}
