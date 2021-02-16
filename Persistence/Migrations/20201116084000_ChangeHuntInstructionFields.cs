using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeHuntInstructionFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllowedIssuedLicenseMaximum",
                table: "HuntInstructions");

            migrationBuilder.DropColumn(
                name: "IssuedLicenseQuantity",
                table: "HuntInstructions");

            migrationBuilder.DropColumn(
                name: "LicenseFee",
                table: "HuntInstructions");

            migrationBuilder.AddColumn<int>(
                name: "ForeignLicenseAllowedQuantity",
                table: "HuntInstructions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "ForeignLicenseFee",
                table: "HuntInstructions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "IssuedForeignLicenseQuantity",
                table: "HuntInstructions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IssuedNativeLicenseQuantity",
                table: "HuntInstructions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IssuedNonNativeLicenseQuantity",
                table: "HuntInstructions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NativeLicenseAllowedQuantity",
                table: "HuntInstructions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "NativeLicenseFee",
                table: "HuntInstructions",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "NonNativeLicenseAllowedQuantity",
                table: "HuntInstructions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "NonNativeLicenseFee",
                table: "HuntInstructions",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForeignLicenseAllowedQuantity",
                table: "HuntInstructions");

            migrationBuilder.DropColumn(
                name: "ForeignLicenseFee",
                table: "HuntInstructions");

            migrationBuilder.DropColumn(
                name: "IssuedForeignLicenseQuantity",
                table: "HuntInstructions");

            migrationBuilder.DropColumn(
                name: "IssuedNativeLicenseQuantity",
                table: "HuntInstructions");

            migrationBuilder.DropColumn(
                name: "IssuedNonNativeLicenseQuantity",
                table: "HuntInstructions");

            migrationBuilder.DropColumn(
                name: "NativeLicenseAllowedQuantity",
                table: "HuntInstructions");

            migrationBuilder.DropColumn(
                name: "NativeLicenseFee",
                table: "HuntInstructions");

            migrationBuilder.DropColumn(
                name: "NonNativeLicenseAllowedQuantity",
                table: "HuntInstructions");

            migrationBuilder.DropColumn(
                name: "NonNativeLicenseFee",
                table: "HuntInstructions");

            migrationBuilder.AddColumn<int>(
                name: "AllowedIssuedLicenseMaximum",
                table: "HuntInstructions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IssuedLicenseQuantity",
                table: "HuntInstructions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "LicenseFee",
                table: "HuntInstructions",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
