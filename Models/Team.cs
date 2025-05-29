namespace TaskTracker.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        public int? ProjectId { get; set; }
        public Project? Project { get; set; }

        public virtual ICollection<User> Users { get; set; } = new List<User>();
        
    }
}