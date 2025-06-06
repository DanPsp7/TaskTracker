using TaskTracker.Controllers.Contracts;
using TaskTracker.Dto;
using TaskTracker.Mapper;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;
using TaskTracker.Services.Interfaces;

namespace TaskTracker.Services.Logic;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<UserDto>> GetUser()
    {
        var users= await _userRepository.GetAllUsers();
        return users.MapUsers();
    }

    public async Task CreateUser(AddUserRequest request)
    {
        await _userRepository.CreateUser(request);
    }

    public async Task UpdateUser(UpdateUserRequest request)
    {
        await _userRepository.UpdateUser(request);
    }

    public async Task DeleteUser(DeleteUserRequest request)
    {
        await _userRepository.DeleteUser(request);
    }

    public async Task AddUserToTeam(UserToTeamRequest request)
    {
        await _userRepository.AddUserToTeam(request);
    }
}