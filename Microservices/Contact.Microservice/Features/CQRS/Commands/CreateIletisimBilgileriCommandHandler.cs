using AutoMapper;
using Contact.Microservice.Models.Domain;
using Contact.Microservice.Models.Dtos;
using Contact.Microservice.Repository;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class CreateIletisimBilgileriCommandHandler : IRequestHandler<CreateIletisimBilgileriCommandRequest, IletisimBilgileriListDto>
    {
        private readonly IGenericRepository<IletisimBilgileri> _repository;
        private readonly IMapper _mapper;

        public CreateIletisimBilgileriCommandHandler(IGenericRepository<IletisimBilgileri> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IletisimBilgileriListDto> Handle(CreateIletisimBilgileriCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<IletisimBilgileri>(request);
            var iletisimBilgileri = await _repository.CreateAsync(dto);
            return _mapper.Map<IletisimBilgileriListDto>(iletisimBilgileri);
        }
    }
}
