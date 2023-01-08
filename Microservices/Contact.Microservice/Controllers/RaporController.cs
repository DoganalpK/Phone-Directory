using Contact.Microservice.Features.CQRS.Commands;
using Contact.Microservice.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contact.Microservice.Controllers
{
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
            return Ok(await _mediator.Send(new GetAllRaporQueryRequest()));
        }

        [HttpGet("{UUID}")]
        public async Task<IActionResult> GetById(GetRaporByIdQueryRequest model)
        {
            return Ok(await _mediator.Send(model));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CreateRaporCommandRequest model)
        {
            return Ok(await _mediator.Send(model));
        }
    }
}
