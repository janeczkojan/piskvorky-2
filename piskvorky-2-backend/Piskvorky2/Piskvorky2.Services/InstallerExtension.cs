using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piskvorky2.Repositories;
using Piskvorky2.Services.Services;

namespace Piskvorky2.Services
{
    public static class InstallerExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepositories();

            services.AddScoped<IGameService, GameService>();
        }
    }
}