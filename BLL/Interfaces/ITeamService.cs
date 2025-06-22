using TaskTracker.BLL.Dto;
using TaskTracker.Controllers.Contracts;

namespace TaskTracker.BLL.Interfaces;

public interface ITeamService
{
    Task<List<TeamDto>> GetTeam();
    //Task GetProjectById(int id);
    Task CreateTeam(AddTeamRequest teamDto);
    Task UpdateTeam(int id, TeamDto teamDto);
    Task DeleteTeam(int id);
    Task AddTeamToProject(int teamId, int projectId);
}