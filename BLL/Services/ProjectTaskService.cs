using AutoMapper;
using TaskTracker.BLL.Dto;
using TaskTracker.BLL.Interfaces;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TaskTracker.BLL.Services;

public class ProjectTaskService : IProjectTaskService
{
    private readonly IProjectTaskRepository _projectTaskRepository;
    private readonly IMapper  _mapper;
    public ProjectTaskService(IProjectTaskRepository projectTaskRepository, IMapper mapper)
    {
        _projectTaskRepository = projectTaskRepository;
        _mapper = mapper;
    }


    public async Task<List<GetTaskRequest>> GetTask()
    {
        var projectTask = await _projectTaskRepository.GetTask();
        return _mapper.Map<List<GetTaskRequest>>(projectTask);
    }
    
    public async Task CreateTask(AddTaskRequest addTaskRequest)
    {
        var projectTask = _mapper.Map<ProjectTask>(addTaskRequest);
        
        await  _projectTaskRepository.CreateTask(projectTask);
    }
    
    public async Task UpdateTask (int id,UpdateTaskRequest updateTaskRequest)
    {
        var projectTask = _mapper.Map<ProjectTask>(updateTaskRequest);
        
        await  _projectTaskRepository.UpdateTask(id, projectTask);
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

    public async Task AssignTask(int taskId , int userId)
    {
        await _projectTaskRepository.AssignTask(taskId, userId);
    }

    public async Task AddTaskToProject(int taskId, int projectId)
    {
        await _projectTaskRepository.AddTaskToProject(taskId, projectId);
    }
}