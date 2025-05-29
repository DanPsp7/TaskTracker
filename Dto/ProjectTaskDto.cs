using System.ComponentModel.DataAnnotations.Schema;

namespace TaskTracker.Dto;

public class ProjectTaskDto
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
        public string? Name { get; set; }
        public string? Description { get; set; }
                
        public TaskStatus Status {  get; set; }

        [Column(TypeName = "time")]
        public TimeSpan SpentTime { get; set; }

        public UserDto? UserDto { get; set; }
        public int? UserDtoId { get; set; }


        public ProjectDto ProjectDto { get; set; } = new ProjectDto(); 
        public int ProjectDtoId { get; set; }

        
    }

}