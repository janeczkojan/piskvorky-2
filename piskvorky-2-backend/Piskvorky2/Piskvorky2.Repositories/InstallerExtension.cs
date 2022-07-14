using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piskvorky2.Repositories.Services;

namespace Piskvorky2.Repositories
{
    public static class InstallerExtension
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IPlayersRepository, PlayersRepository>();
            services.AddScoped<IGamesRepository, GamesRepository>();
        }
    }
}
