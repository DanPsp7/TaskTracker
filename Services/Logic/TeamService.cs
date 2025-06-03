using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;
using TaskTracker.Services.Interfaces;

namespace TaskTracker.Services.Logic;

public class TeamService : ITeamService
{
    private readonly ITeamRepository _teamRepository;

    public TeamService(ITeamRepository teamRepository)
    {
        _teamRepository = teamRepository;
    }

    public async Task<List<Team>> GetTeam()
    {
        return await _teamRepository.GetAllTeams();
    }

    public async Task CreateTeam(Team team)
    {
        await _teamRepository.CreateTeam(team);
    }

    public async Task UpdateTeam(int id, Team team)
    {
        await _teamRepository.UpdateTeam(id, team);
    }

    public async Task DeleteTeam(int id)
    {
        await _teamRepository.DeleteTeam(id);
    }

    public async Task AddTeamToProject(int id, Project project)
    {
        await _teamRepository.AddTeamToProject(id, project);
    }
}