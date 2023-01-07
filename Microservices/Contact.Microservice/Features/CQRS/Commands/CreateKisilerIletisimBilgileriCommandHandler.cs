using AutoMapper;
using Contact.Microservice.Models.Domain;
using Contact.Microservice.Models.Dtos;
using Contact.Microservice.Repository;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class CreateKisilerIletisimBilgileriCommandHandler : IRequestHandler<CreateKisilerIletisimBilgileriCommandRequest, KisilerIletisimBilgileriListDto>
    {
        private readonly IGenericRepository<IletisimBilgileri> _repository;
        private readonly IMapper _mapper;

        public CreateKisilerIletisimBilgileriCommandHandler(IGenericRepository<IletisimBilgileri> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<KisilerIletisimBilgileriListDto> Handle(CreateKisilerIletisimBilgileriCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<IletisimBilgileri>(request);
            var iletisimBilgileri = await _repository.CreateAsync(dto);
            return _mapper.Map<KisilerIletisimBilgileriListDto>(iletisimBilgileri);
        }
    }
}
