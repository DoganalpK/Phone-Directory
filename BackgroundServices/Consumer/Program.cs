using MassTransit;
using Shared.Models.Models;
public class KisiRaporConsumer : IConsumer<Rapor>
{
    public async Task Consume(ConsumeContext<Rapor> context)
    {
        await Task.Run(() =>
        {
            var obj = context.Message;
            return Task.CompletedTask;
        });
    }
}