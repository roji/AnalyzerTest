using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewFileToHospitalSamplingResult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SelfDeclarationAgendaFileNameId",
                table: "HospitalSamplingResults",
                maxLength: 38,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HospitalSamplingResults_SelfDeclarationAgendaFileNameId",
                table: "HospitalSamplingResults",
                column: "SelfDeclarationAgendaFileNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalSamplingResults_Uploads_SelfDeclarationAgendaFileNam~",
                table: "HospitalSamplingResults",
                column: "SelfDeclarationAgendaFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalSamplingResults_Uploads_SelfDeclarationAgendaFileNam~",
                table: "HospitalSamplingResults");

            migrationBuilder.DropIndex(
                name: "IX_HospitalSamplingResults_SelfDeclarationAgendaFileNameId",
                table: "HospitalSamplingResults");

            migrationBuilder.DropColumn(
                name: "SelfDeclarationAgendaFileNameId",
                table: "HospitalSamplingResults");
        }
    }
}
