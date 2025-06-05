using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.Services.Interfaces;

public interface ITeamService
{
    Task<List<Team>> GetTeam();
    //Task GetProjectById(int id);
    Task CreateTeam(AddTeamRequest request);
    Task UpdateTeam(UpdateTeamRequest request);
    Task DeleteTeam(DeleteTeamRequest request);
    Task AddTeamToProject(TeamToProjectRequest request);
}