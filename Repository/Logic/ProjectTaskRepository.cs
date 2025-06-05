using Microsoft.EntityFrameworkCore;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Data;
using TaskTracker.Dto;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;
using TaskStatus = TaskTracker.Models.TaskStatus;

namespace TaskTracker.Repository.Logic;

public class ProjectTaskRepository : IProjectTaskRepository
{
    private readonly TaskTrackerContext _context;

    public ProjectTaskRepository(TaskTrackerContext context)
    {
        _context = context; 
    }

    public async Task<List<ProjectTask>> GetTask()
    {
        return await _context.ProjectTasks.ToListAsync();
    }

    public async Task CreateTask(ProjectTask projectTask)
    {
        _context.ProjectTasks.Add(projectTask);
        projectTask.Status = TaskStatus.Free;
        await _context.SaveChangesAsync();
    }

    public async Task UpdateTask(UpdateTaskRequest request)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == request.Id);
        tasks.Name = request.Name;
        tasks.Description = request.Description;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTask(DeleteTaskRequest request)
    {
        _context.ProjectTasks.Remove(await _context.ProjectTasks.FirstOrDefaultAsync(t => t.Id == request.Id)); 
        await _context.SaveChangesAsync();
    }

    public async Task StartTask(ActionTaskRequest request)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == request.Id);
        tasks.Status = TaskStatus.Working;
        var startTime = DateTime.Now;
        tasks.SpentTime = startTime.TimeOfDay;
        await _context.SaveChangesAsync();
    }

    public async Task StopTask(ActionTaskRequest request)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == request.Id);
        tasks.Status = TaskStatus.Paused;
        var stopTime = DateTime.Now;
        tasks.SpentTime = stopTime.TimeOfDay - tasks.SpentTime;
        await _context.SaveChangesAsync();
    }

    public async Task DoneTask(ActionTaskRequest request)
    {
        var  tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == request.Id);
        tasks.Status = TaskStatus.Done;
        var doneTime = DateTime.Now;
        tasks.SpentTime = doneTime.TimeOfDay - tasks.SpentTime;
        await _context.SaveChangesAsync();
    }

    public async Task AssignTask(AssignTaskRequest request)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == request.Id);
        tasks.User =  request.User;
        await _context.SaveChangesAsync();
    }

    public async Task AddTaskToProject(TaskToProjectRequest request)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == request.Id);
        tasks.Project = request.Project;
        await _context.SaveChangesAsync();
    }

    
}