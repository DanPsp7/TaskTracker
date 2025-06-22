using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.Repository.Interfaces;

public interface IProjectTaskRepository
{
    Task<List<ProjectTask>> GetTask();
    
    Task CreateTask(ProjectTask projectTask);
    
    Task UpdateTask(int id, ProjectTask projectTask);
    
    Task DeleteTask(int id);
    Task StartTask(int id);
    Task StopTask(int id);
    Task DoneTask(int id);
    Task AssignTask(int taskId, int userId);
    Task AddTaskToProject(int taskId, int projectId);
}