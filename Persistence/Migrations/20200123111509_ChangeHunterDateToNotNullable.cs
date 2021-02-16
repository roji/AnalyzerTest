using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeHunterDateToNotNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LicenseIsValidToDate",
                table: "HunterWeaponHistories",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LicenseIsValidFromDate",
                table: "HunterWeaponHistories",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LicenseIsValidToDate",
                table: "HunterWeaponHistories",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "LicenseIsValidFromDate",
                table: "HunterWeaponHistories",
                nullable: true,
                oldClrType: typeof(int));
        }
    }
}
