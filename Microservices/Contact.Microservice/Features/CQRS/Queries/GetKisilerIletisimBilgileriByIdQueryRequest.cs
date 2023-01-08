using Contact.Microservice.Models.Dtos;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Queries
{
    public class GetKisilerIletisimBilgileriByIdQueryRequest : IRequest<KisilerIletisimBilgileriListDto>
    {
        public Guid UUID { get; set; }
    }
}
