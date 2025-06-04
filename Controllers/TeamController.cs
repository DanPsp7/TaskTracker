using Microsoft.AspNetCore.Mvc;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;
using TaskTracker.Services;
using TaskTracker.Services.Interfaces;

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
        public async Task<List<Team>> Get()
        {
            return await _teamService.GetTeam();
        }

        [HttpPost("Create")]
        public async Task Create([FromBody] Team team)
        {
            await _teamService.CreateTeam(team);
        }

        [HttpPut("Update")]
        public async Task Update(int id, [FromBody] Team team)
        {
            await _teamService.UpdateTeam(id, team);
        }

        [HttpDelete("Delete")]
        public async Task Delete(int id)
        {
            await _teamService.DeleteTeam(id);
        }

        [HttpPost("AddTeamToProject")]
        public async Task AddTeamToProject(int id, [FromBody] Project project)
        {
            await _teamService.AddTeamToProject(id, project);
        }
    }