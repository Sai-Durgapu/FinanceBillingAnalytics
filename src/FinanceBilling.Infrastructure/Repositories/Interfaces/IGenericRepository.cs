using FinanceBilling.Domain.Common;

namespace FinanceBilling.Infrastructure.Repositories.Interfaces;

public interface IGenericRepository<T>
    where T : BaseEntity
{
    Task<IEnumerable<T>> GetAllAsync();

    Task<T?> GetByIdAsync(int id);

    Task AddAsync(T entity);

    void Update(T entity);

    void Delete(T entity);

    Task SaveChangesAsync();
}