using Microsoft.EntityFrameworkCore;
using TaskTracker.Data;
using TaskTracker.Dto;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

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
}