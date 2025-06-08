using TaskTracker.BLL.Dto;
using TaskTracker.Controllers.Contracts;

namespace TaskTracker.BLL.Interfaces;

public interface ITeamService
{
    Task<List<TeamDto>> GetTeam();
    //Task GetProjectById(int id);
    Task CreateTeam(TeamDto teamDto);
    Task UpdateTeam(TeamDto teamDto);
    Task DeleteTeam(TeamDto teamDto);
    Task AddTeamToProject(TeamDto teamDto);
}