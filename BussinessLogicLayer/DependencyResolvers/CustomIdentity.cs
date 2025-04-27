using DataAccessLayer.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.DependencyResolvers
{
    public static class CustomIdentity
    {
        public static void AddCustomIdentityService(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole<int>>(x =>
            {
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireDigit = false;
                x.Password.RequiredLength = 3;
                x.Password.RequireUppercase = false;
                x.Password.RequireLowercase = false;
                //x.SignIn.RequireConfirmedEmail = true;
                //x.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<ProjectDatabaseContext>()
                .AddDefaultTokenProviders();
                
        }
    }
}
