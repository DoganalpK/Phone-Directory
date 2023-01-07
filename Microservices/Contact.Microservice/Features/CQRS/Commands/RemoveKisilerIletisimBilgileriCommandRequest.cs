using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class RemoveKisilerIletisimBilgileriCommandRequest : IRequest<Guid>
    {
        public Guid UUID { get; set; }
    }
}
