using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;

namespace TaskTracker.Repository.Interfaces;

public interface IUserRepository
{
    Task <List<User>> GetUsers();
    
    Task CreateUser(User  user);
    
    Task UpdateUser(int id, User user);
    
    Task DeleteUser(int id);
    Task AddUserToTeam(int userId, int teamId);
}