namespace Web_API.DTO
{
    public class TaskModelDTO
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public bool IsCompleted { get; set; }
    }
}