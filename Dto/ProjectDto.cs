namespace TaskTracker.Dto
{
    public class ProjectDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public ICollection<ProjectTaskDto> ProjectTasksDto { get; set; } = new List<ProjectTaskDto>();

        public ICollection<TeamDto> TeamsDto { get; set; } = new List<TeamDto>();
    }
}