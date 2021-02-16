using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewFieldsToLabRankingCoding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var deleteOldRecords = @"DELETE FROM LabRankingCodings";
            migrationBuilder.Sql(deleteOldRecords);

            migrationBuilder.DropColumn(
                name: "ScoreLimit",
                table: "LabRankingCodings");

            migrationBuilder.AddColumn<bool>(
                name: "IsPlatformNecessary",
                table: "LabRankingCodings",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "LabLocationMinimumScore",
                table: "LabRankingCodings",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MaxScoreLimit",
                table: "LabRankingCodings",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MinScoreLimit",
                table: "LabRankingCodings",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsPlatformNecessary",
                table: "LabRankingCodings");

            migrationBuilder.DropColumn(
                name: "LabLocationMinimumScore",
                table: "LabRankingCodings");

            migrationBuilder.DropColumn(
                name: "MaxScoreLimit",
                table: "LabRankingCodings");

            migrationBuilder.DropColumn(
                name: "MinScoreLimit",
                table: "LabRankingCodings");

            migrationBuilder.AddColumn<double>(
                name: "ScoreLimit",
                table: "LabRankingCodings",
                type: "double",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
