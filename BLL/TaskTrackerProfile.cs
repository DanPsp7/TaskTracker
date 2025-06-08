using AutoMapper;
using TaskTracker.BLL.Dto;
using TaskTracker.Models;

namespace TaskTracker.BLL;

public class TaskTrackerProfile : Profile
{
    public TaskTrackerProfile()
    {
        CreateMap<ProjectDto, Project>();
        CreateMap<ProjectTaskDto, ProjectTask>();
        CreateMap<TeamDto, Team>();
        CreateMap<UserDto, User>();
    }

}