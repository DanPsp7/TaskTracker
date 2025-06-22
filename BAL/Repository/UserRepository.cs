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


    public async Task<List<User>> GetUsers()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task CreateUser(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateUser(int id, User user)
    {
        var users = await _context.Users.FindAsync();
        users.Name = user.Name;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteUser(int id)
    {
        _context.Users.Remove(await _context.Users.FindAsync(id));
        await _context.SaveChangesAsync();
    }

    public async Task AddUserToTeam(int userId, int teamId)
    {
        var users = await _context.Users.FindAsync(userId);
        users.TeamId = teamId;
        await _context.SaveChangesAsync();
    }
    
}