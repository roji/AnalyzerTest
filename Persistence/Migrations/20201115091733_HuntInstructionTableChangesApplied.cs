using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class HuntInstructionTableChangesApplied : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var deleteOldRecords = @"DELETE FROM HuntInstructions";
         migrationBuilder.Sql(deleteOldRecords);

         migrationBuilder.DropForeignKey(
            name: "FK_HuntInstructionProvinceRegionsLimitations_EnumData_ProvinceR~",
            table: "HuntInstructionProvinceRegionsLimitations");

         migrationBuilder.DropIndex(
            name: "IX_HuntInstructionProvinceRegionsLimitations_ProvinceRegionId",
            table: "HuntInstructionProvinceRegionsLimitations");

         migrationBuilder.DropColumn(
            name: "ForeignLicenseAllowedMaximum",
            table: "HuntInstructions");

         migrationBuilder.DropColumn(
            name: "ForeignLicenseFee",
            table: "HuntInstructions");

         migrationBuilder.DropColumn(
            name: "NativeLicenseAllowedMaximum",
            table: "HuntInstructions");

         migrationBuilder.DropColumn(
            name: "NativeLicenseFee",
            table: "HuntInstructions");

         migrationBuilder.DropColumn(
            name: "NonNativeLicenseAllowedMaximum",
            table: "HuntInstructions");

         migrationBuilder.DropColumn(
            name: "NonNativeLicenseFee",
            table: "HuntInstructions");

         migrationBuilder.DropColumn(
            name: "ProvinceRegionId",
            table: "HuntInstructionProvinceRegionsLimitations");

         migrationBuilder.AlterColumn<int>(
            name: "ToDate",
            table: "HuntInstructions",
            nullable : false,
            oldClrType : typeof(int),
            oldType: "int",
            oldNullable : true);

         migrationBuilder.AlterColumn<int>(
            name: "ProvinceId",
            table: "HuntInstructions",
            nullable : false,
            oldClrType : typeof(int),
            oldType: "int",
            oldNullable : true);

         migrationBuilder.AlterColumn<int>(
            name: "HuntQuantity",
            table: "HuntInstructions",
            nullable : false,
            oldClrType : typeof(int),
            oldType: "int",
            oldNullable : true);

         migrationBuilder.AlterColumn<int>(
            name: "FromDate",
            table: "HuntInstructions",
            nullable : false,
            oldClrType : typeof(int),
            oldType: "int",
            oldNullable : true);

         migrationBuilder.AddColumn<int>(
            name: "AllowedIssuedLicenseMaximum",
            table: "HuntInstructions",
            nullable : false,
            defaultValue : 0);

         migrationBuilder.AddColumn<int>(
            name: "IssuedLicenseQuantity",
            table: "HuntInstructions",
            nullable : false,
            defaultValue : 0);

         migrationBuilder.AddColumn<double>(
            name: "LicenseFee",
            table: "HuntInstructions",
            nullable : false,
            defaultValue : 0.0);

         migrationBuilder.AddColumn<int>(
            name: "RequestClassification",
            table: "HuntInstructions",
            nullable : false,
            defaultValue : 0);

         migrationBuilder.AddColumn<int>(
            name: "Status",
            table: "HuntInstructions",
            nullable : false,
            defaultValue : 1);

         migrationBuilder.AddColumn<int>(
            name: "HuntRegionId",
            table: "HuntInstructionProvinceRegionsLimitations",
            nullable : false,
            defaultValue : 0);

         migrationBuilder.CreateIndex(
            name: "IX_HuntInstructionProvinceRegionsLimitations_HuntRegionId",
            table: "HuntInstructionProvinceRegionsLimitations",
            column: "HuntRegionId");

         migrationBuilder.AddForeignKey(
            name: "FK_HuntInstructionProvinceRegionsLimitations_HuntRegions_HuntRe~",
            table: "HuntInstructionProvinceRegionsLimitations",
            column: "HuntRegionId",
            principalTable: "HuntRegions",
            principalColumn: "Id",
            onDelete : ReferentialAction.Restrict);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.DropForeignKey(
            name: "FK_HuntInstructionProvinceRegionsLimitations_HuntRegions_HuntRe~",
            table: "HuntInstructionProvinceRegionsLimitations");

         migrationBuilder.DropIndex(
            name: "IX_HuntInstructionProvinceRegionsLimitations_HuntRegionId",
            table: "HuntInstructionProvinceRegionsLimitations");

         migrationBuilder.DropColumn(
            name: "AllowedIssuedLicenseMaximum",
            table: "HuntInstructions");

         migrationBuilder.DropColumn(
            name: "IssuedLicenseQuantity",
            table: "HuntInstructions");

         migrationBuilder.DropColumn(
            name: "LicenseFee",
            table: "HuntInstructions");

         migrationBuilder.DropColumn(
            name: "RequestClassification",
            table: "HuntInstructions");

         migrationBuilder.DropColumn(
            name: "Status",
            table: "HuntInstructions");

         migrationBuilder.DropColumn(
            name: "HuntRegionId",
            table: "HuntInstructionProvinceRegionsLimitations");

         migrationBuilder.AlterColumn<int>(
            name: "ToDate",
            table: "HuntInstructions",
            type: "int",
            nullable : true,
            oldClrType : typeof(int));

         migrationBuilder.AlterColumn<int>(
            name: "ProvinceId",
            table: "HuntInstructions",
            type: "int",
            nullable : true,
            oldClrType : typeof(int));

         migrationBuilder.AlterColumn<int>(
            name: "HuntQuantity",
            table: "HuntInstructions",
            type: "int",
            nullable : true,
            oldClrType : typeof(int));

         migrationBuilder.AlterColumn<int>(
            name: "FromDate",
            table: "HuntInstructions",
            type: "int",
            nullable : true,
            oldClrType : typeof(int));

         migrationBuilder.AddColumn<int>(
            name: "ForeignLicenseAllowedMaximum",
            table: "HuntInstructions",
            type: "int",
            nullable : true);

         migrationBuilder.AddColumn<double>(
            name: "ForeignLicenseFee",
            table: "HuntInstructions",
            type: "double",
            nullable : true);

         migrationBuilder.AddColumn<int>(
            name: "NativeLicenseAllowedMaximum",
            table: "HuntInstructions",
            type: "int",
            nullable : true);

         migrationBuilder.AddColumn<double>(
            name: "NativeLicenseFee",
            table: "HuntInstructions",
            type: "double",
            nullable : true);

         migrationBuilder.AddColumn<int>(
            name: "NonNativeLicenseAllowedMaximum",
            table: "HuntInstructions",
            type: "int",
            nullable : true);

         migrationBuilder.AddColumn<double>(
            name: "NonNativeLicenseFee",
            table: "HuntInstructions",
            type: "double",
            nullable : true);

         migrationBuilder.AddColumn<int>(
            name: "ProvinceRegionId",
            table: "HuntInstructionProvinceRegionsLimitations",
            type: "int",
            nullable : false,
            defaultValue : 0);

         migrationBuilder.CreateIndex(
            name: "IX_HuntInstructionProvinceRegionsLimitations_ProvinceRegionId",
            table: "HuntInstructionProvinceRegionsLimitations",
            column: "ProvinceRegionId");

         migrationBuilder.AddForeignKey(
            name: "FK_HuntInstructionProvinceRegionsLimitations_EnumData_ProvinceR~",
            table: "HuntInstructionProvinceRegionsLimitations",
            column: "ProvinceRegionId",
            principalTable: "EnumData",
            principalColumn: "Id",
            onDelete : ReferentialAction.Restrict);
      }
   }
}
