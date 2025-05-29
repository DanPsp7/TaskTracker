using TaskTracker.Models;

namespace TaskTracker.Services;

public interface ITeamService
{
    Task<List<Team>> GetTeam();
    //Task GetProjectById(int id);
    Task CreateTeam(Team team);
    Task UpdateTeam(int id, Team team);
    Task DeleteTeam(int id);
}