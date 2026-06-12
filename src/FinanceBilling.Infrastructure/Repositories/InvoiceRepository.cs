using FinanceBilling.Domain.Entities;
using FinanceBilling.Domain.Enums;
using FinanceBilling.Infrastructure.Data;
using FinanceBilling.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinanceBilling.Infrastructure.Repositories;

public class InvoiceRepository
    : GenericRepository<Invoice>,
      IInvoiceRepository
{
    public InvoiceRepository(FinanceDbContext context)
        : base(context)
    {
    }

    public async Task<IEnumerable<Invoice>> GetPendingInvoicesAsync()
    {
        return await _context.Invoices
            .Where(i => i.Status == InvoiceStatus.Pending)
            .ToListAsync();
    }
}