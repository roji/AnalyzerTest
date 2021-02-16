using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RemoveExtraFieldsFromAmbientWasteWasteWaterMotorSoundParametersTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChimneyParametersResults_EnumData_PollutionReleaseSourceId",
                table: "ChimneyParametersResults");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteParametersResults_EnumData_PollutionReleaseSourceId",
                table: "WasteParametersResults");

            migrationBuilder.DropForeignKey(
                name: "FK_WastewaterParametersResults_EnumData_AcceptedResourceId",
                table: "WastewaterParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_WastewaterParametersResults_AcceptedResourceId",
                table: "WastewaterParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_WasteParametersResults_PollutionReleaseSourceId",
                table: "WasteParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_ChimneyParametersResults_PollutionReleaseSourceId",
                table: "ChimneyParametersResults");

            migrationBuilder.DropColumn(
                name: "AcceptedResourceId",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "PollutionReleaseSourceId",
                table: "WasteParametersResults");

            migrationBuilder.DropColumn(
                name: "PollutionReleaseSourceId",
                table: "ChimneyParametersResults");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AcceptedResourceId",
                table: "WastewaterParametersResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PollutionReleaseSourceId",
                table: "WasteParametersResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PollutionReleaseSourceId",
                table: "ChimneyParametersResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_WastewaterParametersResults_AcceptedResourceId",
                table: "WastewaterParametersResults",
                column: "AcceptedResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteParametersResults_PollutionReleaseSourceId",
                table: "WasteParametersResults",
                column: "PollutionReleaseSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ChimneyParametersResults_PollutionReleaseSourceId",
                table: "ChimneyParametersResults",
                column: "PollutionReleaseSourceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChimneyParametersResults_EnumData_PollutionReleaseSourceId",
                table: "ChimneyParametersResults",
                column: "PollutionReleaseSourceId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteParametersResults_EnumData_PollutionReleaseSourceId",
                table: "WasteParametersResults",
                column: "PollutionReleaseSourceId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WastewaterParametersResults_EnumData_AcceptedResourceId",
                table: "WastewaterParametersResults",
                column: "AcceptedResourceId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
