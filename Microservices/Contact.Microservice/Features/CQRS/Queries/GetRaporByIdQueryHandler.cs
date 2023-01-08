using AutoMapper;
using Contact.Microservice.Models.Domain;
using Contact.Microservice.Models.Dtos;
using Contact.Microservice.Repository;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Queries
{
    public class GetRaporByIdQueryHandler : IRequestHandler<GetRaporByIdQueryRequest, RaporListDto>
    {
        private readonly IGenericRepository<Rapor> _repository;
        private readonly IMapper _mapper;

        public GetRaporByIdQueryHandler(IGenericRepository<Rapor> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<RaporListDto> Handle(GetRaporByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.UUID);
            var dto = _mapper.Map<RaporListDto>(data);
            return dto;
        }
    }
}
