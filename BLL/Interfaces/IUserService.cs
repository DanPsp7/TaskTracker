using TaskTracker.BLL.Dto;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.BLL.Interfaces;

public interface IUserService
{
    Task<List<UserDto>> GetUser();
    //Task GetProjectById(int id);
    Task CreateUser(UserDto userDto);
    Task UpdateUser(int id, UserDto userDto);
    Task DeleteUser(int id);
    Task AddUserToTeam(int userId, int teamId);
}