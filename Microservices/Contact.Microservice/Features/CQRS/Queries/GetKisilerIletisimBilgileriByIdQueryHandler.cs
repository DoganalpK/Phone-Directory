using AutoMapper;
using Contact.Microservice.Models.Domain;
using Contact.Microservice.Models.Dtos;
using Contact.Microservice.Repository;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Contact.Microservice.Features.CQRS.Queries
{
    public class GetKisilerIletisimBilgileriByIdQueryHandler : IRequestHandler<GetKisilerIletisimBilgileriByIdQueryRequest, KisilerIletisimBilgileriListDto>
    {
        private readonly IGenericRepository<Kisiler> _repository;
        private readonly IMapper _mapper;

        public GetKisilerIletisimBilgileriByIdQueryHandler(IGenericRepository<Kisiler> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<KisilerIletisimBilgileriListDto> Handle(GetKisilerIletisimBilgileriByIdQueryRequest request, CancellationToken cancellationToken)
        {
            var kisilerQuery = await _repository.GetQuery();
            var kisilerIletisimBilgileri = await kisilerQuery.Include(x => x.IletisimBilgileris).ToListAsync();
            var dto = _mapper.Map<KisilerIletisimBilgileriListDto>(kisilerIletisimBilgileri);
            return dto;
        }
    }
}
