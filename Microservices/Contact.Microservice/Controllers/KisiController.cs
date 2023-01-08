using Contact.Microservice.Features.CQRS.Commands;
using Contact.Microservice.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Microservice.Controllers
{
    [EnableCors]
    [Route("api/[controller]")]
    [ApiController]
    public class KisiController : ControllerBase
    {
        private readonly IMediator _mediator;

        public KisiController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _mediator.Send(new GetAllKisilerQueryRequest()));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]CreateKisilerCommandRequest model)
        {
            return Ok(await _mediator.Send(model));
        }

        [HttpDelete]
        public async Task<IActionResult> Remove([FromBody]RemoveKisilerCommandRequest model)
        {
            return Ok(await _mediator.Send(model));
        }
    }
}
