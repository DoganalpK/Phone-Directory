using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class RemoveIletisimBilgileriCommandRequest : IRequest<Guid>
    {
        public Guid UUID { get; set; }
    }
}
