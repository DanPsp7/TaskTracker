using TaskTracker.Models;

namespace TaskTracker.Controllers.Contracts;

public class TaskToProjectRequest
{
    public int Id { get; set; }
    public Project Project { get; set; } = new Project(); 
    public int ProjectId { get; set; }

}