using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddRepositoryFieldToWasteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RepositoryId",
                table: "Wastes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_RepositoryId",
                table: "Wastes",
                column: "RepositoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wastes_Repositories_RepositoryId",
                table: "Wastes",
                column: "RepositoryId",
                principalTable: "Repositories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wastes_Repositories_RepositoryId",
                table: "Wastes");

            migrationBuilder.DropIndex(
                name: "IX_Wastes_RepositoryId",
                table: "Wastes");

            migrationBuilder.DropColumn(
                name: "RepositoryId",
                table: "Wastes");
        }
    }
}
