using BusinessLogicLayer.Services;
using BussinessLogicLayer.Services.Abstracs;
using DataAccessLayer.Contracts.Interfaces;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.Services.Concretes
{
    public class ShiftService : ManagerService<Shift>, IShiftService
    {
        public ShiftService(IManagerRepository<Shift> shiftRepo) : base(shiftRepo)
        {
        }
    }
}
