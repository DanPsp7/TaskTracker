using Microsoft.AspNetCore.Mvc;
using TaskTracker.BLL.Interfaces;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;
using TaskTracker.Services;

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
        public async Task Create([FromBody] AddTeamRequest request)
        {
            await _teamService.CreateTeam(request);
        }

        [HttpPut("Update")]
        public async Task Update([FromBody]  UpdateTeamRequest request)
        {
            await _teamService.UpdateTeam(request);
        }

        [HttpDelete("Delete")]
        public async Task Delete([FromBody] DeleteTeamRequest request)
        {
            await _teamService.DeleteTeam(request);
        }

        [HttpPost("AddTeamToProject")]
        public async Task AddTeamToProject([FromBody] TeamToProjectRequest request)
        {
            await _teamService.AddTeamToProject(request);
        }
    }