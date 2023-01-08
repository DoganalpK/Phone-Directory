using Contact.Microservice.Models.Dtos;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Queries
{
    public class GetRaporByIdQueryRequest:IRequest<RaporListDto>
    {
        public Guid UUID { get; set; }
    }
}
