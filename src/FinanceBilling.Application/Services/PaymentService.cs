using FinanceBilling.Application.DTOs.Payment;
using FinanceBilling.Application.Interfaces;

namespace FinanceBilling.Application.Services;

public class PaymentService : IPaymentService
{
    public Task<IEnumerable<PaymentDto>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<PaymentDto>>(new List<PaymentDto>());
    }

    public Task<PaymentDto?> GetByIdAsync(int id)
    {
        return Task.FromResult<PaymentDto?>(null);
    }

    public Task CreateAsync(CreatePaymentDto dto)
    {
        return Task.CompletedTask;
    }
}