using FinanceBilling.Application.DTOs.Invoice;
using FluentValidation;

namespace FinanceBilling.Application.Validators;

public class InvoiceValidator : AbstractValidator<CreateInvoiceDto>
{
    public InvoiceValidator()
    {
        RuleFor(x => x.InvoiceNumber)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.Amount)
            .GreaterThan(0);

        RuleFor(x => x.CustomerId)
            .GreaterThan(0);

        RuleFor(x => x.InvoiceDate)
            .NotEmpty();

        RuleFor(x => x.DueDate)
            .GreaterThan(x => x.InvoiceDate)
            .WithMessage("Due Date must be greater than Invoice Date");
    }
}