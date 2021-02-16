using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class addIndustryEvaluationEMPFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpProgramFileNameId",
                table: "IndustryEvaluations",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "HasEmpProgram",
                table: "IndustryEvaluations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEvaluations_EmpProgramFileNameId",
                table: "IndustryEvaluations",
                column: "EmpProgramFileNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEvaluations_Uploads_EmpProgramFileNameId",
                table: "IndustryEvaluations",
                column: "EmpProgramFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEvaluations_Uploads_EmpProgramFileNameId",
                table: "IndustryEvaluations");

            migrationBuilder.DropIndex(
                name: "IX_IndustryEvaluations_EmpProgramFileNameId",
                table: "IndustryEvaluations");

            migrationBuilder.DropColumn(
                name: "EmpProgramFileNameId",
                table: "IndustryEvaluations");

            migrationBuilder.DropColumn(
                name: "HasEmpProgram",
                table: "IndustryEvaluations");
        }
    }
}
