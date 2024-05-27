using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Shopping.API.Entities;
using Shopping.API.Entities.Identity;

namespace Shopping.API.Data
{
    public class IdentityUserDbContext : IdentityDbContext<User>
    {
        public IdentityUserDbContext(DbContextOptions<IdentityUserDbContext> options) : base(options)
        {
                
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Security;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Address>().ToTable("Addressess");

            builder.Entity<User>().HasData(new User
            {
                Name = "Amany Adel",
                Email = "amanyadel@gmail.com",
                UserName = "Amany.Adel",
                PhoneNumber = "0122232223"
            });
       
        }
    }
}
