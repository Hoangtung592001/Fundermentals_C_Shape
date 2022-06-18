namespace WebAPI.DTO
{
    public class PersonDTO
    {
        public Guid? Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string BirthPlace { get; set; }
    }
}