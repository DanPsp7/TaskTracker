namespace TaskTracker.BLL.Dto;

public class UserDto
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
        
    public int TeamDtoId { get; set; }
    
    public ProjectTaskDto? ProjectTaskDto { get; set; }
}