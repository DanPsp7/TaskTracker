using TaskTracker.Models;

namespace TaskTracker.Controllers.Contracts;

public class AssignTaskRequest
{
    public int Id { get; set; }
    public User? User { get; set; }
    public int? UserId { get; set; }
}