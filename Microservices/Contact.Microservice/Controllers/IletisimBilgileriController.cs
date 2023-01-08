using Contact.Microservice.Features.CQRS.Commands;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Microservice.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class IletisimBilgileriController : ControllerBase
    {
        private readonly IMediator _mediator;

        public IletisimBilgileriController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CreateIletisimBilgileriCommandRequest model)
        {
            return Ok(await _mediator.Send(model));
        }

        [HttpDelete]
        public async Task<IActionResult> Remove([FromBody]RemoveIletisimBilgileriCommandRequest model)
        {
            return Ok(await _mediator.Send(model));
        }
    }
}
