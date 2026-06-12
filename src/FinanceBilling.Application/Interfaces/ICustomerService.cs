using FinanceBilling.Application.DTOs.Customer;
namespace FinanceBilling.Application.Interfaces;
public interface ICustomerService
{
    Task<IEnumerable<CustomerDto>> GetAllAsync();
    Task<CustomerDto?> GetByIdAsync(int id);
    Task CreateAsync(CreateCustomerDto dto);
    Task UpdateAsync(int id, CreateCustomerDto dto);
    Task DeleteAsync(int id);
}