using FluentValidation;
using SipayApi.Models;

namespace SipayApi.FluentValidator
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(p => p.Name)
            .NotEmpty()
            .WithMessage("Staff person name is required.")
            .Length(5, 100)
            .WithMessage("Staff person name must be between 5 and 100 characters.");

            RuleFor(p => p.LastName)
                .NotEmpty()
                .WithMessage("Staff person lastname is required.")
                .Length(5, 100)
                .WithMessage("Staff person lastname must be between 5 and 100 characters.");

            RuleFor(p => p.Phone)
                .NotEmpty()
                .WithMessage("Staff person phone number is required.");

            RuleFor(p => p.AccessLevel)
                .NotEmpty()
                .WithMessage("Staff person access level to the system is required.")
                .InclusiveBetween(1, 5)
                .WithMessage("Staff person access level must be between 1 and 5.");

            RuleFor(p => p.Salary)
                .NotEmpty()
                .WithMessage("Staff person salary is required.")
                .InclusiveBetween(5000, 50000)
                .WithMessage("Staff person salary must be between 5000 and 50000.");
        }
    }
}