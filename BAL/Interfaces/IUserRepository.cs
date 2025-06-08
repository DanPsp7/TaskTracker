using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.Repository.Interfaces;

public interface IUserRepository
{
    Task <List<User>> GetAllUsers();
    
    Task CreateUser(AddUserRequest request);
    
    Task UpdateUser(UpdateUserRequest request);
    
    Task DeleteUser(DeleteUserRequest request);
    Task AddUserToTeam(UserToTeamRequest request);
}