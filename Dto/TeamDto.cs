namespace TaskTracker.Dto;

public class TeamDto
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public int? ProjectId { get; set; }
    public ProjectDto? Project { get; set; }

    public virtual ICollection<UserDto> UsersDto { get; set; } = new List<UserDto>();

}