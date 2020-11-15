using ModelLayer;
using ModelLayer.Interfaces;

namespace LogicLayer.Interfaces
{
    public interface IPersonService
    {
        IPersonResponse GetPersons(PersonRequest request);
    }
}
