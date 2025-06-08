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
    public async Task<ProjectDto> GetProject()
    {
        
        var projects = await _projectRepository.Get();
        return _mapper.Map<ProjectDto>(projects);
    }

    public async Task CreateProject(ProjectDto projectDto)
    {
        // Маппим DTO в доменную модель
        var project = _mapper.Map<Project>(projectDto);
        
        // Передаем доменную модель в репозиторий
        await _projectRepository.Create(project);
    }

    public async Task UpdateProject()
    {
        await _projectRepository.Update();
    }

    public async Task DeleteProject()
    {
        await _projectRepository.Delete();
    }
}