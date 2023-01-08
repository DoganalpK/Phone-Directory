using AutoMapper;
using Contact.Microservice.Models.Domain;
using Contact.Microservice.Models.Dtos;
using Contact.Microservice.Repository;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Queries
{
    public class GetAllKisilerQueryHandler : IRequestHandler<GetAllKisilerQueryRequest, List<KisilerListDto>>
    {
        private readonly IGenericRepository<Kisiler> _repository;
        private readonly IMapper _mapper;

        public GetAllKisilerQueryHandler(IGenericRepository<Kisiler> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<KisilerListDto>> Handle(GetAllKisilerQueryRequest request, CancellationToken cancellationToken)
        {
            var kisilerList = await _repository.GetAllAsync();
            var dto = _mapper.Map<List<KisilerListDto>>(kisilerList);
            return dto;
        }
    }
}
