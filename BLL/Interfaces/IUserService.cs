using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.BLL.Interfaces;

public interface IUserService
{
    Task<List<User>> GetUser();
    //Task GetProjectById(int id);
    Task CreateUser(AddUserRequest request);
    Task UpdateUser(UpdateUserRequest request);
    Task DeleteUser(DeleteUserRequest request);
    Task AddUserToTeam(UserToTeamRequest request);
}