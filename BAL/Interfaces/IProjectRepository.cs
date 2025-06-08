using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.Repository.Interfaces;

public interface IProjectRepository
{
    Task<List<Project>> Get();
    Task Create(Project project);
    Task Update(Project project);
    Task Delete(Project project);
}