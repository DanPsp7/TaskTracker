using AutoMapper;
using TaskTracker.BLL.Dto;
using TaskTracker.BLL.Interfaces;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TaskTracker.BLL.Services;

public class TeamService : ITeamService
{
    private readonly ITeamRepository _teamRepository;
    private readonly IMapper _mapper;
    public TeamService(ITeamRepository teamRepository, IMapper mapper)
    {
        _teamRepository = teamRepository;
        _mapper = mapper;
    }
    
    public async Task<List<TeamDto>> GetTeam()
    {
        var team = await _teamRepository.GetAllTeams();
        return _mapper.Map<List<TeamDto>>(team);
    }

    public async Task CreateTeam(AddTeamRequest teamDto)
    {
        
       //var team = _mapper.Map<Team>(teamDto);
       var team = new()
       {
           Name = teamDto.Name,
       };
        await _teamRepository.CreateTeam(team);
    }

    public async Task UpdateTeam(int id, TeamDto teamDto)
    {   
        var team = _mapper.Map<Team>(teamDto);
        await _teamRepository.UpdateTeam(id, team);
    }

    public async Task DeleteTeam(int id)
    {
        await _teamRepository.DeleteTeam(id);
    }

    public async Task AddTeamToProject(int teamId, int projectId)
    {
        await _teamRepository.AddTeamToProject(teamId, projectId);
    }
}