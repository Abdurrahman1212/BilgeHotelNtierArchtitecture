using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogicLayer.DependencyResolvers
{
    public static class DbContextResolver
    {
        public static void AddDbContextService(this IServiceCollection services)
        {
            //Neden ServiceProvider

            //Cünkü biz bu noktada aslında Core.MVC platformundaki startup dosyasında degiliz...Dolayısıyla oradaki hazır service yapısı elimizde yok...Biz o ayarları ayaga kaldırmak adına bir giriş noktasına ihtiyac duyarız...Ve bu giriş noktasını bize ServiceProvider nesnesi saglar...
            ServiceProvider provider = services.BuildServiceProvider();

            IConfiguration? configuration = provider.GetService<IConfiguration>();

            services.AddDbContext<ProjectDatabaseContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
