using TaskTracker.BLL.Interfaces;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TaskTracker.BLL.Services;

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
    
    public async Task CreateTask(AddTaskRequest request)
    {
        var projectTask = new ProjectTask();
        projectTask.Name = request.Name;
        projectTask.Description = request.Description;
        await  _projectTaskRepository.CreateTask(projectTask);
    }
    
    public async Task UpdateTask (UpdateTaskRequest request)
    {
       
        
        await  _projectTaskRepository.UpdateTask(request);
    }
    
    public async Task DeleteTask(DeleteTaskRequest request)
    {
        await  _projectTaskRepository.DeleteTask(request);
    }

    public async Task StartTask(ActionTaskRequest request)
    {
        await _projectTaskRepository.StartTask(request);
    }

    public async Task StopTask(ActionTaskRequest request)
    {
        await _projectTaskRepository.StopTask(request);
    }

    public async Task DoneTask(ActionTaskRequest request)
    {
        await _projectTaskRepository.DoneTask(request);
    }

    public async Task AssignTask(AssignTaskRequest request)
    {
        await _projectTaskRepository.AssignTask(request);
    }

    public async Task AddTaskToProject(TaskToProjectRequest request)
    {
        await _projectTaskRepository.AddTaskToProject(request);
    }
}