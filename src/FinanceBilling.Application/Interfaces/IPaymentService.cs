using FinanceBilling.Application.DTOs.Payment;

namespace FinanceBilling.Application.Interfaces;

public interface IPaymentService
{
    Task<IEnumerable<PaymentDto>> GetAllAsync();
    Task<PaymentDto?> GetByIdAsync(int id);
    Task CreateAsync(CreatePaymentDto dto);
}
