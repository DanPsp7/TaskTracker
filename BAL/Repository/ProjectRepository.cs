using Microsoft.EntityFrameworkCore;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Data;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TaskTracker.Repository.Logic;

public class ProjectRepository : IProjectRepository
{
    private readonly TaskTrackerContext _context;

    public ProjectRepository(TaskTrackerContext context)
    {
        _context = context; 
    }

    public async Task Create(AddProjectRequest request)
    {
        _context.Add(request);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Project>> Get()
    {
        return await _context.Projects.ToListAsync();
    }

    public async Task Update(UpdateProjectRequest request)
    {
        var projects = await _context.Projects.SingleOrDefaultAsync(p => p.Id == request.Id);
        projects.Name = request.Name;
        projects.Description = request.Description;
        await _context.SaveChangesAsync();
        
    }

    public async Task Delete(DeleteProjectRequest request)
    {
        _context.Remove(await _context.Projects.FindAsync(request.Id));
        await _context.SaveChangesAsync();
    }
}