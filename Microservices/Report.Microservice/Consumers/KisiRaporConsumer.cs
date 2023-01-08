using MassTransit;
using Shared.Models.Models;

namespace Report.Microservice.Consumers
{
    public class KisiRaporConsumer : IConsumer<Rapor>
    {
        public async Task Consume(ConsumeContext<Rapor> context)
        {
            await Task.Run(() =>
            {
                var obj = context.Message;
            });
        }
    }
}
