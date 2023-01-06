using Contact.Microservice.Models.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Contact.Microservice
{
    public static class ServiceRegistration
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("PostgresDb"));
            });
        }
    }
}
