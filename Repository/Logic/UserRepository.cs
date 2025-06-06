using Microsoft.EntityFrameworkCore;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Data;
using TaskTracker.Models;
using TaskTracker.Repository.Interfaces;

namespace TaskTracker.Repository.Logic;

public class UserRepository : IUserRepository
{
    
    private readonly TaskTrackerContext _context;

    public UserRepository(TaskTrackerContext context)
    {
        _context = context;
    }


    public async Task<List<User>> GetAllUsers()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task CreateUser(AddUserRequest request)
    {
        User newUser = new User();
        newUser.Name = request.Name;
        newUser.TeamId = request.TeamId;
        _context.Users.Add(newUser);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateUser(UpdateUserRequest request)
    {
        var users = await _context.Users.FindAsync();
        users.Name = request.Name;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteUser(DeleteUserRequest request)
    {
        _context.Users.Remove(await _context.Users.FindAsync(request.Id));
        await _context.SaveChangesAsync();
    }

    public async Task AddUserToTeam(UserToTeamRequest request)
    {
        var users = await _context.Users.FindAsync(request.Id);
        users.Team = request.Team;
        await _context.SaveChangesAsync();
    }
    
}