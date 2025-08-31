using DataAccessLayer.Context;
using DataAccessLayer.Services.Abstracs;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Concretes
{
    public class ShiftRepo : ManagerRepository<Shift>, IShiftsRepo
    {
        public ShiftRepo(ProjectDatabaseContext context):base (context)
        {
            
        }
    }
}
