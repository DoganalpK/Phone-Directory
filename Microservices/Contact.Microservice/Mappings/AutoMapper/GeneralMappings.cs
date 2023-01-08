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
            CreateMap<List<Kisiler>, KisilerIletisimBilgileriListDto>().ReverseMap();
            CreateMap<Kisiler, KisilerIletisimBilgileriListDto>().ReverseMap();
            CreateMap<IletisimBilgileri, IletisimBilgileriCreateDto>().ReverseMap();
            CreateMap<IletisimBilgileri, IletisimBilgileriListDto>().ReverseMap();
            CreateMap<IletisimBilgileri, CreateIletisimBilgileriCommandRequest>().ReverseMap();
            CreateMap<List<Rapor>, List<RaporListDto>>().ReverseMap();
            CreateMap<Rapor, RaporListDto>().ReverseMap();
            CreateMap<Rapor, RaporCreateDto>().ReverseMap();
        }
    }
}
