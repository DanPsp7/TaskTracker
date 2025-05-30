using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskTracker.Data;
using TaskTracker.Dto;
using TaskTracker.Models;
using TaskTracker.Services;
using TaskTracker.Services.Interfaces;


namespace TaskTracker.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {

        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        [Route("Get")]
        [Produces("application/json")]
        public async Task<List<Project>> Get()
        {
            return await _projectService.GetProject();
        }


        [HttpPost]
        [Route("Create")]
        public async Task Create(Project projectDto)
        {
            await _projectService.CreateProject(projectDto);
        }

        [HttpPut]
        [Route("Update")]
        public async Task Update(int id, Project projectDto)
        {
            await _projectService.UpdateProject(id, projectDto);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task Delete(int id)
        {
            await _projectService.DeleteProject(id);
        }
    }
}