using TaskTracker.BLL.Dto;
using TaskTracker.Models;

namespace TaskTracker.Mapper;

public static class GlobalMapper
{
    public static  List<UserDto> MapUsers(this List<User> users)
    {
        var result = users.Select(x => new UserDto()
        {
            Id = x.Id,
            Name = x.Name,
            TeamId = x.TeamId,
            ProjectTask = new ProjectTaskDto()
            {
                Name = x.ProjectTasks?.Name,
                Description = x.ProjectTasks?.Description,
                Status = x.ProjectTasks.Status,
            },
        }).ToList();
        return result;
    }
}