using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLayer.Interfaces
{
    public interface IPersonResponse
    {
        IEnumerable<string> errorMessage { get; set; }
        IEnumerable<PersonModel> person { get; set; }
    }
}
