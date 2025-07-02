using AutoMapper;
using TaskTracker.BLL.Dto;
using TaskTracker.BLL.Interfaces;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TaskTracker.BLL.Services;

public class ProjectService : IProjectService
{
    private readonly IProjectRepository _projectRepository;
    private readonly IMapper _mapper;
    public ProjectService(IProjectRepository projectRepository, IMapper mapper)
    {
        _projectRepository = projectRepository;
        _mapper = mapper;
    }
    public async Task<List<GetProjectRequest>> GetProject()
    {
        
        var projects = await _projectRepository.Get();
        return _mapper.Map<List<GetProjectRequest>>(projects);
    }

    public async Task CreateProject(AddProjectRequest addProjectRequest)
    {
        // Маппим DTO в доменную модель
        var project = _mapper.Map<Project>(addProjectRequest);
        
        // Передаем доменную модель в репозиторий
        await _projectRepository.Create(project);
    }

    public async Task UpdateProject(int id, UpdateProjectRequest updateProjectRequest)
    {
        var project = _mapper.Map<Project>(updateProjectRequest);
        await _projectRepository.Update(id, project);
    }

    public async Task DeleteProject(int id)
    {
        
        await _projectRepository.Delete(id);
    }
}