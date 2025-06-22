using TaskTracker.BLL.Dto;

namespace TaskTracker.BLL.Interfaces;

public interface IProjectService
{
    Task<List<ProjectDto>> GetProject();
    //Task GetProjectById(int id);
    Task CreateProject(ProjectDto project);
    Task UpdateProject(int id, ProjectDto project);
    Task DeleteProject(int id);
}