using FinanceBilling.Domain.Entities;
using FinanceBilling.Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FinanceBilling.Infrastructure.Identity;

namespace FinanceBilling.Infrastructure.Data;

public class FinanceDbContext
    : IdentityDbContext<ApplicationUser>
{
    public FinanceDbContext(
        DbContextOptions<FinanceDbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers => Set<Customer>();

    public DbSet<Invoice> Invoices => Set<Invoice>();

    public DbSet<Payment> Payments => Set<Payment>();

    protected override void OnModelCreating(
        ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfiguration(
            new CustomerConfiguration());

        modelBuilder.ApplyConfiguration(
            new InvoiceConfiguration());

        modelBuilder.ApplyConfiguration(
            new PaymentConfiguration());
    }
}