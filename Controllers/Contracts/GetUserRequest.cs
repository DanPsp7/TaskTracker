namespace TaskTracker.Controllers.Contracts;

public class GetUserRequest
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}