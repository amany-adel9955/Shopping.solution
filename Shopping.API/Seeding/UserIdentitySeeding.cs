using Microsoft.AspNetCore.Identity;
using Shopping.API.Entities;

namespace Shopping.API.Seeding
{
    public static class UserIdentitySeeding
    {
        public static async Task AddusersAsync(UserManager<User> _userManager)
        {
            if (_userManager.Users.Count() == 0)
            {
                var newUser = new User()
                {
                    Name = "Amany Adel", 
                    Email = "amanyadel@gmail.com",
                    UserName = "Amany.Adel",
                    PhoneNumber = "0122232223"
                };

               await _userManager.CreateAsync(newUser , "1234asdf@#");

            }
        }
    }
}
