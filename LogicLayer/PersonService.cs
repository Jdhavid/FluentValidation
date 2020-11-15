using DataLayer.Interfaces;
using FluentValidation;
using LogicLayer.Interfaces;
using LogicLayer.Validators;
using ModelLayer;
using ModelLayer.Interfaces;
using System.Collections.Generic;

namespace LogicLayer
{
    public class PersonService : IPersonService
    {

        private readonly IValidator<PersonModel> personModelValidator;
        private readonly IValidator<PersonRequest> personRequestValidator;
        private readonly IPersonData personData;
        private readonly IPersonResponse personResponse;

        public PersonService(IValidator<PersonModel> personModelValidator,
                             IValidator<PersonRequest> personRequestValidator,
                             IPersonData personData,
                             IPersonResponse personaResponse)
        {
            this.personModelValidator = personModelValidator;
            this.personRequestValidator = personRequestValidator;
            this.personData = personData;
            this.personResponse = personaResponse;
        }


        public IPersonResponse GetPersons(PersonRequest request)
        {            
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
