using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Reserva.Domain.Interfaces;
using Reserva.Infra.Data.Context;

namespace Reserva.Infra.IoC{

    public static class InjecaoDependencia {
        
        public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration){
            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"), 
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IHotelRepositorio, HotelRepositorio>();

            return services;
        }

    }
}