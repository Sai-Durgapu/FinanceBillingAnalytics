using FinanceBilling.Domain.Entities;
using FinanceBilling.Infrastructure.Data;
using FinanceBilling.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FinanceBilling.Infrastructure.Repositories;

public class PaymentRepository
    : GenericRepository<Payment>,
      IPaymentRepository
{
    public PaymentRepository(FinanceDbContext context)
        : base(context)
    {
    }

    public async Task<decimal> GetTotalPaymentsAsync()
    {
        return await _context.Payments
            .SumAsync(p => p.AmountPaid);
    }
}