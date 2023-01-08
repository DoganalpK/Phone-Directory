using MassTransit;
using Report.Microservice.Consumers;

namespace Report.Microservice
{
    public static class ServiceRegistration
    {
        public static void RegisterDependencies(this IServiceCollection services)
        {
            services.AddMassTransit(x =>
            {
                x.AddConsumer<KisiRaporConsumer>();
                x.AddBus(provider => Bus.Factory.CreateUsingRabbitMq(cur =>
                {
                    cur.UseHealthCheck(provider);
                    cur.Host(new Uri("rabbitmq://localhost"), h =>
                    {
                        h.Username("guest");
                        h.Password("guest");
                    });
                    cur.ReceiveEndpoint("reportsQueue", oq =>
                    {
                        oq.PrefetchCount = 20;
                        oq.ConfigureConsumer<KisiRaporConsumer>(provider);
                    });
                }));
            });
            services.AddMassTransitHostedService();
        }
    }
}
