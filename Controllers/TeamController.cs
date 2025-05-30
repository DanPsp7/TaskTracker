using Microsoft.AspNetCore.Mvc;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;
using TaskTracker.Services;
using TaskTracker.Services.Interfaces;

namespace TaskTracker.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class TeamController : Controller
    {
        private readonly ITeamService  _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<List<Team>> Get()
        {
            return await _teamService.GetTeam();
        }

        [HttpPost]
        [Route("Create")]
        public async Task Create([FromBody] Team team)
        {
            await _teamService.CreateTeam(team);
        }

        [HttpPut]
        [Route("Update")]
        public async Task Update(int id, [FromBody] Team team)
        {
            await _teamService.UpdateTeam(id, team);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task Delete(int id)
        {
            await _teamService.DeleteTeam(id);
        }
        
    }