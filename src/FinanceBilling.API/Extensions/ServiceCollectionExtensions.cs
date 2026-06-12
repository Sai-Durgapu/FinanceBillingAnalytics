using FinanceBilling.Application.Interfaces;
using FinanceBilling.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FinanceBilling.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(
        this IServiceCollection services)
    {
        services.AddScoped<ICustomerService, CustomerService>();

        services.AddScoped<IInvoiceService, InvoiceService>();

        services.AddScoped<IPaymentService, PaymentService>();

        services.AddScoped<IDashboardService, DashboardService>();

        return services;
    }
}