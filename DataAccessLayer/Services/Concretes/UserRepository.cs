using DataAccessLayer.Context;
using DataAccessLayer.Contracts.Interfaces;
using DataAccessLayer.Services.Abstracs;
using DataAccessLayer.Services.Concretes;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Repositories
{
    public class UserRepository:ManagerRepository<User>
    {
        public UserRepository(ProjectDatabaseContext context):base(context)
        {

        }
        
            
        
    }
}
