using Microsoft.Extensions.DependencyInjection;
using rm_api.Application.Solicitations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rm_api.DependencyInjection
{
    public static class ServicesProvider
    {
        public static void Configuration(IServiceCollection services)
        {
           
            services.AddTransient<ISolicitationService, SolicitationService>();
        }
    }
}
