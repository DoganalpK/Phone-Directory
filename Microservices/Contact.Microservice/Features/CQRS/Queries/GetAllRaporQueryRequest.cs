using Contact.Microservice.Models.Dtos;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Queries
{
    public class GetAllRaporQueryRequest : IRequest<List<RaporListDto>>
    {
    }
}
