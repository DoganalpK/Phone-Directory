using AutoMapper;
using Contact.Microservice.Models.Domain;
using Contact.Microservice.Models.Dtos;
using Contact.Microservice.Repository;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class CreateKisilerCommandHandler : IRequestHandler<CreateKisilerCommandRequest, KisilerListDto>
    {
        private readonly IGenericRepository<Kisiler> _repository;
        private readonly IMapper _mapper;

        public CreateKisilerCommandHandler(IGenericRepository<Kisiler> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<KisilerListDto> Handle(CreateKisilerCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<Kisiler>(request);
            var kisi = await _repository.CreateAsync(dto);
            return _mapper.Map<KisilerListDto>(kisi);
        }
    }
}
