using TaskTracker.Models;

namespace TaskTracker.Services;

public interface IProjectTaskService
{
    Task<List<ProjectTask>> GetTask();
    //Task GetProjectById(int id);
    Task CreateTask(ProjectTask projectTask);
    Task UpdateTask(int id, Project projectTask);
    Task DeleteTask(int id);
}