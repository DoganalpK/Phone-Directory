using Contact.Microservice.Models.Base;
using Contact.Microservice.Models.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Contact.Microservice.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context) => _context = context;        

        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }
        public async Task<T> CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(T entity,T unchanged)
        {
            _context.Entry(unchanged).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<Guid> DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity.UUID;
        }

        public async Task<IQueryable<T>> GetQuery()
        {
           return _context.Set<T>().AsQueryable();
        }
    }
}
