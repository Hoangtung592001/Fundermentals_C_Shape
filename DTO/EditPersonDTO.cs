namespace WebAPI.DTO
{
    public class EditPersonDTO
    {
        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string? Gender { get; set; }

        public string? BirthPlace { get; set; }
    }
}