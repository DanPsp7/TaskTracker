using AutoMapper;
using TaskTracker.BLL.Dto;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.BLL;

public class TaskTrackerProfile : Profile
{
    public TaskTrackerProfile()
    {
        CreateMap<AddTeamRequest, Team>().ReverseMap();
        CreateMap<AddProjectRequest, Project>().ReverseMap();
        CreateMap<AddTaskRequest, ProjectTask>().ReverseMap();
        CreateMap<AddUserRequest, User>().ReverseMap();
        CreateMap<ActionTaskRequest,ProjectTask>().ReverseMap();
        CreateMap<AssignTaskRequest,ProjectTask>().ReverseMap();
        CreateMap<DeleteProjectRequest,Project>().ReverseMap();
        CreateMap<DeleteTaskRequest,ProjectTask>().ReverseMap();
        CreateMap<DeleteTeamRequest, Team>().ReverseMap();
        CreateMap<DeleteUserRequest, User>().ReverseMap();
        CreateMap<GetProjectRequest, Project>().ReverseMap();
        CreateMap<GetTaskRequest, ProjectTask>().ReverseMap();
        CreateMap<GetUserRequest, User>().ReverseMap();
        CreateMap<GetTeamRequest, Team>().ReverseMap();
        CreateMap<TaskToProjectRequest, ProjectTask>().ReverseMap();
        CreateMap<TeamToProjectRequest, Team>().ReverseMap();
        CreateMap<UpdateTaskRequest, ProjectTask>().ReverseMap();
        CreateMap<UpdateProjectRequest,Project>().ReverseMap();
        CreateMap<UpdateUserRequest, User>().ReverseMap();
        CreateMap<UpdateTeamRequest, Team>().ReverseMap();
        CreateMap<UserToTeamRequest, User>().ReverseMap();

    }

}