using TaskTracker.BLL.Dto;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.BLL.Interfaces;

public interface IProjectTaskService
{
    Task<List<GetTaskRequest>> GetTask();
    //Task GetProjectById(int id);
    Task CreateTask(AddTaskRequest addTaskRequest);
    Task UpdateTask(int id, UpdateTaskRequest updateTaskRequest);
    Task DeleteTask(int id);
    Task StartTask(int id);
    Task StopTask(int id);
    Task DoneTask(int id);
    Task AssignTask(int taskId, int projectId);
    Task AddTaskToProject(int taskId, int projectId);
}