using TaskTracker.Controllers.Contracts;
using TaskTracker.Dto;
using TaskTracker.Models;

namespace TaskTracker.Repository.Interfaces;

public interface IProjectTaskRepository
{
    Task<List<ProjectTask>> GetTask();
    
    Task CreateTask(ProjectTask projectTask);
    
    Task UpdateTask(UpdateTaskRequest request);
    
    Task DeleteTask(DeleteTaskRequest request);
    Task StartTask(ActionTaskRequest request);
    Task StopTask(ActionTaskRequest request);
    Task DoneTask(ActionTaskRequest request);
    Task AssignTask(AssignTaskRequest request);
    Task AddTaskToProject(TaskToProjectRequest request);
}