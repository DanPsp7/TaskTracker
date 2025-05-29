using Microsoft.EntityFrameworkCore;
using TaskTracker.Data;
using TaskTracker.Dto;
using TaskTracker.Models;
using TrackTask.Repository.Interfaces;

namespace TrackTask.Repository.Logic;

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
}