using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveRelatedIdFieldFromIndustryLabs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Industries_Users_RelatedUserId",
                table: "Industries");

            migrationBuilder.DropForeignKey(
                name: "FK_Labs_Users_RelatedUserId",
                table: "Labs");

            migrationBuilder.DropIndex(
                name: "IX_Labs_RelatedUserId",
                table: "Labs");

            migrationBuilder.DropIndex(
                name: "IX_Industries_RelatedUserId",
                table: "Industries");

            migrationBuilder.DropColumn(
                name: "RelatedUserId",
                table: "Labs");

            migrationBuilder.DropColumn(
                name: "RelatedUserId",
                table: "Industries");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RelatedUserId",
                table: "Labs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RelatedUserId",
                table: "Industries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Labs_RelatedUserId",
                table: "Labs",
                column: "RelatedUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Industries_RelatedUserId",
                table: "Industries",
                column: "RelatedUserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Industries_Users_RelatedUserId",
                table: "Industries",
                column: "RelatedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Labs_Users_RelatedUserId",
                table: "Labs",
                column: "RelatedUserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
