using Contact.Microservice.Features.CQRS.Commands;
using Contact.Microservice.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery]GetKisilerIletisimBilgileriByIdQueryRequest model)
        {
            return Ok(await _mediator.Send(model));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(RemoveIletisimBilgileriCommandRequest model)
        {
            return Ok(await _mediator.Send(model));
        }
    }
}
