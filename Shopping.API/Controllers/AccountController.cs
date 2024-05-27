using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Shopping.API.Entities;
using Shopping.API.Repository.Contracts;
using Shopping.Bl.Dtos;
using Shopping.Bl.Response;

namespace Shopping.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<User> _userManager;  // builtin service from user identity
        private readonly SignInManager<User> _signInManager;
        private readonly IAuthService _authService;

        public AccountController(UserManager<User> userManager , SignInManager<User> signInManager , IAuthService authService )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _authService = authService;
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserDto>> Login(LoginDto model)
        {
            
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user is null)
                {
                    return Unauthorized(new GeneralResponse { StatusCode = 401, Message = "Invalid Email" });
                }

                var result = await _signInManager.CheckPasswordSignInAsync(user, model.Password, false);

                if (result.Succeeded is false)
                {
                    return Unauthorized(new GeneralResponse { StatusCode = 401, Message = "Invalid password" });
                }

                return Ok(new UserDto()
                {
                    Name = user.Name,
                    Email = user.Email,
                    Token = await _authService.CreateTokenAsync(user , _userManager)
                });
            
        }

        [HttpPost("register")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto model)
        {
            var user = new User() 
            { 
                Name = model.Name,
                Email = model.Email,
                UserName = model.Email.Split("@")[0],
                PhoneNumber = model.PhoneNumber
            };

            var result = await _userManager.CreateAsync(user, model.Password);
            if(result.Succeeded is false)
            {
                return BadRequest(new GeneralResponse { StatusCode = 400, Message = "Invalid registeration" });
            }

            return Ok (new UserDto()
            {
                Name = user.Name,
                Email = user.Email,
                Token = await _authService.CreateTokenAsync(user, _userManager)
            });

        }
    }
}
