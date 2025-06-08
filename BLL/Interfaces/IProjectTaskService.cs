using TaskTracker.BLL.Dto;
using TaskTracker.Models;

namespace TaskTracker.BLL.Interfaces;

public interface IProjectTaskService
{
    Task<List<ProjectTask>> GetTask();
    //Task GetProjectById(int id);
    Task CreateTask(ProjectTaskDto  projectTaskDto);
    Task UpdateTask(ProjectTaskDto  projectTaskDto);
    Task DeleteTask(ProjectTaskDto  projectTaskDto);
    Task StartTask(ProjectTaskDto  projectTaskDto);
    Task StopTask(ProjectTaskDto  projectTaskDto);
    Task DoneTask(ProjectTaskDto  projectTaskDto);
    Task AssignTask(ProjectTaskDto  projectTaskDto);
    Task AddTaskToProject(ProjectTaskDto  projectTaskDto);
}