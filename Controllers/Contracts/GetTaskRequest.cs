using System.ComponentModel.DataAnnotations.Schema;

namespace TaskTracker.Controllers.Contracts;

public class GetTaskRequest
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
                
    public TaskStatus Status {  get; set; }

    [Column(TypeName = "time")]
    public TimeSpan SpentTime { get; set; }
}