using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeFewFieldsToNullableHydrometryStation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ReperTypeId",
                table: "HydrometryStations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "HydrometryEquipmentTypeId",
                table: "HydrometryStations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "HydrometryBuilderCompanyId",
                table: "HydrometryStations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DataLoggerCompanyId",
                table: "HydrometryStations",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ReperTypeId",
                table: "HydrometryStations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HydrometryEquipmentTypeId",
                table: "HydrometryStations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HydrometryBuilderCompanyId",
                table: "HydrometryStations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DataLoggerCompanyId",
                table: "HydrometryStations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
