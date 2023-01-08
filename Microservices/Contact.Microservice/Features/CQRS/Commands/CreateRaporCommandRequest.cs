using Contact.Microservice.Models.Dtos;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class CreateRaporCommandRequest:IRequest<RaporCreateDto>
    {
        public string Konum { get; set; }
        public int KisiSayi { get; set; }
        public int TelefonNumarasiSayi { get; set; }
        public int RaporDurumId { get; set; }
    }
}
