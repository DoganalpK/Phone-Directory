using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class RemoveKisilerCommandRequest : IRequest<Guid>
    {
        public Guid UUID { get; set; }
    }
}
