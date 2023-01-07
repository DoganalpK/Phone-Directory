using Contact.Microservice.Models.Base;

namespace Contact.Microservice.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity, T unchanged);
        Task<Guid> DeleteAsync(T entity);
    }
}
