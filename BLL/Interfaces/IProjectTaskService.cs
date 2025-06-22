using TaskTracker.BLL.Dto;
using TaskTracker.Models;

namespace TaskTracker.BLL.Interfaces;

public interface IProjectTaskService
{
    Task<List<ProjectTaskDto>> GetTask();
    //Task GetProjectById(int id);
    Task CreateTask(ProjectTaskDto  projectTaskDto);
    Task UpdateTask(int id, ProjectTaskDto  projectTaskDto);
    Task DeleteTask(int id);
    Task StartTask(int id);
    Task StopTask(int id);
    Task DoneTask(int id);
    Task AssignTask(int taskId, int projectId);
    Task AddTaskToProject(int taskId, int projectId);
}