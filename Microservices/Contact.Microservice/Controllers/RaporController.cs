using MassTransit.Mediator;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Microservice.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class RaporController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RaporController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }

        [HttpGet("{UUID}")]
        public async Task<IActionResult> GetById()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> Add()
        {
            return Ok();
        }
    }
}
