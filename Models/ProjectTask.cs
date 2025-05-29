using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using TaskTracker.Models;

namespace TaskTracker.Models
{
    public enum TaskStatus
    {
        Free,       // Задача свободна
        Working,    // В работе
        Done,       // Завершена
        Paused,     // Приостановлена
        Cancelled   // Отменена
    }


    public class ProjectTask

    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
                
        public TaskStatus Status {  get; set; }

        [Column(TypeName = "time")]
        public TimeSpan SpentTime { get; set; }

        public User? User { get; set; }
        public int? UserId { get; set; }


        public Project Project { get; set; } = new Project(); 
        public int ProjectId { get; set; }

        
    }
    
}