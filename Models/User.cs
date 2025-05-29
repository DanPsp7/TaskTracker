using System.ComponentModel.DataAnnotations;

namespace TaskTracker.Models
{
    public class User
    {
        public int Id { get; set; }

        
        public string Name { get; set; } = null!;

        public int TeamId { get; set; }
        public Team Team { get; set; } = new Team();

 
        public ProjectTask? ProjectTasks { get; set; }
        
    }
}