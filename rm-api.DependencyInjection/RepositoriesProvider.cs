using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using rm_api.Domain;
using rm_api.Domain.Solicitations.Interfaces;
using rm_api.infra.repositories.Base;
using rm_api.infra.repositories.Solicitations;
using System;
using System.Collections.Generic;
using System.Text;

namespace rm_api.DependencyInjection
{
   public  class RepositoriesProvider
    {
        public static void Configuration(IServiceCollection services, IConfiguration configuration)
        {

            services.AddTransient<ISolicitationsRepository, SolicitationsRepository>();
            services.AddScoped(serviceProvider => new ConnectionManager(configuration.GetConnectionString("DevConnection")));

            services.AddScoped<IUnitOfWork>(serviceProvider => serviceProvider.GetService<ConnectionManager>());

            services.AddScoped<IConnectionManager>(serviceProvider =>
               serviceProvider.GetService<ConnectionManager>());


        }
    }
}
