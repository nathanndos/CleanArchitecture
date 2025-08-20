using Domain.Interfaces.Repositorys;
using Domain.Interfaces.Repositorys.BaseRepositoy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.Context;
using Persistence.Repositorys;

namespace Persistence
{
    public static class ServiceExtensions
    {
        public static void configurePersistenceApp(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("Sqlite");
            services.AddDbContext<AppDbContext>(opt => opt.UseSqlite(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
