using INFRASTRUCTURE.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace APPLICATION.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration) =>
            services.AddDbContext<TaskManagementSystemDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SqlDbConnection"));
            });
    }
}
