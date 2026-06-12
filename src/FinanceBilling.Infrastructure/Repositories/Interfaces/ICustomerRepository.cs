using FinanceBilling.Domain.Entities;

namespace FinanceBilling.Infrastructure.Repositories.Interfaces;

public interface ICustomerRepository
    : IGenericRepository<Customer>
{
    Task<Customer?> GetCustomerWithInvoicesAsync(int id);
}