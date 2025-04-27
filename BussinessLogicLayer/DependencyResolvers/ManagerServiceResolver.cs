using BusinessLogicLayer.Services;
using BussinessLogicLayer.Services.Abstracs;
using BussinessLogicLayer.Services.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.DependencyResolvers
{
    public static class ManagerServiceResolver
    {
        public static void AddManagerServices(this IServiceCollection services)
        {
            services.AddScoped(typeof(IManagerService<>), typeof(ManagerService<>));
            services.AddScoped<IRoomService, RoomService>();
        }
    }
}
