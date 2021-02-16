using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddLicenseIssuerToHunterWeaponHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LicenseIssuerId",
                table: "HunterWeaponHistories",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HunterWeaponHistories_LicenseIssuerId",
                table: "HunterWeaponHistories",
                column: "LicenseIssuerId");

            migrationBuilder.AddForeignKey(
                name: "FK_HunterWeaponHistories_EnumData_LicenseIssuerId",
                table: "HunterWeaponHistories",
                column: "LicenseIssuerId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HunterWeaponHistories_EnumData_LicenseIssuerId",
                table: "HunterWeaponHistories");

            migrationBuilder.DropIndex(
                name: "IX_HunterWeaponHistories_LicenseIssuerId",
                table: "HunterWeaponHistories");

            migrationBuilder.DropColumn(
                name: "LicenseIssuerId",
                table: "HunterWeaponHistories");
        }
    }
}
