using MassTransit;
using Newtonsoft.Json;
using Shared.Models.Models;
using System.Text;
using System.Text.Json;

namespace Report.Microservice.Consumers
{
    public class KisiRaporConsumer : IConsumer<Rapor>
    {
        private readonly IHttpClientFactory _clientFactory;

        public KisiRaporConsumer(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task Consume(ConsumeContext<Rapor> context)
        {
            var obj = context.Message;
            var client = _clientFactory.CreateClient();
            var httpContent = new StringContent(JsonConvert.SerializeObject(obj)
                    , Encoding.UTF8, "application/json");
            await client.PostAsync("https://localhost:7088/api/Rapor", httpContent);
            //var jsonData = await response.Content.ReadAsStringAsync();
        }
    }
}
