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
