using AutoMapper;
using TaskTracker.BLL.Dto;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.BLL;

public class TaskTrackerProfile : Profile
{
    public TaskTrackerProfile()
    {
        CreateMap<ProjectDto, Project>().ReverseMap();
        CreateMap<ProjectTaskDto, ProjectTask>().ReverseMap();
        CreateMap<TeamDto, Team>().ReverseMap();
        CreateMap<UserDto, User>().ReverseMap();
        CreateMap<AddTeamRequest, Team>().ReverseMap();
    }

}