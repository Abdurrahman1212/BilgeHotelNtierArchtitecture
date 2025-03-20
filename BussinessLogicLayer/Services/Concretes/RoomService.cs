using BusinessLogicLayer.Services;
using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Contracts.Interfaces;
using Models.Entities;
using DataAccessLayer.Data.FakeData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.HttpResults;
namespace BussinessLogicLayer.Services.Concretes
{
    public class RoomService : ManagerService<Room>, IRoomService
    {
        public RoomService(IManagerRepository<Room> repository) : base(repository)
        {

        }

       

       
    }
}
