using TaskTracker.Models;
using TrackTask.Repository.Interfaces;

namespace TaskTracker.Services.Logic;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<List<User>> GetUser()
    {
        throw new NotImplementedException();
    }

    public Task CreateUser(User user)
    {
        throw new NotImplementedException();
    }

    public Task UpdateUser(int id, User user)
    {
        throw new NotImplementedException();
    }

    public Task DeleteUser(int id)
    {
        throw new NotImplementedException();
    }
}