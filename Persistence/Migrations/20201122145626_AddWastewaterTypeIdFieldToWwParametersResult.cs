using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddWastewaterTypeIdFieldToWwParametersResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WastewaterTypeId",
                table: "WastewaterParametersResults",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WastewaterParametersResults_WastewaterTypeId",
                table: "WastewaterParametersResults",
                column: "WastewaterTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_WastewaterParametersResults_EnumData_WastewaterTypeId",
                table: "WastewaterParametersResults",
                column: "WastewaterTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WastewaterParametersResults_EnumData_WastewaterTypeId",
                table: "WastewaterParametersResults");

            migrationBuilder.DropIndex(
                name: "IX_WastewaterParametersResults_WastewaterTypeId",
                table: "WastewaterParametersResults");

            migrationBuilder.DropColumn(
                name: "WastewaterTypeId",
                table: "WastewaterParametersResults");
        }
    }
}
