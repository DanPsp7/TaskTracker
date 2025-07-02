using Microsoft.EntityFrameworkCore;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Data;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TaskTracker.Repository.Logic;

public class TeamRepository : ITeamRepository
{
    private readonly TaskTrackerContext _context;

    public TeamRepository(TaskTrackerContext context)
    {
        _context = context;
    }


    public async Task<List<Team>> GetAllTeams()
    {
        return await _context.Teams.ToListAsync();
    }

    public async Task CreateTeam(Team team)
    {   
        _context.Teams.Add(team);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateTeam(int id, Team team)
    {
        var teams = await _context.Teams.FindAsync(id);
        if (teams != null)
        {
            teams.Name = team.Name;
        }
        
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTeam(int id)
    {
        _context.Teams.Remove(await _context.Teams.FirstOrDefaultAsync(t => t.Id == id) ?? throw new EntityNotFoundException($"Invalid task id:{id}")); 
        await _context.SaveChangesAsync();
    }

    public async Task AddTeamToProject(int teamId, int projectId)
    {
        var  team = await _context.Teams.FindAsync(teamId);
        team.ProjectId = projectId;
        await _context.SaveChangesAsync();
    }
   
}