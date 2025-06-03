using TaskTracker.Models;

namespace TaskTracker.Services.Interfaces;

public interface IProjectTaskService
{
    Task<List<ProjectTask>> GetTask();
    //Task GetProjectById(int id);
    Task CreateTask(ProjectTask projectTask);
    Task UpdateTask(int id, ProjectTask projectTask);
    Task DeleteTask(int id);
    Task StartTask(int id);
    Task StopTask(int id);
    Task DoneTask(int id);
    Task AssignTask(int id, User user);
    Task AddTaskToProject(int id, Project project);
}