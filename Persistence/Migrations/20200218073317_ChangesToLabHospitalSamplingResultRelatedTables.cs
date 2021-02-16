using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangesToLabHospitalSamplingResultRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HospitalExperimentParametersClassifications");

            migrationBuilder.DropColumn(
                name: "ParametersListDescription",
                table: "HospitalSamplingResults");

            migrationBuilder.AddColumn<int>(
                name: "CalibrationDate",
                table: "HospitalMedicalWasteStatusResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CalibrationDocumentFileNameId",
                table: "HospitalMedicalWasteStatusResults",
                maxLength: 38,
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_HospitalMedicalWasteStatusResults_CalibrationDocumentFileNam~",
                table: "HospitalMedicalWasteStatusResults",
                column: "CalibrationDocumentFileNameId");

            migrationBuilder.AddForeignKey(
                name: "FK_HospitalMedicalWasteStatusResults_Uploads_CalibrationDocumen~",
                table: "HospitalMedicalWasteStatusResults",
                column: "CalibrationDocumentFileNameId",
                principalTable: "Uploads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HospitalMedicalWasteStatusResults_Uploads_CalibrationDocumen~",
                table: "HospitalMedicalWasteStatusResults");

            migrationBuilder.DropIndex(
                name: "IX_HospitalMedicalWasteStatusResults_CalibrationDocumentFileNam~",
                table: "HospitalMedicalWasteStatusResults");

            migrationBuilder.DropColumn(
                name: "CalibrationDate",
                table: "HospitalMedicalWasteStatusResults");

            migrationBuilder.DropColumn(
                name: "CalibrationDocumentFileNameId",
                table: "HospitalMedicalWasteStatusResults");

            migrationBuilder.AddColumn<string>(
                name: "ParametersListDescription",
                table: "HospitalSamplingResults",
                type: "longtext",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "HospitalExperimentParametersClassifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreatedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    HospitalSamplingResultId = table.Column<int>(type: "int", nullable: false),
                    ModifiedByBrowserName = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(type: "int", nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    ParamClassificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HospitalExperimentParametersClassifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HospitalExperimentParametersClassifications_HospitalSampling~",
                        column: x => x.HospitalSamplingResultId,
                        principalTable: "HospitalSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HospitalExperimentParametersClassifications_EnumData_ParamCl~",
                        column: x => x.ParamClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HospitalExperimentParametersClassifications_HospitalSampling~",
                table: "HospitalExperimentParametersClassifications",
                column: "HospitalSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_HospitalExperimentParametersClassifications_ParamClassificat~",
                table: "HospitalExperimentParametersClassifications",
                column: "ParamClassificationId");
        }
    }
}
