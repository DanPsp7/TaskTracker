namespace TaskTracker.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();

        public virtual ICollection<Team> Teams { get; set; } = new List<Team>();
    }
}