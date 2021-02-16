using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class MoveParamClassificationToLabRankingCodingParametersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var deleteOldRecords = @"DELETE FROM LabRankingCodings";
            migrationBuilder.Sql(deleteOldRecords);

            migrationBuilder.DropForeignKey(
                name: "FK_LabRankingCodings_EnumData_ParamClassificationId",
                table: "LabRankingCodings");

            migrationBuilder.DropIndex(
                name: "IX_LabRankingCodings_ParamClassificationId",
                table: "LabRankingCodings");

            migrationBuilder.DropColumn(
                name: "ParamClassificationId",
                table: "LabRankingCodings");

            migrationBuilder.AddColumn<int>(
                name: "ParamClassificationId",
                table: "LabRankingCodingParameters",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LabRankingCodingParameters_ParamClassificationId",
                table: "LabRankingCodingParameters",
                column: "ParamClassificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabRankingCodingParameters_EnumData_ParamClassificationId",
                table: "LabRankingCodingParameters",
                column: "ParamClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LabRankingCodingParameters_EnumData_ParamClassificationId",
                table: "LabRankingCodingParameters");

            migrationBuilder.DropIndex(
                name: "IX_LabRankingCodingParameters_ParamClassificationId",
                table: "LabRankingCodingParameters");

            migrationBuilder.DropColumn(
                name: "ParamClassificationId",
                table: "LabRankingCodingParameters");

            migrationBuilder.AddColumn<int>(
                name: "ParamClassificationId",
                table: "LabRankingCodings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LabRankingCodings_ParamClassificationId",
                table: "LabRankingCodings",
                column: "ParamClassificationId");

            migrationBuilder.AddForeignKey(
                name: "FK_LabRankingCodings_EnumData_ParamClassificationId",
                table: "LabRankingCodings",
                column: "ParamClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
