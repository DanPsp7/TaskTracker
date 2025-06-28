using TaskTracker.BLL.Dto;
using TaskTracker.Controllers.Contracts;

namespace TaskTracker.BLL.Interfaces;

public interface IProjectService
{
    Task<List<GetProjectRequest>> GetProject();
    //Task GetProjectById(int id);
    Task CreateProject(AddProjectRequest addProjectRequest);
    Task UpdateProject(int id, UpdateProjectRequest updateProjectRequest);
    Task DeleteProject(int id);
}