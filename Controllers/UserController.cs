using Microsoft.AspNetCore.Mvc;
using TaskTracker.Models;
using TaskTracker.Services;
using TaskTracker.Services.Interfaces;

namespace TaskTracker.Controllers;


    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller 
    {   
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("Get")]
        public async Task<List<User>> Get()
        {
            return await _userService.GetUser();
        }
        
        [HttpPost]
        [Route("Create ")]
        public async Task Create([FromBody] User user)
        {
            await _userService.CreateUser(user);
        }

        [HttpPut]
        [Route("Update ")]
        public async Task Update(int id, [FromBody] User user)
        {
            await _userService.UpdateUser(id, user);
        }

        [HttpDelete]
        [Route("Delete")]
        public async Task Delete(int id)
        {
            await _userService.DeleteUser(id);
        }

        [HttpPost]
        [Route("AddUserToTeam")]
        public async Task AddUserToTeam(int id, [FromBody] Team team)
        {
            await _userService.AddUserToTeam(id, team);
        }
    }