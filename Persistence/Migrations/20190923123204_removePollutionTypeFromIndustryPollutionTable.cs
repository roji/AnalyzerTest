using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class removePollutionTypeFromIndustryPollutionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryPollutions_EnumData_PollutionTypeId",
                table: "IndustryPollutions");

            migrationBuilder.DropIndex(
                name: "IX_IndustryPollutions_PollutionTypeId",
                table: "IndustryPollutions");

            migrationBuilder.DropColumn(
                name: "PollutionTypeId",
                table: "IndustryPollutions");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PollutionTypeId",
                table: "IndustryPollutions",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryPollutions_PollutionTypeId",
                table: "IndustryPollutions",
                column: "PollutionTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryPollutions_EnumData_PollutionTypeId",
                table: "IndustryPollutions",
                column: "PollutionTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
