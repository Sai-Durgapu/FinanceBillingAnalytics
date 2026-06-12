using FinanceBilling.Application.DTOs.Invoice;

namespace FinanceBilling.Application.Interfaces;

public interface IInvoiceService
{
    Task<IEnumerable<InvoiceDto>> GetAllAsync();
    Task<InvoiceDto?> GetByIdAsync(int id);
    Task CreateAsync(CreateInvoiceDto dto);
    Task UpdateAsync(int id, CreateInvoiceDto dto);
    Task DeleteAsync(int id);
}