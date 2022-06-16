using Models;
using Microsoft.AspNetCore.Mvc;
using Web_API.Services.Interfaces;
using Web_API.DTO;

namespace Web_API.Controllers;

[Route("task")]
public class TaskController : ControllerBase
{
    private ITaskService _taskService;

    public TaskController(ITaskService taskService)
    {
        _taskService = taskService;
    }

    [HttpGet("/get-all")]
    public List<TaskModel> GetAll()
    {
        return _taskService.GetAll();
    }

    [HttpPost()]
    public TaskModel CreateTask(string title, bool isCompleted)
    {
        return _taskService.Create(title, isCompleted);
    }

    [HttpGet("")]
    public TaskModel GetById(Guid id)
    {
        return _taskService.GetById(id);
    }

    [HttpDelete("")]
    public bool DeleteById(Guid id)
    {
        return _taskService.DeleteById(id);
    }

    [HttpPut("")]
    public TaskModel EditById([FromQuery] Guid id, [FromBody] TaskModel taskModel)
    {
        return _taskService.EditById(id, taskModel);
    }

    [HttpPost("/insert-tasks")]
    public List<TaskModel> InsertTasks([FromBody] List<TaskModelDTO> taskModels)
    {
        return _taskService.AddMultipleTasks(taskModels);
    }

    [HttpDelete("/delete-tasks")]
    public bool DeleteTasks([FromBody] List<Guid> taskModel)
    {
        return _taskService.DeleteMultipleTasks(taskModel);
    }
}
