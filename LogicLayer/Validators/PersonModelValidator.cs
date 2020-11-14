using FluentValidation;
using ModelLayer;
using System;

namespace LogicLayer.Validators
{
    public class PersonModelValidator : AbstractValidator<PersonModel>
    {
        public PersonModelValidator()
        {
            RuleFor(t => t.fullName).NotEmpty().Length(1, 50).WithMessage("Please specify a fullname.");

            RuleFor(t => t.age).NotEmpty().InclusiveBetween(18, 50).WithMessage("The min age is 18.");

            /*
            1. Que no sea null
            2. Que sea mayo a cero (0)
            3. Menor o igual a 100
            4. Cuando hasDiscount sea TRUE
             */
            RuleFor(t => t.discount).NotEmpty().GreaterThan(0).LessThanOrEqualTo(100).When(x => x.hasDiscount).WithMessage("The % discount is invalid.");

            RuleFor(t => t.dateOfBirth).Must(IsValidDateOfBirth).WithMessage("The Date of Birth is invalid.");


        }

        private bool IsValidDateOfBirth(DateTime dateOfBirth)
        {
            return dateOfBirth <= DateTime.Today.AddDays(-18);
        }
    }
}
