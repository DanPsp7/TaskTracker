using Microsoft.EntityFrameworkCore;
using TaskTracker.Data;
using TaskTracker.Dto;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TrackTask.Repository.Logic;

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
        teams.Name = team.Name;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTeam(int id)
    {
        _context.Remove(await _context.Teams.SingleOrDefaultAsync(t => t.Id == id));
    }
}