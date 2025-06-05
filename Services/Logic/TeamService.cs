using TaskTracker.Controllers.Contracts;
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

    public async Task CreateTeam(AddTeamRequest request)
    {
        await _teamRepository.CreateTeam(request);
    }

    public async Task UpdateTeam(UpdateTeamRequest request)
    {
        await _teamRepository.UpdateTeam(request);
    }

    public async Task DeleteTeam(DeleteTeamRequest request)
    {
        await _teamRepository.DeleteTeam(request);
    }

    public async Task AddTeamToProject(TeamToProjectRequest request)
    {
        await _teamRepository.AddTeamToProject(request);
    }
}