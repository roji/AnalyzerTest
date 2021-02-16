using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
   public partial class RemoveUndefinedFromWasteMeasurementUnits : Migration
   {
      protected override void Up(MigrationBuilder migrationBuilder)
      {
         var migrateOldValues = @"
         UPDATE wastes SET MeasurementUnit=2 WHERE MeasurementUnit = 1;
         UPDATE wastemanagementunitsdetails SET MeasurementUnit =2 WHERE MeasurementUnit = 1;";
         migrationBuilder.Sql(migrateOldValues);

         migrationBuilder.AlterColumn<int>(
            name: "MeasurementUnit",
            table: "Wastes",
            nullable : false,
            defaultValue : 2,
            oldClrType : typeof(int),
            oldType: "int",
            oldDefaultValue : 1);

         migrationBuilder.AlterColumn<int>(
            name: "MeasurementUnit",
            table: "WasteManagementUnitsDetails",
            nullable : false,
            defaultValue : 2,
            oldClrType : typeof(int),
            oldType: "int",
            oldDefaultValue : 1);
      }

      protected override void Down(MigrationBuilder migrationBuilder)
      {
         migrationBuilder.AlterColumn<int>(
            name: "MeasurementUnit",
            table: "Wastes",
            type: "int",
            nullable : false,
            defaultValue : 1,
            oldClrType : typeof(int),
            oldDefaultValue : 2);

         migrationBuilder.AlterColumn<int>(
            name: "MeasurementUnit",
            table: "WasteManagementUnitsDetails",
            type: "int",
            nullable : false,
            defaultValue : 1,
            oldClrType : typeof(int),
            oldDefaultValue : 2);
      }
   }
}
