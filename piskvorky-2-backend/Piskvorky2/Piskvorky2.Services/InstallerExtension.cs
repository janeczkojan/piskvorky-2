using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Piskvorky2.Repositories;
using Piskvorky2.Services.Services;
using AutoMapper;

namespace Piskvorky2.Services
{
    public static class InstallerExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepositories();

            services.AddAutoMapperWithProfiles();

            services.AddScoped<IGameService, GameService>();
        }

        private static void AddAutoMapperWithProfiles(this IServiceCollection services)
        {
            var config = new MapperConfiguration(cfg => 
            {
                cfg.AddProfile(new MapperProfiles());
            });

            var mapper = config.CreateMapper();

            services.AddSingleton(mapper);
        }
    }
}