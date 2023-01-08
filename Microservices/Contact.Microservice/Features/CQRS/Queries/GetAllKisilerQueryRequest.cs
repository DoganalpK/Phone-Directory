using MediatR;

namespace Contact.Microservice.Features.CQRS.Queries
{
    public class GetAllKisilerQueryRequest : IRequest<List<Contact.Microservice.Models.Dtos.KisilerListDto>>
    {
    }
}
