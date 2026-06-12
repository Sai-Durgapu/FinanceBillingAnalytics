using FinanceBilling.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinanceBilling.Infrastructure.Configurations;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.AmountPaid)
            .HasColumnType("decimal(18,2)");

        builder.Property(x => x.TransactionReference)
            .HasMaxLength(100);

        builder.Property(x => x.PaymentMethod)
            .HasMaxLength(50);

        builder.HasOne(x => x.Invoice)
            .WithMany(x => x.Payments)
            .HasForeignKey(x => x.InvoiceId);
    }
}