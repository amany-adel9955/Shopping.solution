
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Writers;
using Shopping.API.Data;
using Shopping.API.Entities;
using Shopping.API.Repository.Classes;
using Shopping.API.Repository.Contracts;
using Shopping.API.Seeding;
using Shopping.API.UnitOfWork;

namespace Shopping.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ShoppingConnection"));
            });

            builder.Services.AddDbContext<IdentityUserDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("IdentityConnection"));
            });

            builder.Services.AddIdentity<User, IdentityRole>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequiredUniqueChars = 2;
                options.Password.RequireLowercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireUppercase = true;

            }).AddEntityFrameworkStores<IdentityUserDbContext>();

            builder.Services.AddScoped<IUnitOfWork, UnitOfwork>();
            builder.Services.AddScoped<IProductRepo, ProductRepo>();  // register product class by dependency injection
            builder.Services.AddScoped<IAuthService, AuthService>();

            var app = builder.Build();
            #region database 
            using var scope = app.Services.CreateScope();
            var service = scope.ServiceProvider;
            var context = service.GetRequiredService<ApplicationDbContext>();

            var identitycontext = service.GetRequiredService<IdentityUserDbContext>();

            var loggerfactory = service.GetRequiredService<ILoggerFactory>();

            try
            {
               await context.Database.MigrateAsync();

               await identitycontext.Database.MigrateAsync();

                var _userManager = service.GetRequiredService<UserManager<User>>();
                await UserIdentitySeeding.AddusersAsync(_userManager);   // this static method didn't work!! i added users through modelbuilder in the identitydbcontext
            }
            catch (Exception ex)
            {
                var logger = loggerfactory.CreateLogger<Program>();
                logger.LogError(ex, "an error occured during creating the migration");
            }
            #endregion

          

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseCors(policy =>
            {
                policy.WithOrigins("http://localhost:7231/", "https://localhost:7231/")
                .AllowAnyMethod()
                .WithHeaders(HeaderNames.ContentType);
            });


            app.UseHttpsRedirection();



            app.MapControllers();

            app.UseAuthentication();
            app.UseAuthorization();

            app.Run();
        }
    }
}
