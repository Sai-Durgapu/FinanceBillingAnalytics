using FinanceBilling.Domain.Entities;

namespace FinanceBilling.Infrastructure.Repositories.Interfaces;

public interface IInvoiceRepository
    : IGenericRepository<Invoice>
{
    Task<IEnumerable<Invoice>> GetPendingInvoicesAsync();
}