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
    public class EmployeeService:ManagerService<Employee>, IEmployeeService
    {
        public EmployeeService(IManagerRepository<Employee> repository) : base (repository)
        {
            
        }

    }
}
