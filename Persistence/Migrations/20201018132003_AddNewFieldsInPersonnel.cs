using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddNewFieldsInPersonnel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CooperationEndingDate",
                table: "Personnels",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CooperationStartingDate",
                table: "Personnels",
                nullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Date",
                table: "IndustryMonitoringReferences",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetime(6)",
                oldDefaultValue: new DateTimeOffset(new DateTime(2020, 10, 15, 12, 12, 32, 47, DateTimeKind.Unspecified).AddTicks(6556), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CooperationEndingDate",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "CooperationStartingDate",
                table: "Personnels");

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "Date",
                table: "IndustryMonitoringReferences",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(2020, 10, 15, 12, 12, 32, 47, DateTimeKind.Unspecified).AddTicks(6556), new TimeSpan(0, 0, 0, 0, 0)),
                oldClrType: typeof(DateTimeOffset));
        }
    }
}
