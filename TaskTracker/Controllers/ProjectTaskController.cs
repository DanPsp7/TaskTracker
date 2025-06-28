using Microsoft.AspNetCore.Mvc;
using TaskTracker.BLL.Dto;
using TaskTracker.BLL.Interfaces;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;


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
        public async Task<List<GetTaskRequest>> Get()
        {
            return await _projectTaskService.GetTask();
        }

        [HttpPost("Create")]
        public async Task Create([FromBody] AddTaskRequest addTaskRequest)
        {
            await _projectTaskService.CreateTask(addTaskRequest);
        }

        [HttpPut("Update")]
        public async Task Update([FromQuery] int id, [FromBody] UpdateTaskRequest  updateTaskRequest)
        {
            await _projectTaskService.UpdateTask(id, updateTaskRequest);
        }

        [HttpDelete("Delete")]
        public async Task Delete([FromQuery] int id)
        {
            await _projectTaskService.DeleteTask(id);
        }

        [HttpPost("Start")]
        public async Task Start([FromQuery] int id)
        {
            await _projectTaskService.StartTask(id);
        }

        [HttpPost("Stop")]
        public async Task Stop([FromQuery] int id)
        {
            await _projectTaskService.StopTask(id);
        }

        [HttpPost("Done")]
        public async Task Done([FromQuery] int id)
        {
            await _projectTaskService.DoneTask(id);
        }

        [HttpPost("Assign")]
        public async Task Assign([FromQuery] int taskId,[FromQuery] int userId)
        {
            await _projectTaskService.AssignTask(taskId, userId);
        }

        [HttpPost("AddTaskTOProject")]
        public async Task AddTaskToProject([FromQuery] int taskId,[FromQuery] int projectId)
        {
            await _projectTaskService.AddTaskToProject(taskId, projectId);
        }
    }