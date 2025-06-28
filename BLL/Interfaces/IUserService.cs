using TaskTracker.BLL.Dto;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.BLL.Interfaces;

public interface IUserService
{
    Task<List<GetUserRequest>> GetUser();
    //Task GetProjectById(int id);
    Task CreateUser(AddUserRequest addUserRequest);
    Task UpdateUser(int id, UpdateUserRequest updateUserRequest);
    Task DeleteUser(int id);
    Task AddUserToTeam(int userId, int teamId);
}