using TaskTracker.Dto;
using TaskTracker.Models;

namespace TaskTracker.Repository.Interfaces;

public interface IProjectRepository
{
    Task<List<Project>> Get();
    Task Create(Project project);
    Task Update(int id, Project project);
    Task Delete(int id);
}