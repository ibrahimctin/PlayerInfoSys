namespace PlayerInfoSys.API.Extensions
{
    public static class EntityFrameworkExtensions
    {
        public static IServiceCollection LoadEntityFrameworkExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("CbrConnn"));

            });

          


            return services;
        }
    }
}
