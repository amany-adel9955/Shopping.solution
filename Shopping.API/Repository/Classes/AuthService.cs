using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Shopping.API.Entities;
using Shopping.API.Repository.Contracts;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Shopping.API.Repository.Classes
{
    public class AuthService : IAuthService
    {
        private readonly IConfiguration _configuration;

        public AuthService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<string> CreateTokenAsync(User user, UserManager<User> manager)
        {
            var claims = new List<Claim>() 
            { 
            new Claim( ClaimTypes.GivenName , user.UserName),
            new Claim(ClaimTypes.Email , user.Email)
            };

            var userroles = await manager.GetRolesAsync(user);

            foreach (var role in userroles)
            {
                claims.Add(new Claim( ClaimTypes.Role , role));
            }

            var authKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:SecretKey"]));

            var token = new JwtSecurityToken(
                audience: _configuration["JWT:TokenAudience"],
                issuer: _configuration["JWT:TokenIssuer"],
                expires: DateTime.UtcNow.AddDays(double.Parse(_configuration["JWT:ExpiresInays"])),
                claims: claims,
                signingCredentials: new SigningCredentials(authKey, SecurityAlgorithms.HmacSha256Signature)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
