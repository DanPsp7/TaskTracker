using TaskTracker.Models;

namespace TaskTracker.Controllers.Contracts;

public class GetUserRequest
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    
    public int teamId { get; set; } 
    
    public int taskId { get; set; }
}