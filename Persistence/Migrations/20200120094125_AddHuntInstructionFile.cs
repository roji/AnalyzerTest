using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddHuntInstructionFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "InstructionFileNameId",
                table: "HuntInstructions",
                maxLength: 38,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HuntInstructions_InstructionFileNameId",
                table: "HuntInstructions",
                column: "InstructionFileNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_HuntInstructions_Uploads_InstructionFileNameId",
                table: "HuntInstructions",
                column: "InstructionFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HuntInstructions_Uploads_InstructionFileNameId",
                table: "HuntInstructions");

            migrationBuilder.DropIndex(
                name: "IX_HuntInstructions_InstructionFileNameId",
                table: "HuntInstructions");

            migrationBuilder.DropColumn(
                name: "InstructionFileNameId",
                table: "HuntInstructions");
        }
    }
}
