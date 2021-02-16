using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class RemoveExtraFieldsFromIndustrialUnitsSamplingResult : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var migrateNullableValues = @"UPDATE industrialunitssamplingresults SET IsMonitoringDone=false WHERE IsMonitoringDone is NULL";
         migrationBuilder.Sql(migrateNullableValues);
         migrationBuilder.DropColumn(
             name: "DepartmentAlternativeLetterDate",
             table: "IndustrialUnitsSamplingResults");

         migrationBuilder.DropColumn(
             name: "DepartmentAlternativeLetterNumber",
             table: "IndustrialUnitsSamplingResults");

         migrationBuilder.DropColumn(
             name: "MonitoringAlternativeDate",
             table: "IndustrialUnitsSamplingResults");

         migrationBuilder.DropColumn(
             name: "MonitoringAlternativeHour",
             table: "IndustrialUnitsSamplingResults");

         migrationBuilder.DropColumn(
             name: "MonitoringCancelingCause",
             table: "IndustrialUnitsSamplingResults");

         migrationBuilder.AlterColumn<bool>(
             name: "IsMonitoringDone",
             table: "IndustrialUnitsSamplingResults",
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
             table: "IndustrialUnitsSamplingResults",
             type: "tinyint(1)",
             nullable: true,
             oldClrType: typeof(bool),
             oldDefaultValue: false);

         migrationBuilder.AddColumn<int>(
             name: "DepartmentAlternativeLetterDate",
             table: "IndustrialUnitsSamplingResults",
             type: "int",
             nullable: true);

         migrationBuilder.AddColumn<int>(
             name: "DepartmentAlternativeLetterNumber",
             table: "IndustrialUnitsSamplingResults",
             type: "int",
             nullable: true);

         migrationBuilder.AddColumn<int>(
             name: "MonitoringAlternativeDate",
             table: "IndustrialUnitsSamplingResults",
             type: "int",
             nullable: true);

         migrationBuilder.AddColumn<string>(
             name: "MonitoringAlternativeHour",
             table: "IndustrialUnitsSamplingResults",
             type: "longtext",
             nullable: true);

         migrationBuilder.AddColumn<string>(
             name: "MonitoringCancelingCause",
             table: "IndustrialUnitsSamplingResults",
             type: "longtext",
             nullable: true);
      }
   }
}
