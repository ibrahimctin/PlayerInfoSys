using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlayerInfoSys.Domain.Application.Implementation;
using PlayerInfoSys.Domain.Application.Interfaces;

namespace PlayerInfoSys.Domain.Application.Extensions
{
    public static class ApplicationLayerExtensions
    {
        public static IServiceCollection LoadDataApplicationExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IClubService, ClubService>();
           

            return services;
        }
    }
}
