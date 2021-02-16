using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddTwoFieldsToEstablishmentTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApplicantStatusId",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCommitmentApproveByUser",
                table: "IndustryEstablishments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEstablishments_ApplicantStatusId",
                table: "IndustryEstablishments",
                column: "ApplicantStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_IndustryEstablishments_EnumData_ApplicantStatusId",
                table: "IndustryEstablishments",
                column: "ApplicantStatusId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IndustryEstablishments_EnumData_ApplicantStatusId",
                table: "IndustryEstablishments");

            migrationBuilder.DropIndex(
                name: "IX_IndustryEstablishments_ApplicantStatusId",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "ApplicantStatusId",
                table: "IndustryEstablishments");

            migrationBuilder.DropColumn(
                name: "IsCommitmentApproveByUser",
                table: "IndustryEstablishments");
        }
    }
}
