namespace TaskTracker.Controllers.Contracts;

public class AddUserRequest
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
}