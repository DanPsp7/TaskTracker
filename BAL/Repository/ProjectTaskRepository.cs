using Microsoft.EntityFrameworkCore;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Data;
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

    public async Task UpdateTask(int id,  ProjectTask projectTask)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == id);
        if (tasks != null)
        {
            tasks.Name = projectTask.Name;
            tasks.Description = projectTask.Description;
        }

        await _context.SaveChangesAsync();
    }

    public async Task DeleteTask(int id)
    {
        _context.ProjectTasks.Remove(await _context.ProjectTasks.FirstOrDefaultAsync(t => t.Id == id) ?? throw new EntityNotFoundException($"Invalid task id:{id}")); 
        await _context.SaveChangesAsync();
    }

    public async Task StartTask(int id)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == id);
        if (tasks != null)
        {
            tasks.Status = TaskStatus.Working;
            var startTime = DateTime.Now;
            tasks.SpentTime = startTime.TimeOfDay;
        }

        await _context.SaveChangesAsync();
    }

    public async Task StopTask(int id)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == id);
        tasks.Status = TaskStatus.Paused;
        var stopTime = DateTime.Now;
        tasks.SpentTime = stopTime.TimeOfDay - tasks.SpentTime;
        await _context.SaveChangesAsync();
    }

    public async Task DoneTask(int id)
    {
        var  tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == id);
        tasks.Status = TaskStatus.Done;
        var doneTime = DateTime.Now;
        tasks.SpentTime = doneTime.TimeOfDay - tasks.SpentTime;
        await _context.SaveChangesAsync();
    }

    public async Task AssignTask(int taskId, int userId)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == taskId);
        tasks.UserId =  userId;
        await _context.SaveChangesAsync();
    }

    public async Task AddTaskToProject(int taskId, int projectId)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == taskId);
        tasks.ProjectId = projectId;
        await _context.SaveChangesAsync();
    }

    
}