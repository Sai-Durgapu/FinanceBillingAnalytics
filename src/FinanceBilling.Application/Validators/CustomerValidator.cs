using FinanceBilling.Application.DTOs.Customer;
using FluentValidation;

namespace FinanceBilling.Application.Validators;

public class CustomerValidator : AbstractValidator<CreateCustomerDto>
{
    public CustomerValidator()
    {
        RuleFor(x => x.CustomerCode)
            .NotEmpty()
            .MaximumLength(50);

        RuleFor(x => x.Name)
            .NotEmpty()
            .MaximumLength(100);

        RuleFor(x => x.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(x => x.Phone)
            .NotEmpty();

        RuleFor(x => x.Address)
            .NotEmpty();
    }
}