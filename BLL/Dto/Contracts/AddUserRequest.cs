using TaskTracker.Models;

namespace TaskTracker.Controllers.Contracts;

public class AddUserRequest
{
    public string Name { get; set; } = null!;
    
    public int TeamId { get; set; }
}