using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class UpdateJudicialActionSheetFileNameFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryJudicialActions_Uploads_JudicialActionSheetId",
                table: "IndustryJudicialActions");

            migrationBuilder.DropIndex(
                name: "IX_IndustryJudicialActions_JudicialActionSheetId",
                table: "IndustryJudicialActions");

            migrationBuilder.DropColumn(
                name: "JudicialActionSheetId",
                table: "IndustryJudicialActions");

            migrationBuilder.AddColumn<string>(
                name: "JudicialActionSheetFileNameId",
                table: "IndustryJudicialActions",
                maxLength: 38,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryJudicialActions_JudicialActionSheetFileNameId",
                table: "IndustryJudicialActions",
                column: "JudicialActionSheetFileNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryJudicialActions_Uploads_JudicialActionSheetFileNameId",
                table: "IndustryJudicialActions",
                column: "JudicialActionSheetFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryJudicialActions_Uploads_JudicialActionSheetFileNameId",
                table: "IndustryJudicialActions");

            migrationBuilder.DropIndex(
                name: "IX_IndustryJudicialActions_JudicialActionSheetFileNameId",
                table: "IndustryJudicialActions");

            migrationBuilder.DropColumn(
                name: "JudicialActionSheetFileNameId",
                table: "IndustryJudicialActions");

            migrationBuilder.AddColumn<string>(
                name: "JudicialActionSheetId",
                table: "IndustryJudicialActions",
                type: "varchar(38)",
                maxLength: 38,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryJudicialActions_JudicialActionSheetId",
                table: "IndustryJudicialActions",
                column: "JudicialActionSheetId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryJudicialActions_Uploads_JudicialActionSheetId",
                table: "IndustryJudicialActions",
                column: "JudicialActionSheetId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
