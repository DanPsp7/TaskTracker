namespace TaskTracker.Controllers.Contracts;

public class UpdateUserRequest
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}