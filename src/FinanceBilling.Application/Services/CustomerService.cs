using FinanceBilling.Application.DTOs.Customer;
using FinanceBilling.Application.Interfaces;

namespace FinanceBilling.Application.Services;

public class CustomerService : ICustomerService
{
    public Task<IEnumerable<CustomerDto>> GetAllAsync()
    {
        return Task.FromResult<IEnumerable<CustomerDto>>(new List<CustomerDto>());
    }

    public Task<CustomerDto?> GetByIdAsync(int id)
    {
        return Task.FromResult<CustomerDto?>(null);
    }

    public Task CreateAsync(CreateCustomerDto dto)
    {
        return Task.CompletedTask;
    }

    public Task UpdateAsync(int id, CreateCustomerDto dto)
    {
        return Task.CompletedTask;
    }

    public Task DeleteAsync(int id)
    {
        return Task.CompletedTask;
    }
}