using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Contracts.Interfaces;
using DataAccessLayer.Services.Abstracs;
using Microsoft.AspNetCore.Identity;
using Models.Abstracts;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using BusinessLogicLayer.Services;
using DataAccessLayer.Context;

namespace BussinessLogicLayer.Services.Concretes
{
    public class UserService : ManagerService<User>, IUserService
    {
        private readonly ProjectDatabaseContext _context;
        public UserService(ProjectDatabaseContext project,IManagerRepository<User> repository) : base(repository)
        {
            _context = project;

        }

        public IEnumerable<User> GetUsersById(int UserId)
        {
          return _context.Users.Where(x => x.Id == UserId).ToList();    
        }
    }
}
