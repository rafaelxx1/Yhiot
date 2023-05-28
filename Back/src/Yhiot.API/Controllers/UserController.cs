using Microsoft.AspNetCore.Mvc;
using Yhiot.Persistence;
using Yhiot.Domain;
using Yhiot.Persistence.Context;
using Yhiot.Application.Contract;

namespace Yhiot.API.Controllers;

[ApiController]
[Route("api/user")]

    public class UserController : ControllerBase
    {
       
        private readonly IUserService _userService;

        public UserController(IUserService userService){
            _userService = userService;
            
        }


        [HttpGet]
        public async  Task<IActionResult> Get(){
            try
            {
                var users = await _userService.GetAllUsersAsync();
                if(users == null) return NotFound("User not found");

                return Ok(users);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Error, trying to recover the user. Error: {ex.Message} ");
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id){
            try
            {
                var users = await _userService.GetAllUsersById(id);
                if(users == null) return NotFound("User not found");

                return Ok(users);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Error, trying to recover the user. Error: {ex.Message} ");
            }
        }

        [HttpGet("{name}/name")]
        public async Task<IActionResult> GetByName(string name)
        {
              try
            {
                var users = await _userService.GetAllUsersByNameAsync(name);
                if(users == null) return NotFound("User not found");

                return Ok(users);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError,
                $"Error, trying to recover the user. Error: {ex.Message} ");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(User model)
        {
            try
            {
                var user = await _userService.AddUser(model);
                if (user == null) return BadRequest("Error; trying to add an user");
                return Ok(user);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                $"Error; trying to add an user. Error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, User model)
        {
            try
            {
                var user = await _userService.UpdateUser(id, model);
                if (user == null) return BadRequest("Error, trying to update an user");
                return Ok(user);
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                $"Error, trying to update an user. Error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                return await _userService.DeleteUser(id) ?
                          Ok("Deleted") :
                          BadRequest("User not deleted");
            }
            catch (Exception ex)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, 
                $"Error, trying to delete an user {ex.Message}");
            }

        }


    }
