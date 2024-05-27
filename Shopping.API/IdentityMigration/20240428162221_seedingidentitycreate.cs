using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.API.IdentityMigration
{
    /// <inheritdoc />
    public partial class seedingidentitycreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "36aad755-f627-4c94-aa2b-b742fff0d0cc", 0, "e9b812c1-5d1b-4a86-97c3-760066f8ee1b", "amanyadel@gmail.com", false, false, null, "Amany Adel", null, null, null, "0122232223", false, "77c3d3a7-173d-48cc-9f4d-e3e0a1bca6a0", false, "Amany.Adel" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36aad755-f627-4c94-aa2b-b742fff0d0cc");
        }
    }
}
