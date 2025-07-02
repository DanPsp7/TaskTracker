namespace TaskTracker.Controllers.Contracts;

public class AddTaskRequest
{
    public string? Name { get; set; }
    public string? Description { get; set; }
}