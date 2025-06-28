using Microsoft.AspNetCore.Mvc;
using TaskTracker.BLL.Dto;
using TaskTracker.BLL.Interfaces;
using TaskTracker.Controllers.Contracts;
using TaskTracker.Models;


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
        public async Task<List<GetUserRequest>> Get()
        {
            return await _userService.GetUser();
        }
        
        [HttpPost("Create")]
        public async Task Create([FromBody] AddUserRequest addUserRequest)
        {
            await _userService.CreateUser(addUserRequest);
        }

        [HttpPut("Update")]
        public async Task Update([FromQuery] int id,[FromBody] UpdateUserRequest updateUserRequest)
        {
            await _userService.UpdateUser(id, updateUserRequest);
        }

        [HttpDelete("Delete")]
        public async Task Delete([FromQuery]int id)
        {
            await _userService.DeleteUser(id);
        }

        [HttpPost("AddUserToTeam")]
        public async Task AddUserToTeam([FromQuery]int userId,[FromQuery] int  teamId)
        {
            await _userService.AddUserToTeam(userId, teamId);
        }
    }