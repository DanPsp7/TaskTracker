using TaskTracker.Controllers.Contracts;
using TaskTracker.Dto;
using TaskTracker.Models;

namespace TaskTracker.Repository.Interfaces;

public interface IProjectRepository
{
    Task<List<Project>> Get();
    Task Create(AddProjectRequest request);
    Task Update(UpdateProjectRequest request);
    Task Delete(DeleteProjectRequest request);
}