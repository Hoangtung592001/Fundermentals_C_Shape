using Models;
using Web_API.DTO;

namespace Web_API.Services.Interfaces
{
    public interface ITaskService
    {
        TaskModel Create(string title, bool isCompleted);

        List<TaskModel> GetAll();

        TaskModel? GetById(Guid id);

        bool DeleteById(Guid id);

        TaskModel? EditById(Guid id, TaskModel taskModel);

        List<TaskModel> AddMultipleTasks(List<TaskModelDTO> taskModels);

        bool DeleteMultipleTasks(List<Guid> ids);
    }
}