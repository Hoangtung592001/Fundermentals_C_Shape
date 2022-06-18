using WebAPI.DTO;

namespace WebAPI.Entities
{
    public class Person
    {
        public Guid? Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string BirthPlace { get; set; }

        public Person(string _firstName, string _lastName, DateTime _dateOfBirth, string _gender, string _birthPlace)
        {
            this.Id = Guid.NewGuid();
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.DateOfBirth = _dateOfBirth;
            this.Gender = _gender;
            this.BirthPlace = _birthPlace;
        }

        public Person(Guid Id, string _firstName, string _lastName, DateTime _dateOfBirth, string _gender, string _birthPlace)
        {
            this.Id = Id;
            this.FirstName = _firstName;
            this.LastName = _lastName;
            this.DateOfBirth = _dateOfBirth;
            this.Gender = _gender;
            this.BirthPlace = _birthPlace;
        }

        public string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}