using FinanceBilling.Domain.Entities;
using FinanceBilling.Infrastructure.Data;
using FinanceBilling.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinanceBilling.Infrastructure.Repositories;

public class CustomerRepository
    : GenericRepository<Customer>,
      ICustomerRepository
{
    public CustomerRepository(FinanceDbContext context)
        : base(context)
    {
    }

    public async Task<Customer?> GetCustomerWithInvoicesAsync(int id)
    {
        return await _context.Customers
            .Include(c => c.Invoices)
            .FirstOrDefaultAsync(c => c.Id == id);
    }
}