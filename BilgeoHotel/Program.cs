using BusinessLogicLayer.Services;
using BussinessLogicLayer.Services.Abstracs;
using BussinessLogicLayer.Services.Concretes;
using DataAccessLayer.Context;
using DataAccessLayer.Contracts.Interfaces;
using DataAccessLayer.Services.Concretes;
using Microsoft.EntityFrameworkCore;
using Models.Entities;
using Swashbuckle.AspNetCore.SwaggerUI;
using Swashbuckle.AspNetCore.Swagger;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped(typeof(IManagerRepository<>), typeof(ManagerRepository<>));
builder.Services.AddScoped(typeof(IRoomService), typeof(RoomService));
builder.Services.AddScoped(typeof(IManagerService<>), typeof(ManagerService<>));
IServiceCollection serviceCollection = builder.Services.AddDbContext<ProjectDatabaseContext>(opt => opt.UseSqlServer("DefaultConnection"));
builder.Services.AddControllersWithViews();
builder.Services.AddSwaggerGen();
var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

// Enable middleware to serve generated Swagger as a JSON endpoint.

// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), specifying the Swagger JSON endpoint.

app.UseRouting();

app.UseAuthorization();
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllerRoute(
    name: "Areas",
    pattern: "{Area:exists}/{controller=Home}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}",
    defaults: new { controller = "Home", action = "Index" }
);

//todo: Custom endpoint anlatýlcak.

app.Run();
