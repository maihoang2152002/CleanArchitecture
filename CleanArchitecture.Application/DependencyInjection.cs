using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using CleanArchitecture.Application.InitModel.Commands;
using CleanArchitecture.Application.InitModel.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using CleanArchitecture.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace CleanArchitecture.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAppAndInfraDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            var assembly = typeof(DependencyInjection).Assembly;

            services.AddMediatR(configuration =>
                configuration.RegisterServicesFromAssembly(assembly));

            services.AddValidatorsFromAssembly(assembly);
            services.AddInfrastructure(configuration);

            return services;
        }
    }
}
