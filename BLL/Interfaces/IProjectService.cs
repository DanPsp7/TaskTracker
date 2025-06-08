using TaskTracker.BLL.Dto;

namespace TaskTracker.BLL.Interfaces;

public interface IProjectService
{
    Task<ProjectDto> GetProject();
    //Task GetProjectById(int id);
    Task CreateProject(ProjectDto project);
    Task UpdateProject(ProjectDto project);
    Task DeleteProject(ProjectDto project);
}