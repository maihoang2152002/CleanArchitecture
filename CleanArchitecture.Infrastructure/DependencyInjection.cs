using CleanArchitecture.Domain.Interfaces.Repository;
using CleanArchitecture.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IInitModelRepository, InitModelRepository>();

            var cs = configuration.GetConnectionString("Default");
            //services.AddDbContext<CleanArchitectureDbContext>(opt => opt.UseSqlServer(cs));

            services.AddDbContext<CleanArchitectureDbContext>(options =>
                    options.UseSqlite(cs));
            return services;
        }
    }
}
