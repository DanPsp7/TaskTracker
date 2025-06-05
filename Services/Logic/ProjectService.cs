using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;
using TaskTracker.Services.Interfaces;

namespace TaskTracker.Services.Logic;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }
    public async Task<List<Project>> GetProject()
    {
        return await _projectRepository.Get();
    }

    public async Task CreateProject(AddProjectRequest request)
    {
        await _projectRepository.Create(request);
    }

    public async Task UpdateProject(UpdateProjectRequest request)
    {
        await _projectRepository.Update(request);
    }

    public async Task DeleteProject(DeleteProjectRequest request)
    {
        await _projectRepository.Delete(request);
    }
}