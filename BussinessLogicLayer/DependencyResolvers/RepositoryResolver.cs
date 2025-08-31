using DataAccessLayer.Contracts.Interfaces;
using DataAccessLayer.Services.Abstracs;
using DataAccessLayer.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.DependencyResolvers
{
    public static class RepositoryResolver
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IManagerRepository<>), typeof(ManagerRepository<>));
            services.AddScoped(typeof(IRoomRepo), typeof(RoomRepo));
            services.AddScoped(typeof(ICustomerRepo), typeof(CustomerRepo));
            services.AddScoped(typeof(IEmployeeRepo), typeof(EmployeeRepo));




        }
    }
}
