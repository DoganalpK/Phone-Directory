using Contact.Microservice.Models.Dtos;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class CreateKisilerCommandRequest : IRequest<KisilerListDto>
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Firma { get; set; }
    }
}
