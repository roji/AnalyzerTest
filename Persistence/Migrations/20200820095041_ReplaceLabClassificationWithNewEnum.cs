using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ReplaceLabClassificationWithNewEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labs_EnumData_ClassificationId",
                table: "Labs");

            migrationBuilder.DropIndex(
                name: "IX_Labs_ClassificationId",
                table: "Labs");

            migrationBuilder.DropColumn(
                name: "ClassificationId",
                table: "Labs");

            migrationBuilder.AddColumn<int>(
                name: "Classification",
                table: "Labs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classification",
                table: "Labs");

            migrationBuilder.AddColumn<int>(
                name: "ClassificationId",
                table: "Labs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Labs_ClassificationId",
                table: "Labs",
                column: "ClassificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Labs_EnumData_ClassificationId",
                table: "Labs",
                column: "ClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
