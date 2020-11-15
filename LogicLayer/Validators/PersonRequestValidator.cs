using FluentValidation;
using ModelLayer;
using System;

namespace LogicLayer.Validators
{
    public class PersonRequestValidator : AbstractValidator<PersonRequest>
    {

        public PersonRequestValidator()
        {
            RuleFor(t => t.id).NotNull().NotEmpty().GreaterThan(0).WithMessage("The person is invalid.");
            RuleFor(t => t.email).Must(IsValidEmail).When(x => !string.IsNullOrEmpty(x.email)).WithMessage("The Email is invalid.");
        }

        private bool IsValidEmail(string email)
        {
            bool isValid;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                isValid = addr.Address.Equals(email);
            }
            catch (Exception)
            {
                isValid = false;
            };
            return isValid;
        }

    }
}
