using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;
using TaskTracker.Services.Interfaces;

namespace TaskTracker.Services.Logic;

public class ProjectTaskService : IProjectTaskService
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

    public async Task StartTask(int id)
    {
        await _projectTaskRepository.StartTask(id);
    }

    public async Task StopTask(int id)
    {
        await _projectTaskRepository.StopTask(id);
    }

    public async Task DoneTask(int id)
    {
        await _projectTaskRepository.DoneTask(id);
    }

    public async Task AssignTask(int id, User user)
    {
        await _projectTaskRepository.AssignTask(id, user);
    }

    public async Task AddTaskToProject(int id, Project project)
    {
        await _projectTaskRepository.AddTaskToProject(id, project);
    }
}