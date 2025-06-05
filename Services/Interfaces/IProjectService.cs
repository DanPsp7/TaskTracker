using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.Services.Interfaces;

public interface IProjectService
{
    Task<List<Project>> GetProject();
    //Task GetProjectById(int id);
    Task CreateProject(AddProjectRequest request);
    Task UpdateProject(UpdateProjectRequest request);
    Task DeleteProject(DeleteProjectRequest request);
}