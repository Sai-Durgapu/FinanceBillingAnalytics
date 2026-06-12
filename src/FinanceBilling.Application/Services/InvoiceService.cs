using FinanceBilling.Application.DTOs.Invoice;
using FinanceBilling.Application.Interfaces;

namespace FinanceBilling.Application.Services;

public class InvoiceService : IInvoiceService
{
    public Task<IEnumerable<InvoiceDto>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<InvoiceDto>>(new List<InvoiceDto>());
    }

    public Task<InvoiceDto?> GetByIdAsync(int id)
    {
        return Task.FromResult<InvoiceDto?>(null);
    }

    public Task CreateAsync(CreateInvoiceDto dto)
    {
        return Task.CompletedTask;
    }

    public Task UpdateAsync(int id, CreateInvoiceDto dto)
    {
        return Task.CompletedTask;
    }

    public Task DeleteAsync(int id)
    {
        return Task.CompletedTask;
    }
}