using System.ComponentModel.DataAnnotations.Schema;

namespace TaskTracker.BLL.Dto;

public class ProjectTaskDto
{
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
                
        public TaskStatus Status {  get; set; }

        [Column(TypeName = "time")]
        public TimeSpan SpentTime { get; set; }

        public int? UserDtoId { get; set; }
        
        public int ProjectDtoId { get; set; }

}