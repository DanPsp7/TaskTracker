using TaskTracker.Models;

namespace TaskTracker.Controllers.Contracts;

public class UserToTeamRequest
{
    public int Id { get; set; }
    public int TeamId { get; set; }
    public Team Team { get; set; } 
}