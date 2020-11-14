using System.Collections.Generic;

namespace ModelLayer
{
    public class PersonResponse
    {
        public IEnumerable<string> errorMessage { get; set; }
        public IEnumerable<PersonModel> person { get; set; }
    }
}
