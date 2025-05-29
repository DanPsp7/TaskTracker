using Microsoft.EntityFrameworkCore;
using TaskTracker.Data;
using TaskTracker.Dto;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TrackTask.Repository.Logic;

public class ProjectRepository : IProjectRepository
{
    private readonly TaskTrackerContext _context;

    public ProjectRepository(TaskTrackerContext context)
    {
        _context = context; 
    }

    public async Task Create(Project project)
    {
        _context.Add(project);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Project>> Get()
    {
        return await _context.Projects.ToListAsync();
    }

    public async Task Update(int id, Project project)
    {
        var projects = await _context.Projects.SingleOrDefaultAsync(p => p.Id == id);
        projects.Name = project.Name;
        projects.Description = project.Description;
        await _context.SaveChangesAsync();
        
    }

    public async Task Delete(int id)
    {
        _context.Remove(await _context.Projects.FindAsync(id));
        await _context.SaveChangesAsync();
    }
}