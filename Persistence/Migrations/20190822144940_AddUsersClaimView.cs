using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddUsersClaimView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"CREATE VIEW v_usersclaim AS 
                    (SELECT
                            users.Id,
                            users.Username,
                            users.FullName,
                            users.IsActive,
                            roleclaims.ClaimType,
                            roleclaims.ClaimValue
                            FROM
                            users
                            LEFT JOIN userroles ON userroles.UserId = users.Id
                            LEFT JOIN roles ON userroles.RoleId = roles.Id  
                            LEFT JOIN roleclaims ON roleclaims.RoleId = roles.Id)

                            UNION ALL

                            (SELECT
                            users.Id,
                            users.Username,
                            users.FullName,
                            users.IsActive,
                            userclaims.ClaimType,
                            userclaims.ClaimValue

                            FROM
                            users
                            JOIN userclaims ON userclaims.UserId = users.Id)  
                            ";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            var cmd = @"DROP VIEW IF EXISTS `v_usersclaim`;";
            migrationBuilder.Sql(cmd);
        }
    }
}
