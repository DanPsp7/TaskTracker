using Microsoft.AspNetCore.Mvc;
using TaskTracker.BLL.Interfaces;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;
using TaskTracker.Services;

namespace TaskTracker.Controllers;


    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller 
    {   
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("Get")]
        public async Task<List<User>> Get()
        {
            return await _userService.GetUser();
        }
        
        [HttpPost("Create")]
        public async Task Create([FromBody] AddUserRequest request)
        {
            await _userService.CreateUser(request);
        }

        [HttpPut("Update")]
        public async Task Update([FromBody] UpdateUserRequest request)
        {
            await _userService.UpdateUser(request);
        }

        [HttpDelete("Delete")]
        public async Task Delete([FromBody] DeleteUserRequest request)
        {
            await _userService.DeleteUser(request);
        }

        [HttpPost("AddUserToTeam")]
        public async Task AddUserToTeam([FromBody] UserToTeamRequest request)
        {
            await _userService.AddUserToTeam(request);
        }
    }