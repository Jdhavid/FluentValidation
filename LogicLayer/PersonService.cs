using DataLayer.Interfaces;
using FluentValidation;
using LogicLayer.Interfaces;
using LogicLayer.Validators;
using ModelLayer;
using System.Collections.Generic;

namespace LogicLayer
{
    public class PersonService : IPersonService
    {

        private readonly IValidator<PersonModel> personModelValidator;
        private readonly IValidator<PersonRequest> personRequestValidator;
        private readonly IPersonData personData;

        public PersonService(IValidator<PersonModel> personModelValidator,
                             IValidator<PersonRequest> personRequestValidator,
                             IPersonData personData)
        {
            this.personModelValidator = personModelValidator;
            this.personRequestValidator = personRequestValidator;
            this.personData = personData;
        }


        public PersonResponse GetPersons(PersonRequest request)
        {
            PersonResponse personResponse = new PersonResponse();

            var validationResult = this.personRequestValidator.Validate(request);

            if (!validationResult.IsValid)
            {
                List<string> messageError = new List<string>();
                foreach (var error in validationResult.Errors) messageError.Add(error.ErrorMessage);
                personResponse.errorMessage = messageError;
                return personResponse;
            }
            personResponse.person = personData.GetList();

            return personResponse;
        }


    }
}
