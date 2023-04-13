namespace PlayerInfoSys.Domain.Application.Extensions
{
    public static class ApplicationLayerExtensions
    {
        public static IServiceCollection LoadDataApplicationExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IClubService, ClubService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>),
                typeof(ValidationBehavior<,>));
            services.AddScoped(typeof(IPipelineBehavior<,>),
                typeof(LoggingBehavior<,>));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
