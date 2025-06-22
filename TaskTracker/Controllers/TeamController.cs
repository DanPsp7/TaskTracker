using Microsoft.AspNetCore.Mvc;
using TaskTracker.BLL.Dto;
using TaskTracker.BLL.Interfaces;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;


namespace TaskTracker.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class TeamController : Controller
    {
        private readonly ITeamService  _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet("Get")]
        public async Task<List<TeamDto>> Get()
        {
            return await _teamService.GetTeam();
        }

        [HttpPost("Create")]
        public async Task Create([FromBody] AddTeamRequest teamDto)
        {
            await _teamService.CreateTeam(teamDto);
        }

        [HttpPut("Update")]
        public async Task Update([FromQuery] int id, [FromBody] TeamDto teamDto)
        {
            await _teamService.UpdateTeam(id, teamDto);
        }

        [HttpDelete("Delete")]
        public async Task Delete([FromQuery] int id)
        {
            await _teamService.DeleteTeam(id);
        }

        [HttpPost("AddTeamToProject")]
        public async Task AddTeamToProject([FromQuery] int teamId,[FromQuery] int projectId)
        {
            await _teamService.AddTeamToProject(teamId, projectId);
        }
    }