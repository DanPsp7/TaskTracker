namespace TaskTracker.Controllers.Contracts;

public class GetProjectRequest
{
    public int Id { get; set; }
    public string? Name { get; set; }
}