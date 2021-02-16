using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddIndustryEvaultionAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IndustryEvaluations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryId = table.Column<int>(nullable: false),
                    UnitTotalArea = table.Column<double>(nullable: true),
                    IsDevelopingGreenSpace = table.Column<bool>(nullable: true),
                    GreenSpaceCoveringArea = table.Column<double>(nullable: true),
                    WateringSystemTypeId = table.Column<int>(nullable: true),
                    GreenSpacePlacesDescription = table.Column<string>(nullable: true),
                    GreenSpaceCost = table.Column<double>(nullable: true),
                    RelatedNonExpertPersonnel = table.Column<int>(nullable: true),
                    RelatedExpertPersonnel = table.Column<int>(nullable: true),
                    UnitSaleStatus = table.Column<int>(nullable: true),
                    SelectedAsGreenIndustryBefore = table.Column<bool>(nullable: true),
                    EstablishmentEvaluationStatus = table.Column<int>(nullable: true),
                    EesDescription = table.Column<string>(nullable: true),
                    HasEvaluationStudies = table.Column<bool>(nullable: true),
                    CommitmentsList = table.Column<string>(nullable: true),
                    LicenseNumber = table.Column<string>(maxLength: 50, nullable: true),
                    LicenseDate = table.Column<int>(nullable: true),
                    EnvironmentalRequirementsSpecifiedObserved = table.Column<bool>(nullable: true),
                    ErsoDescription = table.Column<string>(nullable: true),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryEvaluations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEvaluations_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryEvaluations_EnumData_WateringSystemTypeId",
                        column: x => x.WateringSystemTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEvaluationEnvironmentalManagementCertificates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryEvaluationId = table.Column<int>(nullable: false),
                    LicenseTypeId = table.Column<int>(nullable: false),
                    LicenseExporterCompanyName = table.Column<string>(maxLength: 400, nullable: true),
                    ReceiptDate = table.Column<int>(nullable: true),
                    ExpireDate = table.Column<int>(nullable: true),
                    ExtendedDate = table.Column<int>(nullable: true),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryEvaluationEnvironmentalManagementCertificates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEvaluationEnvironmentalManagementCertificates_Indust~",
                        column: x => x.IndustryEvaluationId,
                        principalTable: "IndustryEvaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryEvaluationEnvironmentalManagementCertificates_EnumDa~",
                        column: x => x.LicenseTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEvaluationGreenSpaceSpeciesVegetations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryEvaluationId = table.Column<int>(nullable: false),
                    SpeciesVegetationTypeId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: true),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryEvaluationGreenSpaceSpeciesVegetations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEvaluationGreenSpaceSpeciesVegetations_IndustryEvalu~",
                        column: x => x.IndustryEvaluationId,
                        principalTable: "IndustryEvaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustryEvaluationGreenSpaceSpeciesVegetations_EnumData_Spec~",
                        column: x => x.SpeciesVegetationTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEvaluationSelectedAsGreenIndustryInformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryEvaluationId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryEvaluationSelectedAsGreenIndustryInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEvaluationSelectedAsGreenIndustryInformations_Indust~",
                        column: x => x.IndustryEvaluationId,
                        principalTable: "IndustryEvaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndustryEvaluationUnitSaleInformations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryEvaluationId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: true),
                    PaidForDescription = table.Column<string>(nullable: true),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndustryEvaluationUnitSaleInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustryEvaluationUnitSaleInformations_IndustryEvaluations_I~",
                        column: x => x.IndustryEvaluationId,
                        principalTable: "IndustryEvaluations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEvaluationEnvironmentalManagementCertificates_Indust~",
                table: "IndustryEvaluationEnvironmentalManagementCertificates",
                column: "IndustryEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEvaluationEnvironmentalManagementCertificates_Licens~",
                table: "IndustryEvaluationEnvironmentalManagementCertificates",
                column: "LicenseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEvaluationGreenSpaceSpeciesVegetations_IndustryEvalu~",
                table: "IndustryEvaluationGreenSpaceSpeciesVegetations",
                column: "IndustryEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEvaluationGreenSpaceSpeciesVegetations_SpeciesVegeta~",
                table: "IndustryEvaluationGreenSpaceSpeciesVegetations",
                column: "SpeciesVegetationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEvaluations_IndustryId",
                table: "IndustryEvaluations",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEvaluations_WateringSystemTypeId",
                table: "IndustryEvaluations",
                column: "WateringSystemTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEvaluationSelectedAsGreenIndustryInformations_Indust~",
                table: "IndustryEvaluationSelectedAsGreenIndustryInformations",
                column: "IndustryEvaluationId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustryEvaluationUnitSaleInformations_IndustryEvaluationId",
                table: "IndustryEvaluationUnitSaleInformations",
                column: "IndustryEvaluationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IndustryEvaluationEnvironmentalManagementCertificates");

            migrationBuilder.DropTable(
                name: "IndustryEvaluationGreenSpaceSpeciesVegetations");

            migrationBuilder.DropTable(
                name: "IndustryEvaluationSelectedAsGreenIndustryInformations");

            migrationBuilder.DropTable(
                name: "IndustryEvaluationUnitSaleInformations");

            migrationBuilder.DropTable(
                name: "IndustryEvaluations");
        }
    }
}
