using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ReCreateIndustryFilesWithNewRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogoFileName",
                table: "Industries");

            migrationBuilder.DropColumn(
                name: "OperationLicenseFileName",
                table: "Industries");

            migrationBuilder.AddColumn<string>(
                name: "LogoFileNameId",
                table: "Industries",
                maxLength: 38,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperationLicenseFileNameId",
                table: "Industries",
                maxLength: 38,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Industries_LogoFileNameId",
                table: "Industries",
                column: "LogoFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Industries_OperationLicenseFileNameId",
                table: "Industries",
                column: "OperationLicenseFileNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Industries_Uploads_LogoFileNameId",
                table: "Industries",
                column: "LogoFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Industries_Uploads_OperationLicenseFileNameId",
                table: "Industries",
                column: "OperationLicenseFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Industries_Uploads_LogoFileNameId",
                table: "Industries");

            migrationBuilder.DropForeignKey(
                name: "FK_Industries_Uploads_OperationLicenseFileNameId",
                table: "Industries");

            migrationBuilder.DropIndex(
                name: "IX_Industries_LogoFileNameId",
                table: "Industries");

            migrationBuilder.DropIndex(
                name: "IX_Industries_OperationLicenseFileNameId",
                table: "Industries");

            migrationBuilder.DropColumn(
                name: "LogoFileNameId",
                table: "Industries");

            migrationBuilder.DropColumn(
                name: "OperationLicenseFileNameId",
                table: "Industries");

            migrationBuilder.AddColumn<string>(
                name: "LogoFileName",
                table: "Industries",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OperationLicenseFileName",
                table: "Industries",
                nullable: true);
        }
    }
}
