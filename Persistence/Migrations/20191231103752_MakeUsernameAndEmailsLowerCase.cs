using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class MakeUsernameAndEmailsLowerCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"
            UPDATE users SET Username = LOWER(Username);
            UPDATE users SET Email = LOWER(Email);";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
