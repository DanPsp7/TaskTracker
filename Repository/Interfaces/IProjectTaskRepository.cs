using TaskTracker.Dto;
using TaskTracker.Models;

namespace TaskTracker.Repository.Interfaces;

public interface IProjectTaskRepository
{
    Task<List<ProjectTask>> GetTask();
    
    Task CreateTask(ProjectTask task);
    
    Task UpdateTask(int id, ProjectTask task);
    
    Task DeleteTask(int id);
}