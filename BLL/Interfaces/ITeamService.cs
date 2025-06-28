using TaskTracker.BLL.Dto;
using TaskTracker.Controllers.Contracts;

namespace TaskTracker.BLL.Interfaces;

public interface ITeamService
{
    Task<List<GetTeamRequest>> GetTeam();
    //Task GetProjectById(int id);
    Task CreateTeam(AddTeamRequest addTeamRequest);
    Task UpdateTeam(int id, UpdateTeamRequest updateTeamRequest);
    Task DeleteTeam(int id);
    Task AddTeamToProject(int teamId, int projectId);
}