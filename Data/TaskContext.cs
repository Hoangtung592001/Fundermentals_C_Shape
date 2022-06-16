using Models;

namespace Web_API.Data
{
    public static class TaskContext
    {
        public static List<TaskModel> TaskModels = new List<TaskModel>{
            new TaskModel("Hello1", true),
            new TaskModel("Hello2", false),
            new TaskModel("Hello3", false),
            new TaskModel("Hello4", false)
        };
    }
}