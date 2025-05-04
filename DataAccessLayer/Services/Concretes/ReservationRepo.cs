using DataAccessLayer.Context;
using DataAccessLayer.Services.Abstracs;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Services.Concretes
{
    public class ReservationRepo:ManagerRepository<Reservation>
    {
        public ReservationRepo(ProjectDatabaseContext context):base(context)
        {

        }
        
    }
}
