using Microsoft.AspNetCore.Identity;
using Shopping.API.Entities.Identity;

namespace Shopping.API.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public Address Address { get; set; }
    }
}
