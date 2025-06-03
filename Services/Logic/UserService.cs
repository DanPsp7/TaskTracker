using TaskTracker.Models;
using TaskTracker.Services.Interfaces;
using TrackTask.Repository.Interfaces;

namespace TaskTracker.Services.Logic;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<User>> GetUser()
    {
        return await _userRepository.GetAllUsers();
    }

    public async Task CreateUser(User user)
    {
        await _userRepository.CreateUser(user);
    }

    public async Task UpdateUser(int id, User user)
    {
        await _userRepository.UpdateUser(id, user);
    }

    public async Task DeleteUser(int id)
    {
        await _userRepository.DeleteUser(id);
    }

    public async Task AddUserToTeam(int id, Team team)
    {
        await _userRepository.AddUserToTeam(id, team);
    }
}