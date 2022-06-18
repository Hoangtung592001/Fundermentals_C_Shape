using WebAPI.DTO;
using WebAPI.Entities;

namespace WebAPI.Services
{
    public interface IPersonService
    {
        List<Person> GetAll();

        Person Create(PersonDTO person);

        Person Edit(Guid id, EditPersonDTO person);

        bool Delete(Guid id);

        List<Person> Filter(FilterPersonDTO condition);
    }
}