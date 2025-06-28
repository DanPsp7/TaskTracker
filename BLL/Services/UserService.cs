using AutoMapper;
using TaskTracker.BLL.Dto;
using TaskTracker.BLL.Interfaces;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TaskTracker.BLL.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    public UserService(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }

    public async Task<List<GetUserRequest>> GetUser()
    {
        var users= await _userRepository.GetUsers();
        return _mapper.Map<List<GetUserRequest>>(users);
    }

    public async Task CreateUser(AddUserRequest addUserRequest)
    {
        var  user = _mapper.Map<User>(addUserRequest);
        await _userRepository.CreateUser(user);
    }

    public async Task UpdateUser(int id, UpdateUserRequest updateUserRequest)
    {
        var user = _mapper.Map<User>(updateUserRequest);
        await _userRepository.UpdateUser(id, user);
    }

    public async Task DeleteUser(int id)
    {
        await _userRepository.DeleteUser(id);
    }

    public async Task AddUserToTeam(int userId, int teamId)
    {
        await _userRepository.AddUserToTeam(userId, teamId);
    }
}