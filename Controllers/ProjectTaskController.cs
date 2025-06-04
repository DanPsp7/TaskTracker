using Microsoft.AspNetCore.Mvc;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;
using TaskTracker.Services;
using TaskTracker.Services.Interfaces;

namespace TaskTracker.Controllers;



    [ApiController]
    [Route("[controller]")]
    public class ProjectTaskController : Controller
    {
        private readonly IProjectTaskService _projectTaskService;

        public ProjectTaskController(IProjectTaskService projectTaskService)
        {
            _projectTaskService = projectTaskService;
        }

        [HttpGet("Get")]
        public async Task<List<ProjectTask>> Get()
        {
            return await _projectTaskService.GetTask();
        }

        [HttpPost("Create")]
        public async Task Create(ProjectTask projectTask)
        {
            await _projectTaskService.CreateTask(projectTask);
        }

        [HttpPut("Update")]
        public async Task Update(int id, ProjectTask projectTask)
        {
            await _projectTaskService.UpdateTask(id, projectTask);
        }

        [HttpDelete("Delete")]
        public async Task Delete(int id)
        {
            await _projectTaskService.DeleteTask(id);
        }

        [HttpPost("Start")]
        public async Task Start(int id)
        {
            await _projectTaskService.StartTask(id);
        }

        [HttpPost("Stop")]
        public async Task Stop(int id)
        {
            await _projectTaskService.StopTask(id);
        }

        [HttpPost("Done")]
        public async Task Done(int id)
        {
            await _projectTaskService.DoneTask(id);
        }

        [HttpPost("Assign")]
        public async Task Assign(int id, User user)
        {
            await _projectTaskService.AssignTask(id, user);
        }

        [HttpPost("AddTaskTOProject")]
        public async Task AddTaskToProject(int id, Project project)
        {
            await _projectTaskService.AddTaskToProject(id, project);
        }
    }