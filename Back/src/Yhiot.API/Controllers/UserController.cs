using Microsoft.AspNetCore.Mvc;
using Yhiot.API.Data;
using Yhiot.API.Models;

namespace Yhiot.API.Controllers;

[ApiController]
[Route("api/user")]

    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context){
            this._context = context;
        }


        [HttpGet]
        public IEnumerable<User> Get(){
            return _context.users;
        }

    }
