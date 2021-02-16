using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SlaughterHouseSpecialtyInfoTableFieldTypeChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasBloodCollectionTank",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "HasBloodMeatPowderProductionUnit",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "HasFloorChannelsNetwork",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "HasLivestockLossesWell",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "HasQuarantineUnit",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "HasRespectiveBloodDirectionChannel",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "HasSeparationCleaningViscera",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "HasSeparationRecyclingBlood",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "HasWasteBakingUnit",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.AddColumn<int>(
                name: "BloodCollectionTank",
                table: "SlaughterHouseSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BloodMeatPowderProductionUnit",
                table: "SlaughterHouseSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FloorChannelsNetwork",
                table: "SlaughterHouseSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LivestockLossesWell",
                table: "SlaughterHouseSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuarantineUnit",
                table: "SlaughterHouseSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RespectiveBloodDirectionChannel",
                table: "SlaughterHouseSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeparationCleaningViscera",
                table: "SlaughterHouseSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SeparationRecyclingBlood",
                table: "SlaughterHouseSpecialtyInfos",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WasteBakingUnit",
                table: "SlaughterHouseSpecialtyInfos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BloodCollectionTank",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "BloodMeatPowderProductionUnit",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "FloorChannelsNetwork",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "LivestockLossesWell",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "QuarantineUnit",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "RespectiveBloodDirectionChannel",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "SeparationCleaningViscera",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "SeparationRecyclingBlood",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropColumn(
                name: "WasteBakingUnit",
                table: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.AddColumn<int>(
                name: "HasBloodCollectionTank",
                table: "SlaughterHouseSpecialtyInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HasBloodMeatPowderProductionUnit",
                table: "SlaughterHouseSpecialtyInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HasFloorChannelsNetwork",
                table: "SlaughterHouseSpecialtyInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HasLivestockLossesWell",
                table: "SlaughterHouseSpecialtyInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HasQuarantineUnit",
                table: "SlaughterHouseSpecialtyInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HasRespectiveBloodDirectionChannel",
                table: "SlaughterHouseSpecialtyInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HasSeparationCleaningViscera",
                table: "SlaughterHouseSpecialtyInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HasSeparationRecyclingBlood",
                table: "SlaughterHouseSpecialtyInfos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HasWasteBakingUnit",
                table: "SlaughterHouseSpecialtyInfos",
                type: "int",
                nullable: true);
        }
    }
}
