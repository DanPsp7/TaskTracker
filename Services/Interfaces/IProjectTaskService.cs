using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.Services.Interfaces;

public interface IProjectTaskService
{
    Task<List<ProjectTask>> GetTask();
    //Task GetProjectById(int id);
    Task CreateTask(AddTaskRequest request);
    Task UpdateTask(UpdateTaskRequest request);
    Task DeleteTask(DeleteTaskRequest request);
    Task StartTask(ActionTaskRequest request);
    Task StopTask(ActionTaskRequest request);
    Task DoneTask(ActionTaskRequest request);
    Task AssignTask(AssignTaskRequest request);
    Task AddTaskToProject(TaskToProjectRequest request);
}