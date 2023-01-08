using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Models.Models;

namespace Contact.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KisiRaporController : ControllerBase
    {
        private readonly IBus _busService;

        public KisiRaporController(IBus busService)
        {
            _busService = busService;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRapor(Rapor model)
        {
            Uri uri = new Uri("rabbitmq://localhost/reportsQueue");
            var endPoint = await _busService.GetSendEndpoint(uri);
            await endPoint.Send(model);
            return Ok();
        }
    }
}
