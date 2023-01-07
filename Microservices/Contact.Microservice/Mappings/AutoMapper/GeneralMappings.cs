using AutoMapper;
using Contact.Microservice.Features.CQRS.Commands;
using Contact.Microservice.Models.Domain;
using Contact.Microservice.Models.Dtos;

namespace Contact.Microservice.Mappings.AutoMapper
{
    public class GeneralMappings : Profile
    {
        public GeneralMappings()
        {
            CreateMap<Kisiler, KisilerCreateDto>().ReverseMap();
            CreateMap<Kisiler, KisilerListDto>().ReverseMap();
            CreateMap<Kisiler, CreateKisilerCommandRequest>().ReverseMap();
            CreateMap<IletisimBilgileri, KisilerIletisimBilgileriCreateDto>().ReverseMap();
            CreateMap<IletisimBilgileri, KisilerIletisimBilgileriListDto>().ReverseMap();
        }
    }
}
