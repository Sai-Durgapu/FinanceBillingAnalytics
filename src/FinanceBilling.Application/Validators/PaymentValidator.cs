using FinanceBilling.Application.DTOs.Payment;
using FluentValidation;

namespace FinanceBilling.Application.Validators;

public class PaymentValidator : AbstractValidator<CreatePaymentDto>
{
    public PaymentValidator()
    {
        RuleFor(x => x.InvoiceId)
            .GreaterThan(0);

        RuleFor(x => x.AmountPaid)
            .GreaterThan(0);

        RuleFor(x => x.PaymentDate)
            .NotEmpty();

        RuleFor(x => x.TransactionReference)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.PaymentMethod)
            .NotEmpty()
            .MaximumLength(50);
    }
}