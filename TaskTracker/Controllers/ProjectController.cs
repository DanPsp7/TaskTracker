using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskTracker.BLL.Interfaces;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Data;
using TaskTracker.Models;
using TaskTracker.Services;


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
        public async Task<List<Project>> Get()
        {
            return await _projectService.GetProject();
        }


        [HttpPost("Create")]
        public async Task Create([FromBody] AddProjectRequest request)
        {
            await _projectService.CreateProject(request);
        }

        [HttpPut("Update")]
        public async Task Update([FromBody] UpdateProjectRequest request)
        {
            await _projectService.UpdateProject(request);
        }

        [HttpDelete("Delete")]
        public async Task Delete([FromBody] DeleteProjectRequest request)
        {
            await _projectService.DeleteProject(request);
        }
    }
}