using ModelLayer;

namespace LogicLayer.Interfaces
{
    public interface IPersonService
    {
        PersonResponse GetPersons(PersonRequest request);
    }
}
