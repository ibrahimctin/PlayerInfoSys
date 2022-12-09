using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PlayerInfoSys.Infrastructure.Implementation.Repositories;
using PlayerInfoSys.Infrastructure.Interfaces.Repositories;
using PlayerInfoSys.Infrastructure.UnitOfWorks;

namespace PlayerInfoSys.Infrastructure.Extensions
{
    public static class InfrastructureLayerExtensions
    {
        public static IServiceCollection LoadDataInfrastructureExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPlayerRepository, PlayerRepository>();
            services.AddScoped<IClubRepository,ClubRepository>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

    }
}
