using TaskTracker.Models;

namespace TaskTracker.Services.Interfaces;

public interface IProjectService
{
    Task<List<Project>> GetProject();
    //Task GetProjectById(int id);
    Task CreateProject(Project project);
    Task UpdateProject(int id, Project project);
    Task DeleteProject(int id);
}