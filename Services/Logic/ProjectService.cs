using TaskTracker.Dto;
using TaskTracker.Models;
using TaskTracker.Repository;
using TaskTracker.Repository.Interfaces;

namespace TaskTracker.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;

    public ProjectService(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }

    public async Task CreateProject(Project project)
    {
        await _projectRepository.Create(project);
    }
    
    public async Task<List<Project>> GetProject()
    {
        return await _projectRepository.Get() ;
    }

    public async Task UpdateProject(int id, Project project)
    {
        await _projectRepository.Update(id, project);
    }

    public async Task DeleteProject(int id)
    {
        await _projectRepository.Delete(id);
    }
    
}