using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class addStateIdToUsertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StateId",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_StateId",
                table: "Users",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_EnumData_StateId",
                table: "Users",
                column: "StateId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_EnumData_StateId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_StateId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "StateId",
                table: "Users");
        }
    }
}
