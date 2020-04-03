using System;
using System.Threading.Tasks;
using BLL.Abstractions;
using BLL.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Vodafon_Red.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost("Register")]
        public async Task<Object> PostUser(UserDto model)
        {
            try
            {
                var result = await _userService.PostUser(model);
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
