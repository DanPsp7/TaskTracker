using Microsoft.AspNetCore.Mvc;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;
using TaskTracker.Services;
using TaskTracker.Services.Interfaces;

namespace TaskTracker.Controllers;



    [ApiController]
    [Route("api/[controller]")]
    public class ProjectTaskController : Controller
    {
        private readonly IProjectTaskService _projectTaskService;

        public ProjectTaskController(IProjectTaskService projectTaskService)
        {
            _projectTaskService = projectTaskService;
        }

        [HttpGet]
        [Route("Get")]
        [Produces("application/json")]
        public async Task<List<ProjectTask>> Get()
        {
            return await _projectTaskService.GetTask();
        }

        [HttpPost]
        [Route("Create")]
        public async Task Create(ProjectTask projectTask)
        {
            await _projectTaskService.CreateTask(projectTask);
        }

        [HttpPut]
        [Route("Update")]
        public async Task Update(int id, ProjectTask projectTask)
        {
            await _projectTaskService.UpdateTask(id, projectTask);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task Delete(int id)
        {
            await _projectTaskService.DeleteTask(id);
        }

        [HttpPost]
        [Route("Start")]
        public async Task Start(int id)
        {
            await _projectTaskService.StartTask(id);
        }

        [HttpPost]
        [Route("Stop")]
        public async Task Stop(int id)
        {
            await _projectTaskService.StopTask(id);
        }

        [HttpPost]
        [Route("Done")]
        public async Task Done(int id)
        {
            await _projectTaskService.DoneTask(id);
        }

        [HttpPost]
        [Route("Assign")]
        public async Task Assign(int id, User user)
        {
            await _projectTaskService.AssignTask(id, user);
        }

        [HttpPost]
        [Route("AddTaskTOProject")]
        public async Task AddTaskToProject(int id, Project project)
        {
            await _projectTaskService.AddTaskToProject(id, project);
        }
    }