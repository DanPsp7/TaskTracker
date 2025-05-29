using TaskTracker.Dto;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TaskTracker.Services;

public class ProjectTaskService
{
    private readonly IProjectTaskRepository _projectTaskRepository;

    public ProjectTaskService(IProjectTaskRepository projectTaskRepository)
    {
        _projectTaskRepository = projectTaskRepository;
    }


    public async Task<List<ProjectTask>> GetTask()
    {
        return await _projectTaskRepository.GetTask();
    }
    
    public async Task CreateTask(ProjectTask task)
    {
        await  _projectTaskRepository.CreateTask(task);
    }
    
    public async Task UpdateTask (int id, ProjectTask task)
    {
        await  _projectTaskRepository.UpdateTask(id, task);
    }
    
    public async Task DeleteTask(int id)
    {
        await  _projectTaskRepository.DeleteTask(id);
    }
}