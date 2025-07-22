using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Store.Infrastructure;
using Store.Domain;
using Store.Application.IServices;
using Store.Domain.Models;

namespace Store.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserSRV _iUserSRV;

        public UserController(IUserSRV iUserSRV)
        {
            _iUserSRV = iUserSRV;
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _iUserSRV.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUserDetail(int id) {
            var user = _iUserSRV.GetUserDetail(id);

            return Ok(user);
        }

        [HttpPost]
        public IActionResult AddUser(UserModel model)
        {
            var result = _iUserSRV.AddUser(model);

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var msg = _iUserSRV.DeleteUser(id);
            return Ok(new {message = msg});
        }

    }
}
