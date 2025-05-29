using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TaskTracker.Services.Logic;

public class TeamService : ITeamService
{
    private readonly ITeamRepository _teamRepository;

    public TeamService(ITeamRepository teamRepository)
    {
        _teamRepository = teamRepository;
    }

    public Task<List<Team>> GetTeam()
    {
        throw new NotImplementedException();
    }

    public Task CreateTeam(Team team)
    {
        throw new NotImplementedException();
    }

    public Task UpdateTeam(int id, Team team)
    {
        throw new NotImplementedException();
    }

    public Task DeleteTeam(int id)
    {
        throw new NotImplementedException();
    }
}