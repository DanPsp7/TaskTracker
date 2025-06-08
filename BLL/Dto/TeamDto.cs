namespace TaskTracker.BLL.Dto;

public class TeamDto
{
    public int Id { get; set; }
    
    public string? Name { get; set; }

    public int? ProjectDtoId { get; set; }
  
    public virtual ICollection<UserDto> UsersDto { get; set; } = new List<UserDto>();

}