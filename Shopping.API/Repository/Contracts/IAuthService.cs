using Microsoft.AspNetCore.Identity;
using Shopping.API.Entities;

namespace Shopping.API.Repository.Contracts
{
    public interface IAuthService
    {
        Task<string> CreateTokenAsync(User user , UserManager<User> manager);
    }
}
