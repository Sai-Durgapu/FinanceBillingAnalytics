using FinanceBilling.Infrastructure.Data;
using FinanceBilling.Infrastructure.Repositories;
using FinanceBilling.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using FinanceBilling.Infrastructure.Security;

namespace FinanceBilling.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddDbContext<FinanceDbContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<ICustomerRepository, CustomerRepository>();

        services.AddScoped<IInvoiceRepository, InvoiceRepository>();

        services.AddScoped<IPaymentRepository, PaymentRepository>();
        services.AddScoped<JwtTokenGenerator>();

        return services;
    }
}