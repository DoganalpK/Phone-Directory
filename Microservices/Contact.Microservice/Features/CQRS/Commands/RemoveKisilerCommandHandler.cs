using Contact.Microservice.Models.Domain;
using Contact.Microservice.Repository;
using MediatR;

namespace Contact.Microservice.Features.CQRS.Commands
{
    public class RemoveKisilerCommandHandler : IRequestHandler<RemoveKisilerCommandRequest, Guid>
    {
        private readonly IGenericRepository<Kisiler> _repository;

        public RemoveKisilerCommandHandler(IGenericRepository<Kisiler> repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(RemoveKisilerCommandRequest request, CancellationToken cancellationToken)
        {
            var data = await _repository.GetByIdAsync(request.UUID);
            await _repository.DeleteAsync(data);
            return request.UUID;
        }
    }
}
