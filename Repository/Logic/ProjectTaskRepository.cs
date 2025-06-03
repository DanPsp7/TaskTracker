using Microsoft.EntityFrameworkCore;
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

    public async Task CreateTask(ProjectTask task)
    {
        await _context.ProjectTasks.AddAsync(task);
        task.Status = TaskStatus.Free;
        await _context.SaveChangesAsync();

    }

    public async Task UpdateTask(int id, ProjectTask task)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == id);
        tasks.Name = task.Name;
        tasks.Description = task.Description;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTask(int id)
    {
        _context.ProjectTasks.Remove(await _context.ProjectTasks.FirstOrDefaultAsync(t => t.Id == id)); 
        await _context.SaveChangesAsync();
    }

    public async Task StartTask(int id)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == id);
        tasks.Status = TaskStatus.Working;
        var startTime = DateTime.Now;
        tasks.SpentTime = startTime.TimeOfDay;
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

    public async Task AssignTask(int id, User user)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == id);
        tasks.User =  user;
        await _context.SaveChangesAsync();
    }

    public async Task AddTaskToProject(int id, Project project)
    {
        var tasks = _context.ProjectTasks.FirstOrDefault(t => t.Id == id);
        tasks.Project = project;
        await _context.SaveChangesAsync();
    }

    
}