using Contact.Microservice.Models.DbContexts;
using Contact.Microservice.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Contact.Microservice
{
    public static class ServiceRegistration
    {
        public static void RegisterDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            var assmb = Assembly.GetExecutingAssembly();

            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("PostgresDb"));
            });

            services.AddScoped(typeof(IGenericRepository<>),typeof(GenericRepository<>));
            services.AddAutoMapper(assmb);
            services.AddMediatR(assmb);
        }
    }
}
