using Contact.Microservice.Models.Domain;
using Contact.Microservice.Repository;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class RemoveIletisimBilgileriCommandHandler : IRequestHandler<RemoveIletisimBilgileriCommandRequest, Guid>
    {
        private readonly IGenericRepository<IletisimBilgileri> _repository;

        public RemoveIletisimBilgileriCommandHandler(IGenericRepository<IletisimBilgileri> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(RemoveIletisimBilgileriCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.UUID);
            await _repository.DeleteAsync(data);
            return data.UUID;
        }
    }
}
