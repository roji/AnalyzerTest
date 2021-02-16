using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeAccountNumberFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Card",
                table: "AccountNumbers",
                maxLength: 16,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(19)",
                oldMaxLength: 19);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Card",
                table: "AccountNumbers",
                type: "varchar(19)",
                maxLength: 19,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 16);
        }
    }
}
