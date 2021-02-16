using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class HospitalSamplingResultRelatedTableChangesApplied : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var deleteOldRecords = @"DELETE FROM HospitalSamplingResults";
         migrationBuilder.Sql(deleteOldRecords);

         migrationBuilder.DropForeignKey(
            name: "FK_HospitalDisinfectionDeviceResults_EnumData_DisinfectionDevic~",
            table: "HospitalDisinfectionDeviceResults");

         migrationBuilder.DropForeignKey(
            name: "FK_HospitalUsingFacilities_HospitalDisinfectionDeviceResults_Di~",
            table: "HospitalUsingFacilities");

         migrationBuilder.DropIndex(
            name: "IX_HospitalUsingFacilities_DisinfectionDeviceResultId",
            table: "HospitalUsingFacilities");

         migrationBuilder.DropIndex(
            name: "IX_HospitalDisinfectionDeviceResults_DisinfectionDeviceTypeId",
            table: "HospitalDisinfectionDeviceResults");

         migrationBuilder.DropColumn(
            name: "DisinfectionDeviceResultId",
            table: "HospitalUsingFacilities");

         migrationBuilder.DropColumn(
            name: "DisinfectionDeviceTypeId",
            table: "HospitalDisinfectionDeviceResults");

         migrationBuilder.DropColumn(
            name: "EliminateOtherHospitalsWaste",
            table: "HospitalDisinfectionDeviceResults");

         migrationBuilder.DropColumn(
            name: "IsEliminationHappenInHospital",
            table: "HospitalDisinfectionDeviceResults");

         migrationBuilder.DropColumn(
            name: "IsMonitoringCenterSite",
            table: "HospitalDisinfectionDeviceResults");

         migrationBuilder.AddColumn<int>(
            name: "HospitalSamplingResultId",
            table: "HospitalUsingFacilities",
            nullable : false,
            defaultValue : 0);

         migrationBuilder.AlterColumn<bool>(
            name: "FinalSave",
            table: "HospitalSamplingResults",
            nullable : false,
            defaultValue : false,
            oldClrType : typeof(bool),
            oldType: "tinyint(1)");

         migrationBuilder.AddColumn<bool>(
            name: "EliminateOtherHospitalsWaste",
            table: "HospitalSamplingResults",
            nullable : true);

         migrationBuilder.AddColumn<bool>(
            name: "IsEliminationHappenInHospital",
            table: "HospitalSamplingResults",
            nullable : true);

         migrationBuilder.AddColumn<bool>(
            name: "IsMonitoringCenterSite",
            table: "HospitalSamplingResults",
            nullable : true);

         migrationBuilder.AddColumn<int>(
            name: "DeviceType",
            table: "HospitalDisinfectionDeviceResults",
            nullable : false,
            defaultValue : 0);

         migrationBuilder.AddColumn<bool>(
            name: "IsAcceptable",
            table: "HospitalDisinfectionDeviceResults",
            nullable : true);

         migrationBuilder.CreateIndex(
            name: "IX_HospitalUsingFacilities_HospitalSamplingResultId",
            table: "HospitalUsingFacilities",
            column: "HospitalSamplingResultId");

         migrationBuilder.CreateIndex(
            name: "IX_HospitalDisinfectionDeviceResults_IsAcceptable",
            table: "HospitalDisinfectionDeviceResults",
            column: "IsAcceptable");

         migrationBuilder.AddForeignKey(
            name: "FK_HospitalUsingFacilities_HospitalSamplingResults_HospitalSamp~",
            table: "HospitalUsingFacilities",
            column: "HospitalSamplingResultId",
            principalTable: "HospitalSamplingResults",
            principalColumn: "Id",
            onDelete : ReferentialAction.Cascade);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.DropForeignKey(
            name: "FK_HospitalUsingFacilities_HospitalSamplingResults_HospitalSamp~",
            table: "HospitalUsingFacilities");

         migrationBuilder.DropIndex(
            name: "IX_HospitalUsingFacilities_HospitalSamplingResultId",
            table: "HospitalUsingFacilities");

         migrationBuilder.DropIndex(
            name: "IX_HospitalDisinfectionDeviceResults_IsAcceptable",
            table: "HospitalDisinfectionDeviceResults");

         migrationBuilder.DropColumn(
            name: "HospitalSamplingResultId",
            table: "HospitalUsingFacilities");

         migrationBuilder.DropColumn(
            name: "EliminateOtherHospitalsWaste",
            table: "HospitalSamplingResults");

         migrationBuilder.DropColumn(
            name: "IsEliminationHappenInHospital",
            table: "HospitalSamplingResults");

         migrationBuilder.DropColumn(
            name: "IsMonitoringCenterSite",
            table: "HospitalSamplingResults");

         migrationBuilder.DropColumn(
            name: "DeviceType",
            table: "HospitalDisinfectionDeviceResults");

         migrationBuilder.DropColumn(
            name: "IsAcceptable",
            table: "HospitalDisinfectionDeviceResults");

         migrationBuilder.AddColumn<int>(
            name: "DisinfectionDeviceResultId",
            table: "HospitalUsingFacilities",
            type: "int",
            nullable : false,
            defaultValue : 0);

         migrationBuilder.AlterColumn<bool>(
            name: "FinalSave",
            table: "HospitalSamplingResults",
            type: "tinyint(1)",
            nullable : false,
            oldClrType : typeof(bool),
            oldDefaultValue : false);

         migrationBuilder.AddColumn<int>(
            name: "DisinfectionDeviceTypeId",
            table: "HospitalDisinfectionDeviceResults",
            type: "int",
            nullable : false,
            defaultValue : 0);

         migrationBuilder.AddColumn<bool>(
            name: "EliminateOtherHospitalsWaste",
            table: "HospitalDisinfectionDeviceResults",
            type: "tinyint(1)",
            nullable : true);

         migrationBuilder.AddColumn<bool>(
            name: "IsEliminationHappenInHospital",
            table: "HospitalDisinfectionDeviceResults",
            type: "tinyint(1)",
            nullable : true);

         migrationBuilder.AddColumn<bool>(
            name: "IsMonitoringCenterSite",
            table: "HospitalDisinfectionDeviceResults",
            type: "tinyint(1)",
            nullable : true);

         migrationBuilder.CreateIndex(
            name: "IX_HospitalUsingFacilities_DisinfectionDeviceResultId",
            table: "HospitalUsingFacilities",
            column: "DisinfectionDeviceResultId");

         migrationBuilder.CreateIndex(
            name: "IX_HospitalDisinfectionDeviceResults_DisinfectionDeviceTypeId",
            table: "HospitalDisinfectionDeviceResults",
            column: "DisinfectionDeviceTypeId");

         migrationBuilder.AddForeignKey(
            name: "FK_HospitalDisinfectionDeviceResults_EnumData_DisinfectionDevic~",
            table: "HospitalDisinfectionDeviceResults",
            column: "DisinfectionDeviceTypeId",
            principalTable: "EnumData",
            principalColumn: "Id",
            onDelete : ReferentialAction.Restrict);

         migrationBuilder.AddForeignKey(
            name: "FK_HospitalUsingFacilities_HospitalDisinfectionDeviceResults_Di~",
            table: "HospitalUsingFacilities",
            column: "DisinfectionDeviceResultId",
            principalTable: "HospitalDisinfectionDeviceResults",
            principalColumn: "Id",
            onDelete : ReferentialAction.Cascade);
      }
   }
}
