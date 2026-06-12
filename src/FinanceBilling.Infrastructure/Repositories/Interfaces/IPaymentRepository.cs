using FinanceBilling.Domain.Entities;

namespace FinanceBilling.Infrastructure.Repositories.Interfaces;

public interface IPaymentRepository
    : IGenericRepository<Payment>
{
    Task<decimal> GetTotalPaymentsAsync();
}