using TaskTracker.Models;

namespace TaskTracker.Services.Interfaces;

public interface IUserService
{
    Task<List<User>> GetUser();
    //Task GetProjectById(int id);
    Task CreateUser(User user);
    Task UpdateUser(int id, User user);
    Task DeleteUser(int id);
}