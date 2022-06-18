

using WebAPI.DTO;
using WebAPI.Entities;

namespace WebAPI.Extensions
{
    public static class PersonExtension
    {
        public static Person DTOToEntity(this PersonDTO person)
        {
            return new Person(person.Id.HasValue ? (Guid)person.Id : Guid.NewGuid(), person.FirstName, person.LastName, person.DateOfBirth, person.Gender, person.BirthPlace);
        }
    }
}