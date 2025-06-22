using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.Repository.Interfaces;

public interface ITeamRepository
{
    Task <List<Team>> GetAllTeams();
    
    Task CreateTeam(Team team);
    
    Task UpdateTeam(int id, Team team);
    
    Task DeleteTeam(int id);
    
    Task AddTeamToProject(int teamId, int projectId);
    
}