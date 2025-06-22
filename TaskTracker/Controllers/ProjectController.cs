using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskTracker.BLL.Dto;
using TaskTracker.BLL.Interfaces;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Data;
using TaskTracker.Models;


namespace TaskTracker.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : Controller
    {

        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet("Get")]
        public async Task<List<ProjectDto>> Get()
        {
            return await _projectService.GetProject();
        }


        [HttpPost("Create")]
        public async Task Create([FromBody] ProjectDto projectDto)
        {
            await _projectService.CreateProject(projectDto);
        }

        [HttpPut("Update")]
        public async Task Update(
            [FromQuery] int id,
            [FromBody] ProjectDto projectDto)
        {
            await _projectService.UpdateProject(id, projectDto);
        }

        [HttpDelete("Delete")]
        public async Task Delete([FromQuery] int id)
        {
            await _projectService.DeleteProject(id);
        }
    }
}