using ModelLayer.Interfaces;
using System.Collections.Generic;

namespace ModelLayer
{
    public class PersonResponse : IPersonResponse
    {
        public IEnumerable<string> errorMessage { get; set; }
        public IEnumerable<PersonModel> person { get; set; }
    }
}
