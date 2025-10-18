using BussinessLogicLayer.DependencyResolvers;
using BussinessLogicLayer.Services.Abstracs;
using BussinessLogicLayer.Services.Concretes;
using DataAccessLayer.Configurations.Context;
using DataAccessLayer.Contracts.Interfaces;
using DataAccessLayer.Services.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace AdminDesktopApp
{
    public static class DependencyInjection
    {
        public static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            
            // Add DbContext
            services.AddDbContext<ProjectDatabaseContext>(options =>
                options.UseSqlServer("Server=your_server;Database=your_database;Trusted_Connection=True;"));
            
            // Add Forms (simplified for now)
            services.AddTransient<MainForm>();
            services.AddTransient<ReservationManagementForm>();
            services.AddTransient<RoomManagementForm>();
            services.AddTransient<CustomerManagementForm>();
            services.AddTransient<EmployeeManagementForm>();
            services.AddTransient<ReportsForm>();
            services.AddTransient<SettingsForm>();
            
            return services.BuildServiceProvider();
        }
    }
}
