using Contact.Microservice.Models.Domain;
using Contact.Microservice.Repository;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class RemoveKisilerIletisimBilgileriCommandHandler : IRequestHandler<RemoveKisilerIletisimBilgileriCommandRequest, Guid>
    {
        private readonly IGenericRepository<IletisimBilgileri> _repository;

        public RemoveKisilerIletisimBilgileriCommandHandler(IGenericRepository<IletisimBilgileri> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(RemoveKisilerIletisimBilgileriCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.UUID);
            await _repository.DeleteAsync(data);
            return data.UUID;
        }
    }
}
