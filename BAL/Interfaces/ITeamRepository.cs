using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.Repository.Interfaces;

public interface ITeamRepository
{
    Task <List<Team>> GetAllTeams();
    
    Task CreateTeam(AddTeamRequest request);
    
    Task UpdateTeam(UpdateTeamRequest request);
    
    Task DeleteTeam(DeleteTeamRequest request);
    
    Task AddTeamToProject(TeamToProjectRequest request);
    
}