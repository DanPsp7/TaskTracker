using Microsoft.AspNetCore.Mvc;
using TaskTracker.Controllers.Contracts;
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
        public async Task Create([FromBody] AddTaskRequest request)
        {
            await _projectTaskService.CreateTask(request);
        }

        [HttpPut("Update")]
        public async Task Update([FromBody] UpdateTaskRequest request)
        {
            await _projectTaskService.UpdateTask(request);
        }

        [HttpDelete("Delete")]
        public async Task Delete([FromBody] DeleteTaskRequest request)
        {
            await _projectTaskService.DeleteTask(request);
        }

        [HttpPost("Start")]
        public async Task Start([FromBody] ActionTaskRequest request)
        {
            await _projectTaskService.StartTask(request);
        }

        [HttpPost("Stop")]
        public async Task Stop([FromBody] ActionTaskRequest request)
        {
            await _projectTaskService.StopTask(request);
        }

        [HttpPost("Done")]
        public async Task Done([FromBody] ActionTaskRequest request)
        {
            await _projectTaskService.DoneTask(request);
        }

        [HttpPost("Assign")]
        public async Task Assign([FromBody] AssignTaskRequest request)
        {
            await _projectTaskService.AssignTask(request);
        }

        [HttpPost("AddTaskTOProject")]
        public async Task AddTaskToProject([FromBody] TaskToProjectRequest request)
        {
            await _projectTaskService.AddTaskToProject(request);
        }
    }