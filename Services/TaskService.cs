using Models;
using Web_API.Data;
using Web_API.DTO;
using Web_API.Services.Interfaces;

namespace Web_API.Services
{
    class TaskService : ITaskService
    {
        public TaskModel Create(string title, bool isCompleted)
        {
            TaskModel newTask = new TaskModel(title, isCompleted);
            TaskContext.TaskModels.Add(newTask);

            return newTask;
        }

        public TaskModel? GetById(Guid id)
        {
            TaskModel task = TaskContext.TaskModels.Where(task => task.Id == id).FirstOrDefault();

            return task;
        }

        public bool DeleteById(Guid id)
        {
            TaskModel task = TaskContext.TaskModels.Where(task => task.Id == id).FirstOrDefault();

            if (task != null)
            {
                TaskContext.TaskModels.Remove(task);

                return true;
            }

            return false;
        }

        public List<TaskModel> GetAll()
        {
            return TaskContext.TaskModels;
        }

        public TaskModel? EditById(Guid id, TaskModel taskModel)
        {
            TaskModel edittingTask = TaskContext.TaskModels.Where(task => task.Id == id).FirstOrDefault();
            if (edittingTask != null)
            {
                edittingTask.Title = taskModel.Title;
                edittingTask.IsCompleted = taskModel.IsCompleted;

                return edittingTask;
            }

            return null;
        }

        public List<TaskModel> AddMultipleTasks(List<TaskModelDTO> taskModels)
        {
            var newTasks = new List<TaskModel>();

            foreach (var task in taskModels)
            {
                newTasks.Add(new TaskModel(task.Title, task.IsCompleted));
            }

            TaskContext.TaskModels.AddRange(newTasks);

            return newTasks;
        }

        public bool DeleteMultipleTasks(List<Guid> ids)
        {
            List<TaskModel> deletingTasks = TaskContext.TaskModels.Where(task => ids.Contains(task.Id)).ToList();

            if (deletingTasks.Any())
            {
                try
                {
                    TaskContext.TaskModels.RemoveAll(task => ids.Contains(task.Id));
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}