using TaskTracker.Models;

namespace TaskTracker.Controllers.Contracts;

public class TeamToProjectRequest
{
    public int Id { get; set; }
    public int? ProjectId { get; set; }
    public Project? Project { get; set; }
}