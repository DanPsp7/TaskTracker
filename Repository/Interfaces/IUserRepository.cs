using TaskTracker.Dto;
using TaskTracker.Models;

namespace TrackTask.Repository.Interfaces;

public interface IUserRepository
{
    Task <List<User>> GetAllUsers();
    
    Task CreateUser(User user);
    
    Task UpdateUser(int id, User user);
    
    Task DeleteUser(int id);
}