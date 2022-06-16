namespace Models
{
    public class TaskModel
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public bool IsCompleted { get; set; }

        public TaskModel(string _title, bool _isCompleted)
        {
            this.Id = Guid.NewGuid();
            this.Title = _title;
            this.IsCompleted = _isCompleted;
        }
    }
}