using Application.DTOs;
using Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApi.Auth;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly JwtTokenService _jwtTokenService;

        public AuthController(IUserService userService, JwtTokenService jwtTokenService)
        {
            _userService = userService;
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await _userService.Authenticate(model.UserName, model.Password);
            if (user == null)
            {
                return BadRequest($"Podano błędny login lub hasło");
            }

            var token = _jwtTokenService.GenerateJwtToken(user);
            return Ok(new
            {
                User = user, /// tylko do testów
                Token = token, /// normalnie tylko to
            });
        }

        [HttpGet("test/public")]
        [AllowAnonymous]
        public IActionResult TestPublic() => Ok();

        [HttpGet("test/private")]
        [Authorize]
        public IActionResult TestPrivate() => Ok();

        [HttpGet("test/admin")]
        [Authorize(Roles = "Administrator")]
        public IActionResult TestAdmin() => Ok();

        [HttpGet("test/user")]
        [Authorize(Roles = "User")]
        public IActionResult TestUser() => Ok();

    }



}
