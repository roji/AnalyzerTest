using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddWasteExportAndRelatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WasteExportImports",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PermittedExportWasteId = table.Column<int>(nullable: true),
                    PermittedImportWasteId = table.Column<int>(nullable: true),
                    CountryId = table.Column<int>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: true),
                    MeasurementUnitId = table.Column<int>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
                    RequestDate = table.Column<DateTimeOffset>(nullable: false),
                    WastePackagingTypeId = table.Column<int>(nullable: true),
                    HasSeveralTransportation = table.Column<bool>(nullable: false),
                    SeveralTransportationDescription = table.Column<string>(nullable: true),
                    HasStandardLabeling = table.Column<bool>(nullable: false),
                    StandardLabelingDescription = table.Column<string>(nullable: true),
                    TransportationVehicleToFirstCustom = table.Column<string>(nullable: true),
                    DocumentNumber = table.Column<int>(nullable: true),
                    WasteExportAnalysisResultFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    Status = table.Column<int>(nullable: false),
                    CreatedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    CreatedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    CreatedByUserId = table.Column<int>(nullable: true),
                    CreatedDateTime = table.Column<DateTimeOffset>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ModifiedByBrowserName = table.Column<string>(maxLength: 1000, nullable: true),
                    ModifiedByIp = table.Column<string>(maxLength: 255, nullable: true),
                    ModifiedByUserId = table.Column<int>(nullable: true),
                    ModifiedDateTime = table.Column<DateTimeOffset>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteExportImports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteExportImports_EnumData_CountryId",
                        column: x => x.CountryId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImports_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImports_EnumData_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImports_EnumData_PermittedExportWasteId",
                        column: x => x.PermittedExportWasteId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImports_EnumData_PermittedImportWasteId",
                        column: x => x.PermittedImportWasteId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImports_Uploads_WasteExportAnalysisResultFileName~",
                        column: x => x.WasteExportAnalysisResultFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImports_EnumData_WastePackagingTypeId",
                        column: x => x.WastePackagingTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WasteExportImportCustoms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomId = table.Column<int>(nullable: false),
                    CustomType = table.Column<int>(nullable: false),
                    WasteExportImportId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WasteExportImportCustoms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteExportImportCustoms_Industries_CustomId",
                        column: x => x.CustomId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImportCustoms_WasteExportImports_WasteExportImpor~",
                        column: x => x.WasteExportImportId,
                        principalTable: "WasteExportImports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteExportImportDescriptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WasteExportImportId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    UserType = table.Column<string>(nullable: true),
                    UserComment = table.Column<string>(nullable: true),
                    SystemComment = table.Column<string>(nullable: true),
                    DescriptionDate = table.Column<DateTimeOffset>(nullable: false),
                    DescriptionType = table.Column<int>(nullable: false, defaultValue: 1),
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
                    table.PrimaryKey("PK_WasteExportImportDescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteExportImportDescriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteExportImportDescriptions_WasteExportImports_WasteExport~",
                        column: x => x.WasteExportImportId,
                        principalTable: "WasteExportImports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteExportImportPassingProvinces",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProvinceId = table.Column<int>(nullable: false),
                    WasteExportImportId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WasteExportImportPassingProvinces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteExportImportPassingProvinces_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImportPassingProvinces_WasteExportImports_WasteEx~",
                        column: x => x.WasteExportImportId,
                        principalTable: "WasteExportImports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteExportImportProformas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProformaNumber = table.Column<string>(nullable: true),
                    ProformaDate = table.Column<int>(nullable: true),
                    HsCodeId = table.Column<int>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    CompanyPhone = table.Column<string>(nullable: true),
                    CompanyAddress = table.Column<string>(nullable: true),
                    CompanyEmail = table.Column<string>(nullable: true),
                    ProformaFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    WasteExportImportId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WasteExportImportProformas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteExportImportProformas_EnumData_HsCodeId",
                        column: x => x.HsCodeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImportProformas_Uploads_ProformaFileNameId",
                        column: x => x.ProformaFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImportProformas_WasteExportImports_WasteExportImp~",
                        column: x => x.WasteExportImportId,
                        principalTable: "WasteExportImports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteExportImportRepresentatives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    NationalCardPhotoFileNameId = table.Column<string>(maxLength: 38, nullable: true),
                    WasteExportImportId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WasteExportImportRepresentatives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteExportImportRepresentatives_Uploads_NationalCardPhotoFi~",
                        column: x => x.NationalCardPhotoFileNameId,
                        principalTable: "Uploads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteExportImportRepresentatives_WasteExportImports_WasteExp~",
                        column: x => x.WasteExportImportId,
                        principalTable: "WasteExportImports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportCustoms_CustomId",
                table: "WasteExportImportCustoms",
                column: "CustomId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportCustoms_WasteExportImportId",
                table: "WasteExportImportCustoms",
                column: "WasteExportImportId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportDescriptions_UserId",
                table: "WasteExportImportDescriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportDescriptions_WasteExportImportId",
                table: "WasteExportImportDescriptions",
                column: "WasteExportImportId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportPassingProvinces_ProvinceId",
                table: "WasteExportImportPassingProvinces",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportPassingProvinces_WasteExportImportId",
                table: "WasteExportImportPassingProvinces",
                column: "WasteExportImportId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportProformas_HsCodeId",
                table: "WasteExportImportProformas",
                column: "HsCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportProformas_ProformaFileNameId",
                table: "WasteExportImportProformas",
                column: "ProformaFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportProformas_WasteExportImportId",
                table: "WasteExportImportProformas",
                column: "WasteExportImportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportRepresentatives_NationalCardPhotoFileNameId",
                table: "WasteExportImportRepresentatives",
                column: "NationalCardPhotoFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImportRepresentatives_WasteExportImportId",
                table: "WasteExportImportRepresentatives",
                column: "WasteExportImportId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImports_CountryId",
                table: "WasteExportImports",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImports_IndustryId",
                table: "WasteExportImports",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImports_MeasurementUnitId",
                table: "WasteExportImports",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImports_PermittedExportWasteId",
                table: "WasteExportImports",
                column: "PermittedExportWasteId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImports_PermittedImportWasteId",
                table: "WasteExportImports",
                column: "PermittedImportWasteId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImports_WasteExportAnalysisResultFileNameId",
                table: "WasteExportImports",
                column: "WasteExportAnalysisResultFileNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteExportImports_WastePackagingTypeId",
                table: "WasteExportImports",
                column: "WastePackagingTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WasteExportImportCustoms");

            migrationBuilder.DropTable(
                name: "WasteExportImportDescriptions");

            migrationBuilder.DropTable(
                name: "WasteExportImportPassingProvinces");

            migrationBuilder.DropTable(
                name: "WasteExportImportProformas");

            migrationBuilder.DropTable(
                name: "WasteExportImportRepresentatives");

            migrationBuilder.DropTable(
                name: "WasteExportImports");
        }
    }
}
