using Contact.Microservice.Models.DbContexts;
using Contact.Microservice.Repository;
using MassTransit;
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

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddAutoMapper(assmb);
            services.AddMediatR(assmb);

            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseNpgsql(configuration.GetConnectionString("PostgresDb"));
            });

            services.AddCors(opt =>
            {
                opt.AddPolicy("GlobalCORS", config =>
                {
                    config.AllowAnyHeader().AllowAnyMethod();
                });
            });

            services.AddMassTransit(x =>
            {
                x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(config =>
                {
                    config.UseHealthCheck(provider);
                    config.Host(new Uri("rabbitmq://localhost"), h =>
                    {
                        h.Username("guest");
                        h.Password("guest");
                    });
                }));
            });
            services.AddMassTransitHostedService();            
        }
    }
}
