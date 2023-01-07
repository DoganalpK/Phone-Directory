using Contact.Microservice.Models.Dtos;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class CreateKisilerIletisimBilgileriCommandRequest : IRequest<KisilerIletisimBilgileriListDto>
    {
        public string BilgiIcerigi { get; set; }
        public string TelefonNumarasi { get; set; }
        public string EmailAdresi { get; set; }
        public string Konum { get; set; }
        public Guid KisilerUUID { get; set; }
    }
}
