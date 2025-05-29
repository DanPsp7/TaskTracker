namespace TaskTracker.Dto;

public class UserDto
{
    public int Id { get; set; }

        
    public string Name { get; set; } = null!;

    public int TeamId { get; set; }
    public TeamDto Team { get; set; } = new TeamDto();

 
    public ProjectTaskDto? ProjectTasks { get; set; }
}