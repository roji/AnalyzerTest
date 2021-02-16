using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddProfileImgNameForeingKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Users_ProfileImgFileNameId",
                table: "Users",
                column: "ProfileImgFileNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Uploads_ProfileImgFileNameId",
                table: "Users",
                column: "ProfileImgFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Uploads_ProfileImgFileNameId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ProfileImgFileNameId",
                table: "Users");
        }
    }
}
