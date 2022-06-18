using WebAPI.Data;
using WebAPI.DTO;
using WebAPI.Entities;
using WebAPI.Extensions;

namespace WebAPI.Services
{
    public class PersonService : IPersonService
    {
        public Person Create(PersonDTO person)
        {
            Person newPerson = PersonExtension.DTOToEntity(person);
            PersonContext.people.Add(newPerson);

            return newPerson;
        }

        public bool Delete(Guid id)
        {
            Person person = PersonContext.people.FirstOrDefault(person => person.Id == id);

            if (person != null)
            {
                PersonContext.people.Remove(person);

                return true;
            }

            return false;
        }

        public List<Person> Filter(FilterPersonDTO condition)
        {
            return PersonContext.people.Where(person => person.Name == condition.Name
                                                || (string.IsNullOrEmpty(person.Gender) && person.Gender.ToLower() == condition.Gender.ToLower())
                                                || (string.IsNullOrEmpty(person.BirthPlace) && person.BirthPlace.ToLower() == condition.BirthPlace.ToLower()))
                                                .ToList();
        }

        public List<Person> GetAll()
        {
            return PersonContext.people;
        }

        public Person Edit(Guid id, EditPersonDTO person)
        {
            Person targetPerson = PersonContext.people.Find(person => person.Id == id);

            if (targetPerson != null)
            {
                targetPerson.FirstName = !string.IsNullOrEmpty(person.FirstName) ? person.FirstName : targetPerson.FirstName;
                targetPerson.LastName = !string.IsNullOrEmpty(person.LastName) ? person.LastName : targetPerson.LastName;
                targetPerson.DateOfBirth = person.DateOfBirth.HasValue ? (DateTime)person.DateOfBirth : targetPerson.DateOfBirth;
                targetPerson.BirthPlace = !string.IsNullOrEmpty(person.BirthPlace) ? person.BirthPlace : targetPerson.BirthPlace;
                targetPerson.Gender = !string.IsNullOrEmpty(person.Gender) ? person.Gender : targetPerson.Gender;

                return targetPerson;
            }

            return null;
        }
    }
}