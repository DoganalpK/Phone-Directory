using AutoMapper;
using Contact.Microservice.Models.Domain;
using Contact.Microservice.Models.Dtos;
using Contact.Microservice.Repository;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class CreateRaporCommandHandler : IRequestHandler<CreateRaporCommandRequest, RaporCreateDto>
    {
        private readonly IGenericRepository<Rapor> _repository;
        private readonly IMapper _mapper;

        public CreateRaporCommandHandler(IGenericRepository<Rapor> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<RaporCreateDto> Handle(CreateRaporCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<Rapor>(request);
            var data = await _repository.CreateAsync(dto);
            return _mapper.Map<RaporCreateDto>(data);
        }
    }
}
