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

    public async Task CreateTeam(AddTeamRequest request)
    {   
        Team team = new Team();
        team.Name = request.Name;
        _context.Teams.Add(team);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateTeam(UpdateTeamRequest request)
    {
        var teams = await _context.Teams.FindAsync(request.Id);
        teams.Name = request.Name;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteTeam(DeleteTeamRequest request)
    {
        _context.Remove(await _context.Teams.SingleOrDefaultAsync(t => t.Id == request.Id));
    }

    public async Task AddTeamToProject(TeamToProjectRequest request)
    {
        var  teams = await _context.Teams.FindAsync(request.Id);
        teams.Project = request.Project;
        await _context.SaveChangesAsync();
    }
   
}