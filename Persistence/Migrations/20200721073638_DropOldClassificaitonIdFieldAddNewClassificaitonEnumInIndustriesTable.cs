using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class DropOldClassificaitonIdFieldAddNewClassificaitonEnumInIndustriesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Industries_EnumData_ClassificationId",
                table: "Industries");

            migrationBuilder.DropIndex(
                name: "IX_Industries_ClassificationId",
                table: "Industries");

            migrationBuilder.DropColumn(
                name: "ClassificationId",
                table: "Industries");

            migrationBuilder.AddColumn<int>(
                name: "Classification",
                table: "Industries",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Classification",
                table: "Industries");

            migrationBuilder.AddColumn<int>(
                name: "ClassificationId",
                table: "Industries",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Industries_ClassificationId",
                table: "Industries",
                column: "ClassificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Industries_EnumData_ClassificationId",
                table: "Industries",
                column: "ClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
