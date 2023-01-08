using AutoMapper;
using Contact.Microservice.Models.Domain;
using Contact.Microservice.Models.Dtos;
using Contact.Microservice.Repository;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Queries
{
    public class GetAllRaporQueryHandler : IRequestHandler<GetAllRaporQueryRequest, List<RaporListDto>>
    {
        private readonly IGenericRepository<Rapor> _repository;
        private readonly IMapper _mapper;

        public GetAllRaporQueryHandler(IGenericRepository<Rapor> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<RaporListDto>> Handle(GetAllRaporQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetAllAsync();
            var dto = _mapper.Map<List<RaporListDto>>(data);
            return dto;
        }
    }
}
