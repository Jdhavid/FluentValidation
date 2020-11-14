using ModelLayer;
using System.Collections.Generic;

namespace DataLayer.Interfaces
{
    public interface IPersonData
    {
        List<PersonModel> GetList();
        void Add(PersonModel person);
    }
}
