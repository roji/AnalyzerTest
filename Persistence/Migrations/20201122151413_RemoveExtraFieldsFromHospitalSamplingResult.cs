using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class RemoveExtraFieldsFromHospitalSamplingResult : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var migrateNullableValues = @"UPDATE HospitalSamplingResults SET IsMonitoringDone=false WHERE IsMonitoringDone is NULL";
         migrationBuilder.Sql(migrateNullableValues);

         migrationBuilder.DropColumn(
                name: "DepartmentAlternativeLetterDate",
                table: "HospitalSamplingResults");

         migrationBuilder.DropColumn(
             name: "DepartmentAlternativeLetterNumber",
             table: "HospitalSamplingResults");

         migrationBuilder.DropColumn(
             name: "MonitoringAlternativeDate",
             table: "HospitalSamplingResults");

         migrationBuilder.DropColumn(
             name: "MonitoringAlternativeHour",
             table: "HospitalSamplingResults");

         migrationBuilder.DropColumn(
             name: "MonitoringCancelingCause",
             table: "HospitalSamplingResults");

         migrationBuilder.AlterColumn<bool>(
             name: "IsMonitoringDone",
             table: "HospitalSamplingResults",
             nullable: false,
             defaultValue: false,
             oldClrType: typeof(bool),
             oldType: "tinyint(1)",
             oldNullable: true);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.AlterColumn<bool>(
             name: "IsMonitoringDone",
             table: "HospitalSamplingResults",
             type: "tinyint(1)",
             nullable: true,
             oldClrType: typeof(bool),
             oldDefaultValue: false);

         migrationBuilder.AddColumn<int>(
             name: "DepartmentAlternativeLetterDate",
             table: "HospitalSamplingResults",
             type: "int",
             nullable: true);

         migrationBuilder.AddColumn<int>(
             name: "DepartmentAlternativeLetterNumber",
             table: "HospitalSamplingResults",
             type: "int",
             nullable: true);

         migrationBuilder.AddColumn<int>(
             name: "MonitoringAlternativeDate",
             table: "HospitalSamplingResults",
             type: "int",
             nullable: true);

         migrationBuilder.AddColumn<string>(
             name: "MonitoringAlternativeHour",
             table: "HospitalSamplingResults",
             type: "longtext",
             nullable: true);

         migrationBuilder.AddColumn<string>(
             name: "MonitoringCancelingCause",
             table: "HospitalSamplingResults",
             type: "longtext",
             nullable: true);
      }
   }
}
