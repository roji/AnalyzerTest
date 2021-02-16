using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class FixDatabaseConflictProblem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnumData",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParentId = table.Column<int>(nullable: true),
                    SystemType = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 255, nullable: false),
                    Data = table.Column<string>(maxLength: 255, nullable: true),
                    Category = table.Column<string>(maxLength: 255, nullable: true),
                    SortKey = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_EnumData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnumData_EnumData_ParentId",
                        column: x => x.ParentId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 450, nullable: false),
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
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RotterdamConventionChemicals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    UnIdentityNumber = table.Column<string>(nullable: true),
                    RiskIdentificationNumber = table.Column<string>(nullable: true),
                    Tag = table.Column<string>(nullable: true),
                    ClassNumber = table.Column<string>(nullable: true),
                    Classification = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_RotterdamConventionChemicals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 450, nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Mobile = table.Column<string>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    ProfileImgFileName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    EmailVerified = table.Column<bool>(nullable: false),
                    MobileVerified = table.Column<bool>(nullable: false),
                    NationalCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ProvinceId = table.Column<int>(nullable: true),
                    RelatedId = table.Column<int>(nullable: true),
                    RegisterDate = table.Column<DateTimeOffset>(nullable: false),
                    LastLoggedIn = table.Column<DateTimeOffset>(nullable: true),
                    SerialNumber = table.Column<string>(maxLength: 450, nullable: true),
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
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Industries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Serial = table.Column<long>(nullable: true),
                    ClassificationId = table.Column<int>(nullable: true),
                    IsicCodeId = table.Column<int>(nullable: true),
                    IsicCode10Id = table.Column<int>(nullable: true),
                    RelatedUserId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_Industries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Industries_EnumData_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Industries_EnumData_IsicCode10Id",
                        column: x => x.IsicCode10Id,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Industries_EnumData_IsicCodeId",
                        column: x => x.IsicCodeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Industries_Users_RelatedUserId",
                        column: x => x.RelatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Labs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    Code = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    OtherActivity = table.Column<bool>(nullable: false),
                    OtherActivityDescription = table.Column<string>(nullable: true),
                    EstablishedYear = table.Column<int>(nullable: true),
                    AirSoundStartedDate = table.Column<int>(nullable: true),
                    BiologyStartedDate = table.Column<int>(nullable: true),
                    PhysicsChemistryStartedDate = table.Column<int>(nullable: true),
                    LabArea = table.Column<int>(nullable: true),
                    LabPlatform = table.Column<int>(nullable: true),
                    ClassificationDescription = table.Column<string>(nullable: true),
                    ClassificationDocumentFileName = table.Column<string>(nullable: true),
                    OwnershipStatusDocumentFileName = table.Column<string>(nullable: true),
                    ClassificationId = table.Column<int>(nullable: true),
                    OwnershipStatusId = table.Column<int>(nullable: true),
                    RelatedUserId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_Labs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Labs_EnumData_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Labs_EnumData_OwnershipStatusId",
                        column: x => x.OwnershipStatusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Labs_Users_RelatedUserId",
                        column: x => x.RelatedUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AccessTokenHash = table.Column<string>(nullable: true),
                    AccessTokenExpiresDateTime = table.Column<DateTimeOffset>(nullable: false),
                    RefreshTokenIdHash = table.Column<string>(maxLength: 450, nullable: false),
                    RefreshTokenIdHashSource = table.Column<string>(maxLength: 450, nullable: true),
                    RefreshTokenExpiresDateTime = table.Column<DateTimeOffset>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_UserTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConsumingMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    DailyAverageProduction = table.Column<int>(nullable: true),
                    DapProductionId = table.Column<int>(nullable: true),
                    MonthlyAverageProduction = table.Column<int>(nullable: true),
                    MapProductionId = table.Column<int>(nullable: true),
                    YearlyAverageProduction = table.Column<int>(nullable: true),
                    YapProductionId = table.Column<int>(nullable: true),
                    IsicCode10Id = table.Column<int>(nullable: true),
                    HasBeenImported = table.Column<bool>(nullable: false),
                    HsCodeId = table.Column<int>(nullable: true),
                    IsChemical = table.Column<bool>(nullable: false),
                    RotterdamConventionChemicalId = table.Column<int>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
                    CmConsumptionPlacesIds = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_ConsumingMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConsumingMaterials_EnumData_DapProductionId",
                        column: x => x.DapProductionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsumingMaterials_EnumData_HsCodeId",
                        column: x => x.HsCodeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsumingMaterials_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsumingMaterials_EnumData_IsicCode10Id",
                        column: x => x.IsicCode10Id,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsumingMaterials_EnumData_MapProductionId",
                        column: x => x.MapProductionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsumingMaterials_RotterdamConventionChemicals_RotterdamCon~",
                        column: x => x.RotterdamConventionChemicalId,
                        principalTable: "RotterdamConventionChemicals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConsumingMaterials_EnumData_YapProductionId",
                        column: x => x.YapProductionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EnergyConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HasElectricityConsumption = table.Column<bool>(nullable: false),
                    EcSupplySourceLocationName = table.Column<string>(nullable: true),
                    EcDailyAverageConsumption = table.Column<int>(nullable: true),
                    EcMonthlyAverageConsumption = table.Column<int>(nullable: true),
                    EcYearlyAverageConsumption = table.Column<int>(nullable: true),
                    HasGasConsumption = table.Column<bool>(nullable: false),
                    GcSupplySourceLocationName = table.Column<string>(nullable: true),
                    GcDailyAverageConsumption = table.Column<int>(nullable: true),
                    GcMonthlyAverageConsumption = table.Column<int>(nullable: true),
                    GcYearlyAverageConsumption = table.Column<int>(nullable: true),
                    HasMazutConsumption = table.Column<bool>(nullable: false),
                    McSupplySourceLocationName = table.Column<string>(nullable: true),
                    McDailyAverageConsumption = table.Column<int>(nullable: true),
                    McMonthlyAverageConsumption = table.Column<int>(nullable: true),
                    McYearlyAverageConsumption = table.Column<int>(nullable: true),
                    HasGasolineConsumption = table.Column<bool>(nullable: false),
                    GlcSupplySourceLocationName = table.Column<string>(nullable: true),
                    GlcDailyAverageConsumption = table.Column<int>(nullable: true),
                    GlcMonthlyAverageConsumption = table.Column<int>(nullable: true),
                    GlcYearlyAverageConsumption = table.Column<int>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_EnergyConsumptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EnergyConsumptions_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HumanResources",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PersonnelTotalNumber = table.Column<int>(nullable: false),
                    HasMorningShift = table.Column<bool>(nullable: false),
                    MorningShiftPersonnelQuantity = table.Column<int>(nullable: true),
                    MorningShiftFromHour = table.Column<string>(nullable: true),
                    MorningShiftToHour = table.Column<string>(nullable: true),
                    HasEveningShift = table.Column<bool>(nullable: false),
                    EveningShiftPersonnelQuantity = table.Column<int>(nullable: true),
                    EveningShiftFromHour = table.Column<string>(nullable: true),
                    EveningShiftToHour = table.Column<string>(nullable: true),
                    HasNightShift = table.Column<bool>(nullable: false),
                    NightShiftPersonnelQuantity = table.Column<int>(nullable: true),
                    NightShiftFromHour = table.Column<string>(nullable: true),
                    NightShiftToHour = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_HumanResources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HumanResources_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndustrialTownsSpecialtyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Area = table.Column<int>(nullable: false),
                    IndustryHighestClassificationEstablished = table.Column<int>(nullable: false),
                    EstablishmentZoningFileName = table.Column<string>(nullable: true),
                    EstablishedIndustryMapFileName = table.Column<string>(nullable: true),
                    EstablishmentGroupingIds = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustrialTownsSpecialtyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustrialTownsSpecialtyInfos_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Industry_License",
                columns: table => new
                {
                    IndustryId = table.Column<int>(nullable: false),
                    TypeNameId = table.Column<int>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    LicenseDate = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_Industry_License", x => x.IndustryId);
                    table.ForeignKey(
                        name: "FK_Industry_License_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Industry_License_EnumData_TypeNameId",
                        column: x => x.TypeNameId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Industry_Managers",
                columns: table => new
                {
                    IndustryId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    ContactInfo_Phone = table.Column<string>(nullable: true),
                    ContactInfo_Mobile = table.Column<string>(nullable: true),
                    ContactInfo_WebSite = table.Column<string>(nullable: true),
                    ContactInfo_Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry_Managers", x => x.IndustryId);
                    table.ForeignKey(
                        name: "FK_Industry_Managers_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Industry_OfficeAddresses",
                columns: table => new
                {
                    IndustryId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    IndustrialTown = table.Column<string>(nullable: true),
                    AddressDetails = table.Column<string>(nullable: true),
                    IsInTownEnv = table.Column<bool>(nullable: true),
                    DistanceToCity = table.Column<int>(nullable: true),
                    ContactInfo_Phone = table.Column<string>(nullable: true),
                    ContactInfo_Mobile = table.Column<string>(nullable: true),
                    ContactInfo_WebSite = table.Column<string>(nullable: true),
                    ContactInfo_Email = table.Column<string>(nullable: true),
                    Geo_Latitude = table.Column<string>(nullable: true),
                    Geo_Longitude = table.Column<string>(nullable: true),
                    Geo_Elevation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry_OfficeAddresses", x => x.IndustryId);
                    table.ForeignKey(
                        name: "FK_Industry_OfficeAddresses_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Industry_OfficeAddresses_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Industry_OfficeAddresses_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Industry_OfficeAddresses_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Industry_WorkshopAddresses",
                columns: table => new
                {
                    IndustryId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    IndustrialTown = table.Column<string>(nullable: true),
                    AddressDetails = table.Column<string>(nullable: true),
                    IsInTownEnv = table.Column<bool>(nullable: true),
                    DistanceToCity = table.Column<int>(nullable: true),
                    ContactInfo_Phone = table.Column<string>(nullable: true),
                    ContactInfo_Mobile = table.Column<string>(nullable: true),
                    ContactInfo_WebSite = table.Column<string>(nullable: true),
                    ContactInfo_Email = table.Column<string>(nullable: true),
                    Geo_Latitude = table.Column<string>(nullable: true),
                    Geo_Longitude = table.Column<string>(nullable: true),
                    Geo_Elevation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Industry_WorkshopAddresses", x => x.IndustryId);
                    table.ForeignKey(
                        name: "FK_Industry_WorkshopAddresses_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Industry_WorkshopAddresses_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Industry_WorkshopAddresses_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Industry_WorkshopAddresses_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LivestockSpecialtyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    LivestockClassificationId = table.Column<int>(nullable: false),
                    AnimalWasteProductionAverage = table.Column<int>(nullable: false),
                    AnimalWasteUseageMethod = table.Column<string>(nullable: true),
                    AnimalWasteChemistryAnalyze = table.Column<string>(nullable: true),
                    AnimalWasteHoldingDuration = table.Column<int>(nullable: false),
                    IsInsideResidentialArea = table.Column<bool>(nullable: true),
                    DistanceToResidentialArea = table.Column<int>(nullable: true),
                    DistanceToMainRoad = table.Column<int>(nullable: true),
                    DistanceToNearestAgriculturalLand = table.Column<int>(nullable: true),
                    DistanceToNearestSlaughterhouse = table.Column<int>(nullable: true),
                    SlaughterhouseName = table.Column<string>(nullable: true),
                    DistanceToNearestForageCollection = table.Column<int>(nullable: true),
                    CollectionName = table.Column<string>(nullable: true),
                    HasHeatingSystem = table.Column<bool>(nullable: true),
                    HeatingSystemDescription = table.Column<string>(nullable: true),
                    BuildingMapFileName = table.Column<string>(nullable: true),
                    IsInSensitiveCentersWindDirection = table.Column<bool>(nullable: true),
                    ScwdDescription = table.Column<string>(nullable: true),
                    DistanceFromRiver = table.Column<int>(nullable: true),
                    SensitiveCentersAroundDescription = table.Column<string>(nullable: true),
                    MinistryOfIndustryLicenseFileName = table.Column<string>(nullable: true),
                    MinistryOfAgricultureLicenseFileName = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_LivestockSpecialtyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivestockSpecialtyInfos_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivestockSpecialtyInfos_EnumData_LivestockClassificationId",
                        column: x => x.LivestockClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManufacturedProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    ProductionMethod = table.Column<string>(nullable: true),
                    DailyAverageProduction = table.Column<int>(nullable: true),
                    DapProductionId = table.Column<int>(nullable: true),
                    MonthlyAverageProduction = table.Column<int>(nullable: true),
                    MapProductionId = table.Column<int>(nullable: true),
                    YearlyAverageProduction = table.Column<int>(nullable: true),
                    YapProductionId = table.Column<int>(nullable: true),
                    IsicCode10Id = table.Column<int>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_ManufacturedProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ManufacturedProducts_EnumData_DapProductionId",
                        column: x => x.DapProductionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManufacturedProducts_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManufacturedProducts_EnumData_IsicCode10Id",
                        column: x => x.IsicCode10Id,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManufacturedProducts_EnumData_MapProductionId",
                        column: x => x.MapProductionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ManufacturedProducts_EnumData_YapProductionId",
                        column: x => x.YapProductionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCenterSelfDeclarationInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HasOncology = table.Column<bool>(nullable: true),
                    OncologyNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    OncologySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasSurgery = table.Column<bool>(nullable: true),
                    SurgeryNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    SurgerySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasChemotherapy = table.Column<bool>(nullable: true),
                    ChemotherapyNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    ChemotherapySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasGeneralPublicHealth = table.Column<bool>(nullable: true),
                    GphNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    GphSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasCardiacCare = table.Column<bool>(nullable: true),
                    CardiacCareNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    CardiacCareSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasEmergency = table.Column<bool>(nullable: true),
                    EmergencyNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    EmergencySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasBoneMarrowTransplantation = table.Column<bool>(nullable: true),
                    BmtNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    BmtSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasDialysisSection = table.Column<bool>(nullable: true),
                    DialysisSectionNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    DialysisSectionSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasNuclearMedicineDepartment = table.Column<bool>(nullable: true),
                    NmdNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    NmdSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasEndoscopicSection = table.Column<bool>(nullable: true),
                    EndoscopicSectionNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    EndoscopicSectionSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasRadiotherapy = table.Column<bool>(nullable: true),
                    RadiotherapyNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    RadiotherapySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasSurgeryRoom = table.Column<bool>(nullable: true),
                    SurgeryRoomNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    SurgeryRoomSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasDentistry = table.Column<bool>(nullable: true),
                    DentistryNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    DentistrySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasMri = table.Column<bool>(nullable: true),
                    MriNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    MriSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasCtScan = table.Column<bool>(nullable: true),
                    CtScanNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    CtScanSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasSonography = table.Column<bool>(nullable: true),
                    SonographyNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    SonographySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasRadiology = table.Column<bool>(nullable: true),
                    RadiologyNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    RadiologySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasAngiographyAndAngioplasty = table.Column<bool>(nullable: true),
                    AaaNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    AaaSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasGeneticsLaboratory = table.Column<bool>(nullable: true),
                    GeneticsLaboratoryNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    GeneticsLaboratorySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasPathologyLaboratory = table.Column<bool>(nullable: true),
                    PathologyLaboratoryNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    PathologyLaboratorySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasAudiologists = table.Column<bool>(nullable: true),
                    AudiologistsNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    AudiologistsSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasPhysiotherapy = table.Column<bool>(nullable: true),
                    PhysiotherapyNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    PhysiotherapySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasPharmacy = table.Column<bool>(nullable: true),
                    PharmacyNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    PharmacySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasBloodAndOncology = table.Column<bool>(nullable: true),
                    BaoNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    BaoSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasCardiovascular = table.Column<bool>(nullable: true),
                    CardiovascularNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    CardiovascularSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasNeurology = table.Column<bool>(nullable: true),
                    NeurologyNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    NeurologySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasGeneralSurgery = table.Column<bool>(nullable: true),
                    GeneralSurgeryNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    GeneralSurgerySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasEarnoseAndThroat = table.Column<bool>(nullable: true),
                    EarnoseAndThroatNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    EarnoseAndThroatSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasPainAndAnesthesia = table.Column<bool>(nullable: true),
                    PainAndAnesthesiaNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    PainAndAnesthesiaSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasNephrology = table.Column<bool>(nullable: true),
                    NephrologyNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    NephrologySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasSkin = table.Column<bool>(nullable: true),
                    SkinNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    SkinSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasPsychiatry = table.Column<bool>(nullable: true),
                    PsychiatryNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    PsychiatrySwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasInfectious = table.Column<bool>(nullable: true),
                    InfectiousNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    InfectiousSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasAdministrativeUnits = table.Column<bool>(nullable: true),
                    AdministrativeUnitsNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    AdministrativeUnitsSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasMedicalEquipment = table.Column<bool>(nullable: true),
                    MedicalEquipmentNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    MedicalEquipmentSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasNutrition = table.Column<bool>(nullable: true),
                    NutritionNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    NutritionSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    HasLaundryRoom = table.Column<bool>(nullable: true),
                    LaundryRoomNwMonthlyProductionQty = table.Column<int>(nullable: true),
                    LaundryRoomSwMonthlyProductionQty = table.Column<int>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_MedicalCenterSelfDeclarationInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCenterSelfDeclarationInfos_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCenterUnitsInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MedicalCenterDependencyTypeId = table.Column<int>(nullable: true),
                    McdtDescription = table.Column<string>(nullable: true),
                    MedicalCenterActivityTypeId = table.Column<int>(nullable: true),
                    McatDescription = table.Column<string>(nullable: true),
                    ActiveBedsQuantity = table.Column<int>(nullable: true),
                    ApprovedBedsQuantity = table.Column<int>(nullable: true),
                    WasteEstimateWaysIds = table.Column<string>(nullable: true),
                    WewDescription = table.Column<string>(nullable: true),
                    DisinfectionDeviceStatusId = table.Column<int>(nullable: true),
                    DdsDescription = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_MedicalCenterUnitsInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCenterUnitsInfos_EnumData_DisinfectionDeviceStatusId",
                        column: x => x.DisinfectionDeviceStatusId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCenterUnitsInfos_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalCenterUnitsInfos_EnumData_MedicalCenterActivityTypeId",
                        column: x => x.MedicalCenterActivityTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCenterUnitsInfos_EnumData_MedicalCenterDependencyType~",
                        column: x => x.MedicalCenterDependencyTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonitoringCodings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AllIsics = table.Column<bool>(nullable: false),
                    IsicCode2Id = table.Column<int>(nullable: true),
                    AllIsic4s = table.Column<bool>(nullable: false),
                    IsicCode4Id = table.Column<int>(nullable: true),
                    AllIsic10s = table.Column<bool>(nullable: true),
                    MonitoringTypeId = table.Column<int>(nullable: false),
                    WasteClassificationId = table.Column<int>(nullable: true),
                    WasteNameId = table.Column<int>(nullable: true),
                    FuelTypeId = table.Column<int>(nullable: true),
                    PollutionReleaseSourceId = table.Column<int>(nullable: true),
                    AcceptedResourceId = table.Column<int>(nullable: true),
                    EstablishmentCode = table.Column<int>(nullable: true),
                    PrivateCodingId = table.Column<int>(nullable: true),
                    IsicCode10Ids = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_MonitoringCodings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonitoringCodings_EnumData_AcceptedResourceId",
                        column: x => x.AcceptedResourceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonitoringCodings_EnumData_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonitoringCodings_EnumData_IsicCode2Id",
                        column: x => x.IsicCode2Id,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonitoringCodings_EnumData_IsicCode4Id",
                        column: x => x.IsicCode4Id,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonitoringCodings_EnumData_MonitoringTypeId",
                        column: x => x.MonitoringTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonitoringCodings_EnumData_PollutionReleaseSourceId",
                        column: x => x.PollutionReleaseSourceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonitoringCodings_Industries_PrivateCodingId",
                        column: x => x.PrivateCodingId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonitoringCodings_EnumData_WasteClassificationId",
                        column: x => x.WasteClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonitoringCodings_EnumData_WasteNameId",
                        column: x => x.WasteNameId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonitoringInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AssessmentStatus = table.Column<bool>(nullable: true),
                    NeedMonitoring = table.Column<bool>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_MonitoringInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonitoringInfos_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HsCodeId = table.Column<int>(nullable: true),
                    MeasurementUnitId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: true),
                    IndustryId = table.Column<int>(nullable: true),
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
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_EnumData_HsCodeId",
                        column: x => x.HsCodeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_EnumData_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    DailyAverageProduction = table.Column<int>(nullable: true),
                    DapProductionId = table.Column<int>(nullable: true),
                    MonthlyAverageProduction = table.Column<int>(nullable: true),
                    MapProductionId = table.Column<int>(nullable: true),
                    YearlyAverageProduction = table.Column<int>(nullable: true),
                    YapProductionId = table.Column<int>(nullable: true),
                    IsicCode10Id = table.Column<int>(nullable: true),
                    HasBeenImported = table.Column<bool>(nullable: false),
                    HsCodeId = table.Column<int>(nullable: true),
                    IsChemical = table.Column<bool>(nullable: false),
                    RotterdamConventionChemicalId = table.Column<int>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
                    RmConsumptionPlacesIds = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_RawMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RawMaterials_EnumData_DapProductionId",
                        column: x => x.DapProductionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RawMaterials_EnumData_HsCodeId",
                        column: x => x.HsCodeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RawMaterials_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RawMaterials_EnumData_IsicCode10Id",
                        column: x => x.IsicCode10Id,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RawMaterials_EnumData_MapProductionId",
                        column: x => x.MapProductionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RawMaterials_RotterdamConventionChemicals_RotterdamConventio~",
                        column: x => x.RotterdamConventionChemicalId,
                        principalTable: "RotterdamConventionChemicals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RawMaterials_EnumData_YapProductionId",
                        column: x => x.YapProductionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SlaughterHouseSpecialtyInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SlaughterHouseClassificationId = table.Column<int>(nullable: false),
                    Capacity = table.Column<long>(nullable: false),
                    IsInSensitiveCentersWindDirection = table.Column<bool>(nullable: true),
                    ScwdDescription = table.Column<string>(nullable: true),
                    IsInsideCity = table.Column<bool>(nullable: true),
                    DistanceFromCity = table.Column<int>(nullable: true),
                    DistanceFromRiver = table.Column<int>(nullable: true),
                    LandTypeId = table.Column<int>(nullable: false),
                    HasQuarantineUnit = table.Column<int>(nullable: true),
                    QuDescription = table.Column<string>(nullable: true),
                    HasSeparationRecyclingBlood = table.Column<int>(nullable: true),
                    SrbDescription = table.Column<string>(nullable: true),
                    HasSeparationCleaningViscera = table.Column<int>(nullable: true),
                    ScvDescription = table.Column<string>(nullable: true),
                    HasFloorChannelsNetwork = table.Column<int>(nullable: true),
                    FcnDescription = table.Column<string>(nullable: true),
                    HasWasteBakingUnit = table.Column<int>(nullable: true),
                    WbuDescription = table.Column<string>(nullable: true),
                    HasBloodMeatPowderProductionUnit = table.Column<int>(nullable: true),
                    BmppuDescription = table.Column<string>(nullable: true),
                    HasLivestockLossesWell = table.Column<int>(nullable: true),
                    LlwDescription = table.Column<string>(nullable: true),
                    HasRespectiveBloodDirectionChannel = table.Column<int>(nullable: true),
                    RbdcDescription = table.Column<string>(nullable: true),
                    HasBloodCollectionTank = table.Column<int>(nullable: true),
                    BctDescription = table.Column<string>(nullable: true),
                    SensitiveSitesAroundSlaughterhouse = table.Column<string>(nullable: true),
                    MinistryOfIndustryLicenseFileName = table.Column<string>(nullable: true),
                    MinistryOfAgricultureLicenseFileName = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_SlaughterHouseSpecialtyInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SlaughterHouseSpecialtyInfos_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlaughterHouseSpecialtyInfos_EnumData_LandTypeId",
                        column: x => x.LandTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SlaughterHouseSpecialtyInfos_EnumData_SlaughterHouseClassifi~",
                        column: x => x.SlaughterHouseClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteCodings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AllIsics = table.Column<bool>(nullable: false),
                    IsicCode2Id = table.Column<int>(nullable: true),
                    AllIsic4s = table.Column<bool>(nullable: false),
                    IsicCode4Id = table.Column<int>(nullable: true),
                    WasteClassificationId = table.Column<int>(nullable: false),
                    WasteNameId = table.Column<int>(nullable: false),
                    IsicCode10Id = table.Column<int>(nullable: false),
                    HsCodeId = table.Column<int>(nullable: false),
                    BaselABId = table.Column<int>(nullable: false),
                    PrivateCodingId = table.Column<int>(nullable: true),
                    WasteBaselYIds = table.Column<string>(nullable: true),
                    WasteBaselHIds = table.Column<string>(nullable: true),
                    WasteBaselRDIds = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_WasteCodings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteCodings_EnumData_BaselABId",
                        column: x => x.BaselABId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteCodings_EnumData_HsCodeId",
                        column: x => x.HsCodeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteCodings_EnumData_IsicCode10Id",
                        column: x => x.IsicCode10Id,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteCodings_EnumData_IsicCode2Id",
                        column: x => x.IsicCode2Id,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteCodings_EnumData_IsicCode4Id",
                        column: x => x.IsicCode4Id,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteCodings_Industries_PrivateCodingId",
                        column: x => x.PrivateCodingId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteCodings_EnumData_WasteClassificationId",
                        column: x => x.WasteClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteCodings_EnumData_WasteNameId",
                        column: x => x.WasteNameId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteManagementUnitsInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryId = table.Column<int>(nullable: false),
                    WasteManagementUnitClassificationId = table.Column<int>(nullable: false),
                    LastApprovalDate = table.Column<int>(nullable: false),
                    LastLicensePhotoName = table.Column<string>(nullable: true),
                    OperationLicensePhotoName = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_WasteManagementUnitsInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteManagementUnitsInfos_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteManagementUnitsInfos_EnumData_WasteManagementUnitClassi~",
                        column: x => x.WasteManagementUnitClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WastewaterDisposals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WastewaterDisposalMethod = table.Column<int>(nullable: false),
                    DailyQuantityMc2 = table.Column<int>(nullable: false),
                    NameAndDescription = table.Column<string>(nullable: true),
                    BasinName = table.Column<string>(nullable: true),
                    DepositAreaLongitude = table.Column<string>(nullable: true),
                    DepositAreaLatitude = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WastewaterDisposals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WastewaterDisposals_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wastewaters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WastewaterTypeId = table.Column<int>(nullable: false),
                    WastewaterProductionReleaseTypeId = table.Column<int>(nullable: false),
                    WastewaterCombinationClassificationIds = table.Column<string>(nullable: true),
                    DangerousPropertiesIds = table.Column<string>(nullable: true),
                    NeedPurificationSystem = table.Column<bool>(nullable: false),
                    ColorDescription = table.Column<string>(nullable: true),
                    OpacityDescription = table.Column<string>(nullable: true),
                    TemperatureDescription = table.Column<string>(nullable: true),
                    SmellDescription = table.Column<string>(nullable: true),
                    SolidsDescription = table.Column<string>(nullable: true),
                    Bacterias = table.Column<bool>(nullable: false),
                    BacteriasDescription = table.Column<string>(nullable: true),
                    Coliforms = table.Column<bool>(nullable: false),
                    ColiformsDescription = table.Column<string>(nullable: true),
                    ParasitesEgg = table.Column<bool>(nullable: false),
                    ParasitesEggDescription = table.Column<string>(nullable: true),
                    Pathogens = table.Column<bool>(nullable: false),
                    PathogensDescription = table.Column<string>(nullable: true),
                    HourlyAverageQuantity = table.Column<int>(nullable: false),
                    HaqMeasurementUnitId = table.Column<int>(nullable: false),
                    HourlyMaximumQuantity = table.Column<int>(nullable: false),
                    HmqMeasurementUnitId = table.Column<int>(nullable: false),
                    DailyAverageQuantity = table.Column<int>(nullable: false),
                    DaqMeasurementUnitId = table.Column<int>(nullable: false),
                    DailyMaximumQuantity = table.Column<int>(nullable: false),
                    DmqMeasurementUnitId = table.Column<int>(nullable: false),
                    WastewaterPurificationSystem = table.Column<int>(nullable: false),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Wastewaters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wastewaters_EnumData_DaqMeasurementUnitId",
                        column: x => x.DaqMeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wastewaters_EnumData_DmqMeasurementUnitId",
                        column: x => x.DmqMeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wastewaters_EnumData_HaqMeasurementUnitId",
                        column: x => x.HaqMeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wastewaters_EnumData_HmqMeasurementUnitId",
                        column: x => x.HmqMeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wastewaters_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wastewaters_EnumData_WastewaterProductionReleaseTypeId",
                        column: x => x.WastewaterProductionReleaseTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wastewaters_EnumData_WastewaterTypeId",
                        column: x => x.WastewaterTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WaterConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    HasCityOrVillageWater = table.Column<bool>(nullable: false),
                    CvSupplySourceLocationName = table.Column<string>(nullable: true),
                    CvDailyAverageConsumption = table.Column<int>(nullable: true),
                    CvMonthlyAverageConsumption = table.Column<int>(nullable: true),
                    CvYearlyAverageConsumption = table.Column<int>(nullable: true),
                    HasGroundWater = table.Column<bool>(nullable: false),
                    GwSupplySourceLocationName = table.Column<string>(nullable: true),
                    GwDailyAverageConsumption = table.Column<int>(nullable: true),
                    GwMonthlyAverageConsumption = table.Column<int>(nullable: true),
                    GwYearlyAverageConsumption = table.Column<int>(nullable: true),
                    HasSurfaceWater = table.Column<bool>(nullable: false),
                    SwSupplySourceLocationName = table.Column<string>(nullable: true),
                    SwDailyAverageConsumption = table.Column<int>(nullable: true),
                    SwMonthlyAverageConsumption = table.Column<int>(nullable: true),
                    SwYearlyAverageConsumption = table.Column<int>(nullable: true),
                    HasSeaWater = table.Column<bool>(nullable: false),
                    SeawSupplySourceLocationName = table.Column<string>(nullable: true),
                    SeawDailyAverageConsumption = table.Column<int>(nullable: true),
                    SeawMonthlyAverageConsumption = table.Column<int>(nullable: true),
                    SeawYearlyAverageConsumption = table.Column<int>(nullable: true),
                    CwConsumptionPlacesIds = table.Column<string>(nullable: true),
                    GwConsumptionPlacesIds = table.Column<string>(nullable: true),
                    SwConsumptionPlacesIds = table.Column<string>(nullable: true),
                    SeawConsumptionPlacesIds = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WaterConsumptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WaterConsumptions_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    SerialCode = table.Column<string>(nullable: true),
                    DeviceModel = table.Column<string>(nullable: true),
                    FaultyCause = table.Column<string>(nullable: true),
                    FaultyCauseDescription = table.Column<string>(nullable: true),
                    AttachmentsDescription = table.Column<string>(nullable: true),
                    LastCalibrationDate = table.Column<int>(nullable: true),
                    HasAttachments = table.Column<bool>(nullable: false),
                    IsDeviceHealthy = table.Column<bool>(nullable: false),
                    EquipmentPhotoFileName = table.Column<string>(nullable: true),
                    CalibrationLicensePhotoFileName = table.Column<string>(nullable: true),
                    SpecialtySectionId = table.Column<int>(nullable: true),
                    DeviceTypeId = table.Column<int>(nullable: true),
                    CalibrationPeriodId = table.Column<int>(nullable: true),
                    LabId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Equipments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipments_EnumData_CalibrationPeriodId",
                        column: x => x.CalibrationPeriodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipments_EnumData_DeviceTypeId",
                        column: x => x.DeviceTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipments_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Equipments_EnumData_SpecialtySectionId",
                        column: x => x.SpecialtySectionId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lab_Addresses",
                columns: table => new
                {
                    LabId = table.Column<int>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: true),
                    StateId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    IndustrialTown = table.Column<string>(nullable: true),
                    AddressDetails = table.Column<string>(nullable: true),
                    IsInTownEnv = table.Column<bool>(nullable: true),
                    DistanceToCity = table.Column<int>(nullable: true),
                    ContactInfo_Phone = table.Column<string>(nullable: true),
                    ContactInfo_Mobile = table.Column<string>(nullable: true),
                    ContactInfo_WebSite = table.Column<string>(nullable: true),
                    ContactInfo_Email = table.Column<string>(nullable: true),
                    Geo_Latitude = table.Column<string>(nullable: true),
                    Geo_Longitude = table.Column<string>(nullable: true),
                    Geo_Elevation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lab_Addresses", x => x.LabId);
                    table.ForeignKey(
                        name: "FK_Lab_Addresses_EnumData_CityId",
                        column: x => x.CityId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lab_Addresses_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lab_Addresses_EnumData_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lab_Addresses_EnumData_StateId",
                        column: x => x.StateId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lab_Managers",
                columns: table => new
                {
                    LabId = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    NationalCode = table.Column<string>(nullable: true),
                    ContactInfo_Phone = table.Column<string>(nullable: true),
                    ContactInfo_Mobile = table.Column<string>(nullable: true),
                    ContactInfo_WebSite = table.Column<string>(nullable: true),
                    ContactInfo_Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lab_Managers", x => x.LabId);
                    table.ForeignKey(
                        name: "FK_Lab_Managers_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LabConsumingMaterials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConsumableMaterialStandardClassificationId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    MeasurementUnitId = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: true),
                    ExpirationDate = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    LabId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_LabConsumingMaterials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LabConsumingMaterials_EnumData_ConsumableMaterialStandardCla~",
                        column: x => x.ConsumableMaterialStandardClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabConsumingMaterials_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LabConsumingMaterials_EnumData_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Personnels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    NationalCode = table.Column<string>(nullable: true),
                    isExpertInAirSound = table.Column<bool>(nullable: false),
                    isExpertInPhysicsChemistry = table.Column<bool>(nullable: false),
                    isExpertInBiology = table.Column<bool>(nullable: false),
                    AirSoundJobExperience = table.Column<int>(nullable: true),
                    PhysicsChemistryJobExperience = table.Column<int>(nullable: true),
                    BiologyJobExperience = table.Column<int>(nullable: true),
                    PersonnelHistoryFileName = table.Column<string>(nullable: true),
                    NationalCardPhotoFileName = table.Column<string>(nullable: true),
                    DegreeOfEducationFileName = table.Column<string>(nullable: true),
                    MajorId = table.Column<int>(nullable: true),
                    GradeId = table.Column<int>(nullable: true),
                    RankId = table.Column<int>(nullable: true),
                    LabId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Personnels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personnels_EnumData_GradeId",
                        column: x => x.GradeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personnels_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personnels_EnumData_MajorId",
                        column: x => x.MajorId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Personnels_EnumData_RankId",
                        column: x => x.RankId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IndustrialTownsSpecialtyDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IndustryId = table.Column<int>(nullable: false),
                    HadAcceptedWastewater = table.Column<bool>(nullable: false),
                    RejectionReason = table.Column<string>(nullable: true),
                    RejectionDate = table.Column<int>(nullable: true),
                    DepartmentLetterNumber = table.Column<int>(nullable: true),
                    DepartmentLetterDate = table.Column<int>(nullable: true),
                    IndustrialTownsSpecialtyInfoId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustrialTownsSpecialtyDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustrialTownsSpecialtyDetails_IndustrialTownsSpecialtyInfo~",
                        column: x => x.IndustrialTownsSpecialtyInfoId,
                        principalTable: "IndustrialTownsSpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustrialTownsSpecialtyDetails_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LivestockSpecialtyDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DomesticatedAnimalsClassificationId = table.Column<int>(nullable: false),
                    Capacity = table.Column<int>(nullable: false),
                    CurrentBalance = table.Column<int>(nullable: false),
                    Race = table.Column<string>(nullable: true),
                    WeightAverage = table.Column<double>(nullable: false),
                    LivestockSpecialtyInfoId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_LivestockSpecialtyDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivestockSpecialtyDetails_EnumData_DomesticatedAnimalsClassi~",
                        column: x => x.DomesticatedAnimalsClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LivestockSpecialtyDetails_LivestockSpecialtyInfos_LivestockS~",
                        column: x => x.LivestockSpecialtyInfoId,
                        principalTable: "LivestockSpecialtyInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisinfectionDevicesInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DisinfectionDeviceOwnershipId = table.Column<int>(nullable: true),
                    DdoDescription = table.Column<string>(nullable: true),
                    DeviceInActivityCauseId = table.Column<int>(nullable: true),
                    DiacDescription = table.Column<string>(nullable: true),
                    DisinfectionMethodId = table.Column<int>(nullable: true),
                    DmDescription = table.Column<string>(nullable: true),
                    AlternativeDisinfectionMethodId = table.Column<int>(nullable: true),
                    AdmDescription = table.Column<string>(nullable: true),
                    InstalledWasteDisinfectionDevicesName = table.Column<string>(nullable: true),
                    InstalledWasteDisinfectionDevicesModel = table.Column<string>(nullable: true),
                    WasteDisinfectionDeviceInstallationDate = table.Column<int>(nullable: true),
                    AgentForRepairingDevice = table.Column<bool>(nullable: true),
                    ActiveDisinfectionDevicesTotalRealCapacity = table.Column<int>(nullable: true),
                    DisinfectionDeviceTimeDuration = table.Column<int>(nullable: true),
                    WorkingCycleQuantity = table.Column<int>(nullable: true),
                    WasteInfectionProductionDeviceFitsCapacity = table.Column<bool>(nullable: true),
                    WorkingGuidePapers = table.Column<bool>(nullable: true),
                    TrainedOperatorsQuantity = table.Column<int>(nullable: true),
                    ProcessRegistrationFeatures = table.Column<bool>(nullable: true),
                    UsingChemicalIndicators = table.Column<int>(nullable: true),
                    UsingBiologicalIndicators = table.Column<bool>(nullable: true),
                    DoingCalibrationPerYear = table.Column<bool>(nullable: true),
                    DeviceFailureRatePerYear = table.Column<int>(nullable: true),
                    SleepRateAfterEachFailurePerDay = table.Column<int>(nullable: true),
                    MedicalCenterUnitsInfoId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_DisinfectionDevicesInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DisinfectionDevicesInfos_EnumData_AlternativeDisinfectionMet~",
                        column: x => x.AlternativeDisinfectionMethodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DisinfectionDevicesInfos_EnumData_DeviceInActivityCauseId",
                        column: x => x.DeviceInActivityCauseId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DisinfectionDevicesInfos_EnumData_DisinfectionDeviceOwnershi~",
                        column: x => x.DisinfectionDeviceOwnershipId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DisinfectionDevicesInfos_EnumData_DisinfectionMethodId",
                        column: x => x.DisinfectionMethodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DisinfectionDevicesInfos_MedicalCenterUnitsInfos_MedicalCent~",
                        column: x => x.MedicalCenterUnitsInfoId,
                        principalTable: "MedicalCenterUnitsInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalCenterUnitsAdditionalInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Q1 = table.Column<int>(nullable: true),
                    Q2 = table.Column<bool>(nullable: true),
                    Q3 = table.Column<bool>(nullable: true),
                    Q4 = table.Column<bool>(nullable: true),
                    Q5 = table.Column<bool>(nullable: true),
                    Q6 = table.Column<bool>(nullable: true),
                    Q7 = table.Column<bool>(nullable: true),
                    Q8 = table.Column<int>(nullable: true),
                    WasteHoldingMethodId = table.Column<int>(nullable: true),
                    WhmDescription = table.Column<string>(nullable: true),
                    Q9 = table.Column<bool>(nullable: true),
                    Q10 = table.Column<bool>(nullable: true),
                    Q11 = table.Column<bool>(nullable: true),
                    Q12 = table.Column<bool>(nullable: true),
                    Q13 = table.Column<bool>(nullable: true),
                    Q14 = table.Column<bool>(nullable: true),
                    Q15 = table.Column<bool>(nullable: true),
                    Q16 = table.Column<bool>(nullable: true),
                    Q17 = table.Column<bool>(nullable: true),
                    Q18 = table.Column<bool>(nullable: true),
                    Q19 = table.Column<bool>(nullable: true),
                    Q20 = table.Column<bool>(nullable: true),
                    Q21 = table.Column<bool>(nullable: true),
                    Q22 = table.Column<bool>(nullable: true),
                    Q23 = table.Column<bool>(nullable: true),
                    Q24 = table.Column<bool>(nullable: true),
                    Q25 = table.Column<bool>(nullable: true),
                    Q26 = table.Column<bool>(nullable: true),
                    Q27 = table.Column<bool>(nullable: true),
                    Q28 = table.Column<bool>(nullable: true),
                    Q29 = table.Column<bool>(nullable: true),
                    Q30 = table.Column<bool>(nullable: true),
                    Q31 = table.Column<bool>(nullable: true),
                    Q32 = table.Column<bool>(nullable: true),
                    Q33 = table.Column<bool>(nullable: true),
                    Q34 = table.Column<bool>(nullable: true),
                    Q35 = table.Column<bool>(nullable: true),
                    Q36 = table.Column<bool>(nullable: true),
                    Q37 = table.Column<bool>(nullable: true),
                    Q38 = table.Column<bool>(nullable: true),
                    Q39 = table.Column<bool>(nullable: true),
                    Q40 = table.Column<bool>(nullable: true),
                    Q41 = table.Column<bool>(nullable: true),
                    Q42 = table.Column<bool>(nullable: true),
                    Q43 = table.Column<bool>(nullable: true),
                    Q44 = table.Column<bool>(nullable: true),
                    Q45 = table.Column<bool>(nullable: true),
                    Q46 = table.Column<bool>(nullable: true),
                    Q47 = table.Column<bool>(nullable: true),
                    Q48 = table.Column<bool>(nullable: true),
                    Q49 = table.Column<bool>(nullable: true),
                    Q50 = table.Column<bool>(nullable: true),
                    Q51 = table.Column<bool>(nullable: true),
                    Q52 = table.Column<bool>(nullable: true),
                    MunicipalityCompanyReceivedTariffId = table.Column<int>(nullable: true),
                    McrtDescription = table.Column<string>(nullable: true),
                    Q53 = table.Column<int>(nullable: true),
                    Q54 = table.Column<int>(nullable: true),
                    Q55 = table.Column<int>(nullable: true),
                    Q56 = table.Column<int>(nullable: true),
                    Q57 = table.Column<int>(nullable: true),
                    Q58 = table.Column<int>(nullable: true),
                    Q59 = table.Column<int>(nullable: true),
                    Q60 = table.Column<int>(nullable: true),
                    Q61 = table.Column<int>(nullable: true),
                    Q62 = table.Column<int>(nullable: true),
                    Q63 = table.Column<int>(nullable: true),
                    Q64 = table.Column<int>(nullable: true),
                    Q65 = table.Column<int>(nullable: true),
                    Q66 = table.Column<int>(nullable: true),
                    Q67 = table.Column<int>(nullable: true),
                    Q68 = table.Column<int>(nullable: true),
                    MedicalWastesReceiverId = table.Column<int>(nullable: true),
                    MwrDescription = table.Column<string>(nullable: true),
                    MedicalNormalWastesDisposalMethodId = table.Column<int>(nullable: true),
                    MnwdmDescription = table.Column<string>(nullable: true),
                    MedicalInfectionWastesDisposalMethodId = table.Column<int>(nullable: true),
                    MiwdmDescription = table.Column<string>(nullable: true),
                    MedicalChemistryWastesDisposalMethodId = table.Column<int>(nullable: true),
                    McwdmDescription = table.Column<string>(nullable: true),
                    HealthExpertGradeId = table.Column<int>(nullable: true),
                    HegDescription = table.Column<string>(nullable: true),
                    Q69 = table.Column<bool>(nullable: true),
                    Q70 = table.Column<bool>(nullable: true),
                    Q71 = table.Column<bool>(nullable: true),
                    Q72 = table.Column<bool>(nullable: true),
                    Q73 = table.Column<int>(nullable: true),
                    Q74 = table.Column<int>(nullable: true),
                    Q75 = table.Column<int>(nullable: true),
                    Q76 = table.Column<string>(nullable: true),
                    Q77 = table.Column<string>(nullable: true),
                    MedicalCenterUnitsInfoId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_MedicalCenterUnitsAdditionalInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MedicalCenterUnitsAdditionalInfos_EnumData_HealthExpertGrade~",
                        column: x => x.HealthExpertGradeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCenterUnitsAdditionalInfos_MedicalCenterUnitsInfos_Me~",
                        column: x => x.MedicalCenterUnitsInfoId,
                        principalTable: "MedicalCenterUnitsInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalCenterUnitsAdditionalInfos_EnumData_MedicalChemistryW~",
                        column: x => x.MedicalChemistryWastesDisposalMethodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCenterUnitsAdditionalInfos_EnumData_MedicalInfectionW~",
                        column: x => x.MedicalInfectionWastesDisposalMethodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCenterUnitsAdditionalInfos_EnumData_MedicalNormalWast~",
                        column: x => x.MedicalNormalWastesDisposalMethodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCenterUnitsAdditionalInfos_EnumData_MedicalWastesRece~",
                        column: x => x.MedicalWastesReceiverId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCenterUnitsAdditionalInfos_EnumData_MunicipalityCompa~",
                        column: x => x.MunicipalityCompanyReceivedTariffId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MedicalCenterUnitsAdditionalInfos_EnumData_WasteHoldingMetho~",
                        column: x => x.WasteHoldingMethodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonitoringParameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParamClassificationId = table.Column<int>(nullable: false),
                    ParamId = table.Column<int>(nullable: false),
                    MonitoringCodingId = table.Column<int>(nullable: false),
                    MeasurementUnitId = table.Column<int>(nullable: false),
                    LimitAmountQuantity = table.Column<int>(nullable: false),
                    PollutionLimitQuantity = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_MonitoringParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MonitoringParameters_EnumData_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonitoringParameters_MonitoringCodings_MonitoringCodingId",
                        column: x => x.MonitoringCodingId,
                        principalTable: "MonitoringCodings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonitoringParameters_EnumData_ParamClassificationId",
                        column: x => x.ParamClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonitoringParameters_EnumData_ParamId",
                        column: x => x.ParamId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChimneysInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonitoringInfoId = table.Column<int>(nullable: false),
                    Code = table.Column<int>(nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    ReleasePollutionSourceId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_ChimneysInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChimneysInfo_MonitoringInfos_MonitoringInfoId",
                        column: x => x.MonitoringInfoId,
                        principalTable: "MonitoringInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChimneysInfo_EnumData_ReleasePollutionSourceId",
                        column: x => x.ReleasePollutionSourceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteParameter",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParamClassificationId = table.Column<int>(nullable: false),
                    ParamId = table.Column<int>(nullable: false),
                    WasteCodingId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WasteParameter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteParameter_EnumData_ParamClassificationId",
                        column: x => x.ParamClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteParameter_EnumData_ParamId",
                        column: x => x.ParamId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteParameter_WasteCodings_WasteCodingId",
                        column: x => x.WasteCodingId,
                        principalTable: "WasteCodings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wastes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StandardEquipment = table.Column<bool>(nullable: false),
                    FireAlarm = table.Column<bool>(nullable: false),
                    FireFight = table.Column<bool>(nullable: false),
                    ImpermeableRoofless = table.Column<bool>(nullable: false),
                    ImpermeableRoof = table.Column<bool>(nullable: false),
                    VirtualMountlyProduction = table.Column<int>(nullable: true),
                    VmpUnitMeasurementId = table.Column<int>(nullable: true),
                    RealMountlyProduction = table.Column<int>(nullable: true),
                    RmpUnitMeasurementId = table.Column<int>(nullable: true),
                    AvailableQuantity = table.Column<int>(nullable: true),
                    AqUnitMeasurementId = table.Column<int>(nullable: true),
                    RooflessStorageSize = table.Column<int>(nullable: true),
                    RlessUnitMeasurementId = table.Column<int>(nullable: true),
                    RoofStorageSize = table.Column<int>(nullable: true),
                    RssUnitMeasurementId = table.Column<int>(nullable: true),
                    MethodDescription = table.Column<string>(nullable: true),
                    IsWasteRecyclingInUnit = table.Column<bool>(nullable: false),
                    IwriuDescription = table.Column<string>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
                    WasteCodingId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_Wastes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wastes_EnumData_AqUnitMeasurementId",
                        column: x => x.AqUnitMeasurementId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wastes_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Wastes_EnumData_RlessUnitMeasurementId",
                        column: x => x.RlessUnitMeasurementId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wastes_EnumData_RmpUnitMeasurementId",
                        column: x => x.RmpUnitMeasurementId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wastes_EnumData_RssUnitMeasurementId",
                        column: x => x.RssUnitMeasurementId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wastes_EnumData_VmpUnitMeasurementId",
                        column: x => x.VmpUnitMeasurementId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wastes_WasteCodings_WasteCodingId",
                        column: x => x.WasteCodingId,
                        principalTable: "WasteCodings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteManagementUnitsDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WasteManagementUnitsInfoId = table.Column<int>(nullable: false),
                    IsicCode10Id = table.Column<int>(nullable: false),
                    HoldingCapacity = table.Column<int>(nullable: false),
                    HcUnitMeasurementId = table.Column<int>(nullable: false),
                    OverallCapacityOperationLicense = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_WasteManagementUnitsDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteManagementUnitsDetails_EnumData_HcUnitMeasurementId",
                        column: x => x.HcUnitMeasurementId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteManagementUnitsDetails_EnumData_IsicCode10Id",
                        column: x => x.IsicCode10Id,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteManagementUnitsDetails_WasteManagementUnitsInfos_WasteM~",
                        column: x => x.WasteManagementUnitsInfoId,
                        principalTable: "WasteManagementUnitsInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChemicalPropertiesParameters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WastewaterId = table.Column<int>(nullable: false),
                    IngredientClassificationId = table.Column<int>(nullable: false),
                    IngredientId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_ChemicalPropertiesParameters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChemicalPropertiesParameters_EnumData_IngredientClassificati~",
                        column: x => x.IngredientClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChemicalPropertiesParameters_EnumData_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChemicalPropertiesParameters_Wastewaters_WastewaterId",
                        column: x => x.WastewaterId,
                        principalTable: "Wastewaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OutletWastewaters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonitoringInfoId = table.Column<int>(nullable: false),
                    WastewaterId = table.Column<int>(nullable: false),
                    Latitude = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    AcceptedResourceId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_OutletWastewaters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutletWastewaters_EnumData_AcceptedResourceId",
                        column: x => x.AcceptedResourceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutletWastewaters_MonitoringInfos_MonitoringInfoId",
                        column: x => x.MonitoringInfoId,
                        principalTable: "MonitoringInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OutletWastewaters_Wastewaters_WastewaterId",
                        column: x => x.WastewaterId,
                        principalTable: "Wastewaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WwHasPurificationSystems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WastewaterId = table.Column<int>(nullable: false),
                    PurificationSystemIsActive = table.Column<bool>(nullable: true),
                    WastewaterPurificationSystemTypeIds = table.Column<string>(nullable: true),
                    ManufacturerCompanyName = table.Column<string>(nullable: true),
                    HoldingCompanyName = table.Column<string>(nullable: true),
                    SystemUsageValue = table.Column<int>(nullable: true),
                    SuvMeasurementUnitId = table.Column<int>(nullable: true),
                    SystemEstablishedYear = table.Column<string>(nullable: true),
                    SystemUpgradeYear = table.Column<string>(nullable: true),
                    SystemBuildCost = table.Column<long>(nullable: true),
                    HasDeaerator = table.Column<bool>(nullable: true),
                    DeaeratorType = table.Column<string>(nullable: true),
                    DeaeratorDescription = table.Column<string>(nullable: true),
                    HasScreen = table.Column<bool>(nullable: true),
                    ScreenDescription = table.Column<string>(nullable: true),
                    HasGritChamber = table.Column<bool>(nullable: true),
                    GritChamberDescription = table.Column<string>(nullable: true),
                    HasBalancing = table.Column<bool>(nullable: true),
                    BalancingDescription = table.Column<string>(nullable: true),
                    HasPrimarySedimentationPond = table.Column<bool>(nullable: true),
                    PrimarySedimentationPondDescription = table.Column<string>(nullable: true),
                    HasSharpMixingPond = table.Column<bool>(nullable: true),
                    SharpMixingPondDescription = table.Column<string>(nullable: true),
                    HasSlowMixingPond = table.Column<bool>(nullable: true),
                    SlowMixingPondDescription = table.Column<string>(nullable: true),
                    HasSecondarySedimentationPond = table.Column<bool>(nullable: true),
                    SecondarySedimentationPondDescription = table.Column<string>(nullable: true),
                    HasPressFilter = table.Column<bool>(nullable: true),
                    PressFilterDescription = table.Column<string>(nullable: true),
                    PressFilterType = table.Column<string>(nullable: true),
                    HasSepticTank = table.Column<bool>(nullable: true),
                    SepticTankDescription = table.Column<string>(nullable: true),
                    SepticTankType = table.Column<string>(nullable: true),
                    HasPolyethyleneTanks = table.Column<bool>(nullable: true),
                    PolyethyleneTanksDescription = table.Column<string>(nullable: true),
                    PolyethyleneTanksType = table.Column<string>(nullable: true),
                    HasGreaseTrap = table.Column<bool>(nullable: true),
                    GreaseTrapDescription = table.Column<string>(nullable: true),
                    GreaseTrapType = table.Column<string>(nullable: true),
                    HasWastewaterCollectionNetwork = table.Column<bool>(nullable: true),
                    WastewaterCollectionNetworkDescription = table.Column<string>(nullable: true),
                    HasFlowmeter = table.Column<bool>(nullable: true),
                    FlowmeterDescription = table.Column<string>(nullable: true),
                    HasAerationPond = table.Column<bool>(nullable: true),
                    AerationPondDescription = table.Column<string>(nullable: true),
                    HasClearer = table.Column<bool>(nullable: true),
                    ClearerDescription = table.Column<string>(nullable: true),
                    HasDisinfection = table.Column<bool>(nullable: true),
                    DisinfectionDescription = table.Column<string>(nullable: true),
                    HasAdditionalSludgeStorageTank = table.Column<bool>(nullable: true),
                    AdditionalSludgeStorageTankDescription = table.Column<string>(nullable: true),
                    HasReturningSludgePumpStation = table.Column<bool>(nullable: true),
                    ReturningSludgePumpStationDescription = table.Column<string>(nullable: true),
                    HasOutputGasWashingTank = table.Column<bool>(nullable: true),
                    OutputGasWashingTankDescription = table.Column<string>(nullable: true),
                    HasSludgeCondenser = table.Column<bool>(nullable: true),
                    SludgeCondenserDescription = table.Column<string>(nullable: true),
                    HasSludgeDigester = table.Column<bool>(nullable: true),
                    SludgeDigesterDescription = table.Column<string>(nullable: true),
                    HasEvaporationPonds = table.Column<bool>(nullable: true),
                    EvaporationPondsDescription = table.Column<string>(nullable: true),
                    HasAnaerobicPonds = table.Column<bool>(nullable: true),
                    AnaerobicPondsDescription = table.Column<string>(nullable: true),
                    HasFilteration = table.Column<bool>(nullable: true),
                    FilterationDescription = table.Column<string>(nullable: true),
                    HasReverseOsmosis = table.Column<bool>(nullable: true),
                    ReverseOsmosisDescription = table.Column<string>(nullable: true),
                    HasRefinedWastewaterStorageTank = table.Column<bool>(nullable: true),
                    RefinedWastewaterStorageTankDescription = table.Column<string>(nullable: true),
                    HasSludgePurification = table.Column<bool>(nullable: true),
                    UsedForBiologicalFertilizer = table.Column<bool>(nullable: true),
                    IsWastedAndRecorded = table.Column<bool>(nullable: true),
                    SludgePurificationDescription = table.Column<string>(nullable: true),
                    RawSludgeNature = table.Column<bool>(nullable: true),
                    RawSludgeHasDangerous = table.Column<bool>(nullable: true),
                    RawSludgeHasDangerousPropertiesIds = table.Column<string>(nullable: true),
                    DailyRawSludgeOutputQuantity = table.Column<int>(nullable: true),
                    DrsoqMeasurementUnitId = table.Column<int>(nullable: true),
                    MonthlyRawSludgeOutputQuantity = table.Column<int>(nullable: true),
                    MrsoqMeasurementUnitId = table.Column<int>(nullable: true),
                    YearlyRawSludgeOutputQuantity = table.Column<int>(nullable: true),
                    YrsoqMeasurementUnitId = table.Column<int>(nullable: true),
                    HasSludgeCollectionUnit = table.Column<bool>(nullable: true),
                    SludgeCollectionUnitCapacity = table.Column<int>(nullable: true),
                    SludgeCollectionMeasurementUnitId = table.Column<int>(nullable: true),
                    PurificationQualityQuantityBasics = table.Column<string>(nullable: true),
                    RawSludgeAnalyzeResult = table.Column<string>(nullable: true),
                    RefinedSludgeAnalyzeResult = table.Column<string>(nullable: true),
                    PlanSiteFileName = table.Column<string>(nullable: true),
                    RefineryHydraulicPlanFileName = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_WwHasPurificationSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WwHasPurificationSystems_EnumData_DrsoqMeasurementUnitId",
                        column: x => x.DrsoqMeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WwHasPurificationSystems_EnumData_MrsoqMeasurementUnitId",
                        column: x => x.MrsoqMeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WwHasPurificationSystems_EnumData_SludgeCollectionMeasuremen~",
                        column: x => x.SludgeCollectionMeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WwHasPurificationSystems_EnumData_SuvMeasurementUnitId",
                        column: x => x.SuvMeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WwHasPurificationSystems_Wastewaters_WastewaterId",
                        column: x => x.WastewaterId,
                        principalTable: "Wastewaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WwHasPurificationSystems_EnumData_YrsoqMeasurementUnitId",
                        column: x => x.YrsoqMeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WwUseMotherPurificationSystems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WastewaterId = table.Column<int>(nullable: false),
                    MotherPurificationSystemName = table.Column<string>(nullable: true),
                    DistanceToMotherPurificationSystem = table.Column<int>(nullable: false),
                    DepositAreaLongitude = table.Column<string>(nullable: true),
                    DepositAreaLatitude = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_WwUseMotherPurificationSystems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WwUseMotherPurificationSystems_Wastewaters_WastewaterId",
                        column: x => x.WastewaterId,
                        principalTable: "Wastewaters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParametersAndMeasurementMethods",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    StandardExperimentMethod = table.Column<string>(nullable: false),
                    UsingEquipmentId = table.Column<int>(nullable: false),
                    IngredientClassificationId = table.Column<int>(nullable: true),
                    IngredientId = table.Column<int>(nullable: true),
                    LabId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_ParametersAndMeasurementMethods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParametersAndMeasurementMethods_EnumData_IngredientClassific~",
                        column: x => x.IngredientClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParametersAndMeasurementMethods_EnumData_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParametersAndMeasurementMethods_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                        column: x => x.UsingEquipmentId,
                        principalTable: "Equipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IndustrialUnitsSamplingResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrganizationRepresentativeAttendance = table.Column<bool>(nullable: false),
                    DepartmentLetterNumber = table.Column<int>(nullable: true),
                    DepartmentLetterDate = table.Column<int>(nullable: true),
                    MonitoringDate = table.Column<int>(nullable: true),
                    IsMonitoringDone = table.Column<bool>(nullable: false),
                    MonitoringCancelingCause = table.Column<string>(nullable: true),
                    DepartmentAlternativeLetterNumber = table.Column<int>(nullable: true),
                    DepartmentAlternativeLetterDate = table.Column<int>(nullable: true),
                    MonitoringAlternativeDate = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ExperimentReason = table.Column<int>(nullable: false),
                    ExperimentSubject = table.Column<string>(nullable: true),
                    ExperimentReasonDescription = table.Column<string>(nullable: true),
                    RialVolume = table.Column<long>(nullable: true),
                    IndustryContractFileName = table.Column<string>(nullable: true),
                    OrganizationRepresentativeAttendanceFileName = table.Column<string>(nullable: true),
                    MonitoringYear = table.Column<int>(nullable: true),
                    MonitoringPeriodId = table.Column<int>(nullable: true),
                    SamplerExpertId = table.Column<int>(nullable: false),
                    TesterId = table.Column<int>(nullable: false),
                    TechnicalAssistantVerifierId = table.Column<int>(nullable: false),
                    LabManagerVerifierId = table.Column<int>(nullable: false),
                    SamplingExpertsDescription = table.Column<string>(nullable: true),
                    HasLabPartner = table.Column<bool>(nullable: false),
                    LabPartnerId = table.Column<int>(nullable: true),
                    LabPartnerContractFileName = table.Column<string>(nullable: true),
                    LabPartnerParametersIds = table.Column<string>(nullable: true),
                    LabPartnerDescription = table.Column<string>(nullable: true),
                    FinalSave = table.Column<bool>(nullable: false),
                    FinalSaveDate = table.Column<DateTimeOffset>(nullable: true),
                    IndustryId = table.Column<int>(nullable: false),
                    LabId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_IndustrialUnitsSamplingResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IndustrialUnitsSamplingResults_Industries_IndustryId",
                        column: x => x.IndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustrialUnitsSamplingResults_Labs_LabId",
                        column: x => x.LabId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustrialUnitsSamplingResults_Personnels_LabManagerVerifier~",
                        column: x => x.LabManagerVerifierId,
                        principalTable: "Personnels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustrialUnitsSamplingResults_Labs_LabPartnerId",
                        column: x => x.LabPartnerId,
                        principalTable: "Labs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustrialUnitsSamplingResults_EnumData_MonitoringPeriodId",
                        column: x => x.MonitoringPeriodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IndustrialUnitsSamplingResults_Personnels_SamplerExpertId",
                        column: x => x.SamplerExpertId,
                        principalTable: "Personnels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustrialUnitsSamplingResults_Personnels_TechnicalAssistant~",
                        column: x => x.TechnicalAssistantVerifierId,
                        principalTable: "Personnels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndustrialUnitsSamplingResults_Personnels_TesterId",
                        column: x => x.TesterId,
                        principalTable: "Personnels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteTransportation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WasteId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    SenderIndustryId = table.Column<int>(nullable: false),
                    RecieverIndustryId = table.Column<int>(nullable: false),
                    PostedDate = table.Column<int>(nullable: false),
                    RecievedDate = table.Column<int>(nullable: true),
                    RequestDate = table.Column<int>(nullable: true),
                    SubmissionMethodId = table.Column<int>(nullable: true),
                    Price = table.Column<long>(nullable: true),
                    DesAdminAgreement = table.Column<bool>(nullable: false),
                    DesAdminAgreementDate = table.Column<int>(nullable: true),
                    DesAdminAgreementFileName = table.Column<string>(nullable: true),
                    SaleInvoiceFileName = table.Column<string>(nullable: true),
                    EliminationFormFileName = table.Column<string>(nullable: true),
                    WaybillFileName = table.Column<string>(nullable: true),
                    WasteAnalysisFileName = table.Column<string>(nullable: true),
                    LoadingSupervisionAgendaFileName = table.Column<string>(nullable: true),
                    RoadTransportRegulationsObserved = table.Column<bool>(nullable: false),
                    RtroDescription = table.Column<string>(nullable: true),
                    SupervisionOverDischargeFileName = table.Column<string>(nullable: true),
                    WasteTransportStatus = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
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
                    table.PrimaryKey("PK_WasteTransportation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Industries_RecieverIndustryId",
                        column: x => x.RecieverIndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Industries_SenderIndustryId",
                        column: x => x.SenderIndustryId,
                        principalTable: "Industries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_EnumData_SubmissionMethodId",
                        column: x => x.SubmissionMethodId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WasteTransportation_Wastes_WasteId",
                        column: x => x.WasteId,
                        principalTable: "Wastes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParametersSamplingResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MonitoringParametersId = table.Column<int>(nullable: false),
                    MonitoringTypeId = table.Column<int>(nullable: false),
                    WasteClassificationId = table.Column<int>(nullable: true),
                    WasteNameId = table.Column<int>(nullable: true),
                    FuelTypeId = table.Column<int>(nullable: true),
                    PollutionReleaseSourceId = table.Column<int>(nullable: true),
                    AcceptedResourceId = table.Column<int>(nullable: true),
                    EstablishmentCode = table.Column<int>(nullable: true),
                    SamplingDate = table.Column<int>(nullable: true),
                    ExperimentDate = table.Column<int>(nullable: true),
                    EquipmentsIds = table.Column<string>(nullable: true),
                    ExperimentMethod = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DocumentsFileName = table.Column<string>(nullable: true),
                    IndustrialUnitsSamplingResultId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_ParametersSamplingResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParametersSamplingResults_EnumData_AcceptedResourceId",
                        column: x => x.AcceptedResourceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParametersSamplingResults_EnumData_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParametersSamplingResults_IndustrialUnitsSamplingResults_Ind~",
                        column: x => x.IndustrialUnitsSamplingResultId,
                        principalTable: "IndustrialUnitsSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParametersSamplingResults_MonitoringParameters_MonitoringPar~",
                        column: x => x.MonitoringParametersId,
                        principalTable: "MonitoringParameters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParametersSamplingResults_EnumData_MonitoringTypeId",
                        column: x => x.MonitoringTypeId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParametersSamplingResults_EnumData_PollutionReleaseSourceId",
                        column: x => x.PollutionReleaseSourceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParametersSamplingResults_EnumData_WasteClassificationId",
                        column: x => x.WasteClassificationId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParametersSamplingResults_EnumData_WasteNameId",
                        column: x => x.WasteNameId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AmbientAirParametersResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParametersSamplingResultsId = table.Column<int>(nullable: false),
                    MeasurementDuration = table.Column<double>(nullable: false),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    SamplingPlace = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    MeasurementUnitId = table.Column<int>(nullable: false),
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
                    table.PrimaryKey("PK_AmbientAirParametersResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AmbientAirParametersResults_EnumData_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AmbientAirParametersResults_ParametersSamplingResults_Parame~",
                        column: x => x.ParametersSamplingResultsId,
                        principalTable: "ParametersSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChimneyParametersResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParametersSamplingResultsId = table.Column<int>(nullable: false),
                    MeasurementDuration = table.Column<double>(nullable: false),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    MeasurementUnitId = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: true),
                    EntryPointElevation = table.Column<double>(nullable: false),
                    SamplingPlaceElevation = table.Column<double>(nullable: false),
                    Density = table.Column<double>(nullable: false),
                    OxygenVolumePercentage = table.Column<double>(nullable: false),
                    Temperature = table.Column<double>(nullable: false),
                    DynamicPressure = table.Column<double>(nullable: false),
                    AmbientPressure = table.Column<double>(nullable: false),
                    RelativeHumidity = table.Column<double>(nullable: false),
                    GasOutletDebi = table.Column<double>(nullable: false),
                    DioxideCarbonVolumePercentage = table.Column<double>(nullable: false),
                    ExtraAirVolumePercentage = table.Column<double>(nullable: false),
                    ThermalEfficiencyPercentage = table.Column<double>(nullable: false),
                    InnerDiameter = table.Column<double>(nullable: false),
                    OutputGasSpeed = table.Column<double>(nullable: false),
                    DryConditionDensity = table.Column<double>(nullable: false),
                    WetConditionDensity = table.Column<double>(nullable: false),
                    EnergyLoss = table.Column<double>(nullable: false),
                    PollutionReleaseSourceId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChimneyParametersResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChimneyParametersResults_EnumData_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChimneyParametersResults_ParametersSamplingResults_Parameter~",
                        column: x => x.ParametersSamplingResultsId,
                        principalTable: "ParametersSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChimneyParametersResults_EnumData_PollutionReleaseSourceId",
                        column: x => x.PollutionReleaseSourceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MotorVehiclesParametersResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParametersSamplingResultsId = table.Column<int>(nullable: false),
                    OwnerName = table.Column<string>(nullable: true),
                    NumberPlate = table.Column<string>(nullable: true),
                    GasolineOrDiesel = table.Column<bool>(nullable: false),
                    VehicleType = table.Column<string>(nullable: true),
                    BuildYear = table.Column<double>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    MeasurementUnitId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotorVehiclesParametersResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MotorVehiclesParametersResults_EnumData_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MotorVehiclesParametersResults_ParametersSamplingResults_Par~",
                        column: x => x.ParametersSamplingResultsId,
                        principalTable: "ParametersSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SoundAndWavesParametersResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParametersSamplingResultsId = table.Column<int>(nullable: false),
                    DayOrNight = table.Column<bool>(nullable: false),
                    SamplingPlace = table.Column<string>(nullable: true),
                    Longitude = table.Column<string>(nullable: true),
                    Latitude = table.Column<string>(nullable: true),
                    Quantity = table.Column<double>(nullable: false),
                    MeasurementUnitId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoundAndWavesParametersResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SoundAndWavesParametersResults_EnumData_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SoundAndWavesParametersResults_ParametersSamplingResults_Par~",
                        column: x => x.ParametersSamplingResultsId,
                        principalTable: "ParametersSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WasteParametersResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParametersSamplingResultsId = table.Column<int>(nullable: false),
                    VisualSpecs = table.Column<string>(nullable: true),
                    Condition = table.Column<string>(nullable: true),
                    PollutionReleaseSourceId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    MeasurementUnitId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteParametersResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WasteParametersResults_EnumData_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteParametersResults_ParametersSamplingResults_ParametersS~",
                        column: x => x.ParametersSamplingResultsId,
                        principalTable: "ParametersSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WasteParametersResults_EnumData_PollutionReleaseSourceId",
                        column: x => x.PollutionReleaseSourceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WastewaterParametersResults",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ParametersSamplingResultsId = table.Column<int>(nullable: false),
                    VisualSpecs = table.Column<string>(nullable: true),
                    AcceptedResourceId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    MeasurementUnitId = table.Column<int>(nullable: false),
                    Debi = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WastewaterParametersResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WastewaterParametersResults_EnumData_AcceptedResourceId",
                        column: x => x.AcceptedResourceId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WastewaterParametersResults_EnumData_MeasurementUnitId",
                        column: x => x.MeasurementUnitId,
                        principalTable: "EnumData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WastewaterParametersResults_ParametersSamplingResults_Parame~",
                        column: x => x.ParametersSamplingResultsId,
                        principalTable: "ParametersSamplingResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AmbientAirParametersResults_MeasurementUnitId",
                table: "AmbientAirParametersResults",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_AmbientAirParametersResults_ParametersSamplingResultsId",
                table: "AmbientAirParametersResults",
                column: "ParametersSamplingResultsId");

            migrationBuilder.CreateIndex(
                name: "IX_ChemicalPropertiesParameters_IngredientClassificationId",
                table: "ChemicalPropertiesParameters",
                column: "IngredientClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ChemicalPropertiesParameters_IngredientId",
                table: "ChemicalPropertiesParameters",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_ChemicalPropertiesParameters_WastewaterId",
                table: "ChemicalPropertiesParameters",
                column: "WastewaterId");

            migrationBuilder.CreateIndex(
                name: "IX_ChimneyParametersResults_MeasurementUnitId",
                table: "ChimneyParametersResults",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_ChimneyParametersResults_ParametersSamplingResultsId",
                table: "ChimneyParametersResults",
                column: "ParametersSamplingResultsId");

            migrationBuilder.CreateIndex(
                name: "IX_ChimneyParametersResults_PollutionReleaseSourceId",
                table: "ChimneyParametersResults",
                column: "PollutionReleaseSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ChimneysInfo_MonitoringInfoId",
                table: "ChimneysInfo",
                column: "MonitoringInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_ChimneysInfo_ReleasePollutionSourceId",
                table: "ChimneysInfo",
                column: "ReleasePollutionSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumingMaterials_DapProductionId",
                table: "ConsumingMaterials",
                column: "DapProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumingMaterials_HsCodeId",
                table: "ConsumingMaterials",
                column: "HsCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumingMaterials_IndustryId",
                table: "ConsumingMaterials",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumingMaterials_IsicCode10Id",
                table: "ConsumingMaterials",
                column: "IsicCode10Id");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumingMaterials_MapProductionId",
                table: "ConsumingMaterials",
                column: "MapProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumingMaterials_RotterdamConventionChemicalId",
                table: "ConsumingMaterials",
                column: "RotterdamConventionChemicalId");

            migrationBuilder.CreateIndex(
                name: "IX_ConsumingMaterials_YapProductionId",
                table: "ConsumingMaterials",
                column: "YapProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_DisinfectionDevicesInfos_AlternativeDisinfectionMethodId",
                table: "DisinfectionDevicesInfos",
                column: "AlternativeDisinfectionMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_DisinfectionDevicesInfos_DeviceInActivityCauseId",
                table: "DisinfectionDevicesInfos",
                column: "DeviceInActivityCauseId");

            migrationBuilder.CreateIndex(
                name: "IX_DisinfectionDevicesInfos_DisinfectionDeviceOwnershipId",
                table: "DisinfectionDevicesInfos",
                column: "DisinfectionDeviceOwnershipId");

            migrationBuilder.CreateIndex(
                name: "IX_DisinfectionDevicesInfos_DisinfectionMethodId",
                table: "DisinfectionDevicesInfos",
                column: "DisinfectionMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_DisinfectionDevicesInfos_MedicalCenterUnitsInfoId",
                table: "DisinfectionDevicesInfos",
                column: "MedicalCenterUnitsInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EnergyConsumptions_IndustryId",
                table: "EnergyConsumptions",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_EnumData_Data",
                table: "EnumData",
                column: "Data");

            migrationBuilder.CreateIndex(
                name: "IX_EnumData_ParentId",
                table: "EnumData",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_EnumData_Title",
                table: "EnumData",
                column: "Title");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_CalibrationPeriodId",
                table: "Equipments",
                column: "CalibrationPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_DeviceTypeId",
                table: "Equipments",
                column: "DeviceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_LabId",
                table: "Equipments",
                column: "LabId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipments_SpecialtySectionId",
                table: "Equipments",
                column: "SpecialtySectionId");

            migrationBuilder.CreateIndex(
                name: "IX_HumanResources_IndustryId",
                table: "HumanResources",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialTownsSpecialtyDetails_IndustrialTownsSpecialtyInfo~",
                table: "IndustrialTownsSpecialtyDetails",
                column: "IndustrialTownsSpecialtyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialTownsSpecialtyDetails_IndustryId",
                table: "IndustrialTownsSpecialtyDetails",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialTownsSpecialtyInfos_IndustryId",
                table: "IndustrialTownsSpecialtyInfos",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_IndustryId",
                table: "IndustrialUnitsSamplingResults",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_LabId",
                table: "IndustrialUnitsSamplingResults",
                column: "LabId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_LabManagerVerifierId",
                table: "IndustrialUnitsSamplingResults",
                column: "LabManagerVerifierId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_LabPartnerId",
                table: "IndustrialUnitsSamplingResults",
                column: "LabPartnerId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_MonitoringPeriodId",
                table: "IndustrialUnitsSamplingResults",
                column: "MonitoringPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_SamplerExpertId",
                table: "IndustrialUnitsSamplingResults",
                column: "SamplerExpertId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_TechnicalAssistantVerifierId",
                table: "IndustrialUnitsSamplingResults",
                column: "TechnicalAssistantVerifierId");

            migrationBuilder.CreateIndex(
                name: "IX_IndustrialUnitsSamplingResults_TesterId",
                table: "IndustrialUnitsSamplingResults",
                column: "TesterId");

            migrationBuilder.CreateIndex(
                name: "IX_Industries_ClassificationId",
                table: "Industries",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Industries_IsicCode10Id",
                table: "Industries",
                column: "IsicCode10Id");

            migrationBuilder.CreateIndex(
                name: "IX_Industries_IsicCodeId",
                table: "Industries",
                column: "IsicCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Industries_RelatedUserId",
                table: "Industries",
                column: "RelatedUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Industry_License_TypeNameId",
                table: "Industry_License",
                column: "TypeNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Industry_OfficeAddresses_CityId",
                table: "Industry_OfficeAddresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Industry_OfficeAddresses_ProvinceId",
                table: "Industry_OfficeAddresses",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Industry_OfficeAddresses_StateId",
                table: "Industry_OfficeAddresses",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Industry_WorkshopAddresses_CityId",
                table: "Industry_WorkshopAddresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Industry_WorkshopAddresses_ProvinceId",
                table: "Industry_WorkshopAddresses",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Industry_WorkshopAddresses_StateId",
                table: "Industry_WorkshopAddresses",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Lab_Addresses_CityId",
                table: "Lab_Addresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Lab_Addresses_ProvinceId",
                table: "Lab_Addresses",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Lab_Addresses_StateId",
                table: "Lab_Addresses",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_LabConsumingMaterials_ConsumableMaterialStandardClassificati~",
                table: "LabConsumingMaterials",
                column: "ConsumableMaterialStandardClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_LabConsumingMaterials_LabId",
                table: "LabConsumingMaterials",
                column: "LabId");

            migrationBuilder.CreateIndex(
                name: "IX_LabConsumingMaterials_MeasurementUnitId",
                table: "LabConsumingMaterials",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Labs_ClassificationId",
                table: "Labs",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Labs_OwnershipStatusId",
                table: "Labs",
                column: "OwnershipStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Labs_RelatedUserId",
                table: "Labs",
                column: "RelatedUserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyDetails_DomesticatedAnimalsClassificationId",
                table: "LivestockSpecialtyDetails",
                column: "DomesticatedAnimalsClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyDetails_LivestockSpecialtyInfoId",
                table: "LivestockSpecialtyDetails",
                column: "LivestockSpecialtyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyInfos_IndustryId",
                table: "LivestockSpecialtyInfos",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_LivestockSpecialtyInfos_LivestockClassificationId",
                table: "LivestockSpecialtyInfos",
                column: "LivestockClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturedProducts_DapProductionId",
                table: "ManufacturedProducts",
                column: "DapProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturedProducts_IndustryId",
                table: "ManufacturedProducts",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturedProducts_IsicCode10Id",
                table: "ManufacturedProducts",
                column: "IsicCode10Id");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturedProducts_MapProductionId",
                table: "ManufacturedProducts",
                column: "MapProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_ManufacturedProducts_YapProductionId",
                table: "ManufacturedProducts",
                column: "YapProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterSelfDeclarationInfos_IndustryId",
                table: "MedicalCenterSelfDeclarationInfos",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterUnitsAdditionalInfos_HealthExpertGradeId",
                table: "MedicalCenterUnitsAdditionalInfos",
                column: "HealthExpertGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterUnitsAdditionalInfos_MedicalCenterUnitsInfoId",
                table: "MedicalCenterUnitsAdditionalInfos",
                column: "MedicalCenterUnitsInfoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterUnitsAdditionalInfos_MedicalChemistryWastesDisp~",
                table: "MedicalCenterUnitsAdditionalInfos",
                column: "MedicalChemistryWastesDisposalMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterUnitsAdditionalInfos_MedicalInfectionWastesDisp~",
                table: "MedicalCenterUnitsAdditionalInfos",
                column: "MedicalInfectionWastesDisposalMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterUnitsAdditionalInfos_MedicalNormalWastesDisposa~",
                table: "MedicalCenterUnitsAdditionalInfos",
                column: "MedicalNormalWastesDisposalMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterUnitsAdditionalInfos_MedicalWastesReceiverId",
                table: "MedicalCenterUnitsAdditionalInfos",
                column: "MedicalWastesReceiverId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterUnitsAdditionalInfos_MunicipalityCompanyReceive~",
                table: "MedicalCenterUnitsAdditionalInfos",
                column: "MunicipalityCompanyReceivedTariffId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterUnitsAdditionalInfos_WasteHoldingMethodId",
                table: "MedicalCenterUnitsAdditionalInfos",
                column: "WasteHoldingMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterUnitsInfos_DisinfectionDeviceStatusId",
                table: "MedicalCenterUnitsInfos",
                column: "DisinfectionDeviceStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterUnitsInfos_IndustryId",
                table: "MedicalCenterUnitsInfos",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterUnitsInfos_MedicalCenterActivityTypeId",
                table: "MedicalCenterUnitsInfos",
                column: "MedicalCenterActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalCenterUnitsInfos_MedicalCenterDependencyTypeId",
                table: "MedicalCenterUnitsInfos",
                column: "MedicalCenterDependencyTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringCodings_AcceptedResourceId",
                table: "MonitoringCodings",
                column: "AcceptedResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringCodings_FuelTypeId",
                table: "MonitoringCodings",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringCodings_IsicCode2Id",
                table: "MonitoringCodings",
                column: "IsicCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringCodings_IsicCode4Id",
                table: "MonitoringCodings",
                column: "IsicCode4Id");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringCodings_MonitoringTypeId",
                table: "MonitoringCodings",
                column: "MonitoringTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringCodings_PollutionReleaseSourceId",
                table: "MonitoringCodings",
                column: "PollutionReleaseSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringCodings_PrivateCodingId",
                table: "MonitoringCodings",
                column: "PrivateCodingId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringCodings_WasteClassificationId",
                table: "MonitoringCodings",
                column: "WasteClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringCodings_WasteNameId",
                table: "MonitoringCodings",
                column: "WasteNameId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringInfos_IndustryId",
                table: "MonitoringInfos",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringParameters_MeasurementUnitId",
                table: "MonitoringParameters",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringParameters_MonitoringCodingId",
                table: "MonitoringParameters",
                column: "MonitoringCodingId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringParameters_ParamClassificationId",
                table: "MonitoringParameters",
                column: "ParamClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_MonitoringParameters_ParamId",
                table: "MonitoringParameters",
                column: "ParamId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorVehiclesParametersResults_MeasurementUnitId",
                table: "MotorVehiclesParametersResults",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_MotorVehiclesParametersResults_ParametersSamplingResultsId",
                table: "MotorVehiclesParametersResults",
                column: "ParametersSamplingResultsId");

            migrationBuilder.CreateIndex(
                name: "IX_OutletWastewaters_AcceptedResourceId",
                table: "OutletWastewaters",
                column: "AcceptedResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_OutletWastewaters_MonitoringInfoId",
                table: "OutletWastewaters",
                column: "MonitoringInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_OutletWastewaters_WastewaterId",
                table: "OutletWastewaters",
                column: "WastewaterId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersAndMeasurementMethods_IngredientClassificationId",
                table: "ParametersAndMeasurementMethods",
                column: "IngredientClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersAndMeasurementMethods_IngredientId",
                table: "ParametersAndMeasurementMethods",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersAndMeasurementMethods_LabId",
                table: "ParametersAndMeasurementMethods",
                column: "LabId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersAndMeasurementMethods_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "UsingEquipmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersSamplingResults_AcceptedResourceId",
                table: "ParametersSamplingResults",
                column: "AcceptedResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersSamplingResults_FuelTypeId",
                table: "ParametersSamplingResults",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersSamplingResults_IndustrialUnitsSamplingResultId",
                table: "ParametersSamplingResults",
                column: "IndustrialUnitsSamplingResultId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersSamplingResults_MonitoringParametersId",
                table: "ParametersSamplingResults",
                column: "MonitoringParametersId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersSamplingResults_MonitoringTypeId",
                table: "ParametersSamplingResults",
                column: "MonitoringTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersSamplingResults_PollutionReleaseSourceId",
                table: "ParametersSamplingResults",
                column: "PollutionReleaseSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersSamplingResults_WasteClassificationId",
                table: "ParametersSamplingResults",
                column: "WasteClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_ParametersSamplingResults_WasteNameId",
                table: "ParametersSamplingResults",
                column: "WasteNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_GradeId",
                table: "Personnels",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_LabId",
                table: "Personnels",
                column: "LabId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_MajorId",
                table: "Personnels",
                column: "MajorId");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_RankId",
                table: "Personnels",
                column: "RankId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_HsCodeId",
                table: "Product",
                column: "HsCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_IndustryId",
                table: "Product",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_MeasurementUnitId",
                table: "Product",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_DapProductionId",
                table: "RawMaterials",
                column: "DapProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_HsCodeId",
                table: "RawMaterials",
                column: "HsCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_IndustryId",
                table: "RawMaterials",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_IsicCode10Id",
                table: "RawMaterials",
                column: "IsicCode10Id");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_MapProductionId",
                table: "RawMaterials",
                column: "MapProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_RotterdamConventionChemicalId",
                table: "RawMaterials",
                column: "RotterdamConventionChemicalId");

            migrationBuilder.CreateIndex(
                name: "IX_RawMaterials_YapProductionId",
                table: "RawMaterials",
                column: "YapProductionId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_Name",
                table: "Roles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SlaughterHouseSpecialtyInfos_IndustryId",
                table: "SlaughterHouseSpecialtyInfos",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SlaughterHouseSpecialtyInfos_LandTypeId",
                table: "SlaughterHouseSpecialtyInfos",
                column: "LandTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SlaughterHouseSpecialtyInfos_SlaughterHouseClassificationId",
                table: "SlaughterHouseSpecialtyInfos",
                column: "SlaughterHouseClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_SoundAndWavesParametersResults_MeasurementUnitId",
                table: "SoundAndWavesParametersResults",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_SoundAndWavesParametersResults_ParametersSamplingResultsId",
                table: "SoundAndWavesParametersResults",
                column: "ParametersSamplingResultsId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_Mobile",
                table: "Users",
                column: "Mobile",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_ProvinceId",
                table: "Users",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserTokens_UserId",
                table: "UserTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteCodings_BaselABId",
                table: "WasteCodings",
                column: "BaselABId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteCodings_HsCodeId",
                table: "WasteCodings",
                column: "HsCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteCodings_IsicCode10Id",
                table: "WasteCodings",
                column: "IsicCode10Id");

            migrationBuilder.CreateIndex(
                name: "IX_WasteCodings_IsicCode2Id",
                table: "WasteCodings",
                column: "IsicCode2Id");

            migrationBuilder.CreateIndex(
                name: "IX_WasteCodings_IsicCode4Id",
                table: "WasteCodings",
                column: "IsicCode4Id");

            migrationBuilder.CreateIndex(
                name: "IX_WasteCodings_PrivateCodingId",
                table: "WasteCodings",
                column: "PrivateCodingId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteCodings_WasteClassificationId",
                table: "WasteCodings",
                column: "WasteClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteCodings_WasteNameId",
                table: "WasteCodings",
                column: "WasteNameId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteManagementUnitsDetails_HcUnitMeasurementId",
                table: "WasteManagementUnitsDetails",
                column: "HcUnitMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteManagementUnitsDetails_IsicCode10Id",
                table: "WasteManagementUnitsDetails",
                column: "IsicCode10Id");

            migrationBuilder.CreateIndex(
                name: "IX_WasteManagementUnitsDetails_WasteManagementUnitsInfoId",
                table: "WasteManagementUnitsDetails",
                column: "WasteManagementUnitsInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteManagementUnitsInfos_IndustryId",
                table: "WasteManagementUnitsInfos",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WasteManagementUnitsInfos_WasteManagementUnitClassificationId",
                table: "WasteManagementUnitsInfos",
                column: "WasteManagementUnitClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteParameter_ParamClassificationId",
                table: "WasteParameter",
                column: "ParamClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteParameter_ParamId",
                table: "WasteParameter",
                column: "ParamId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteParameter_WasteCodingId",
                table: "WasteParameter",
                column: "WasteCodingId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteParametersResults_MeasurementUnitId",
                table: "WasteParametersResults",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteParametersResults_ParametersSamplingResultsId",
                table: "WasteParametersResults",
                column: "ParametersSamplingResultsId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteParametersResults_PollutionReleaseSourceId",
                table: "WasteParametersResults",
                column: "PollutionReleaseSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_AqUnitMeasurementId",
                table: "Wastes",
                column: "AqUnitMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_IndustryId",
                table: "Wastes",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_RlessUnitMeasurementId",
                table: "Wastes",
                column: "RlessUnitMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_RmpUnitMeasurementId",
                table: "Wastes",
                column: "RmpUnitMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_RssUnitMeasurementId",
                table: "Wastes",
                column: "RssUnitMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_VmpUnitMeasurementId",
                table: "Wastes",
                column: "VmpUnitMeasurementId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastes_WasteCodingId",
                table: "Wastes",
                column: "WasteCodingId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_RecieverIndustryId",
                table: "WasteTransportation",
                column: "RecieverIndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_SenderIndustryId",
                table: "WasteTransportation",
                column: "SenderIndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_SubmissionMethodId",
                table: "WasteTransportation",
                column: "SubmissionMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_WasteTransportation_WasteId",
                table: "WasteTransportation",
                column: "WasteId");

            migrationBuilder.CreateIndex(
                name: "IX_WastewaterDisposals_IndustryId",
                table: "WastewaterDisposals",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_WastewaterParametersResults_AcceptedResourceId",
                table: "WastewaterParametersResults",
                column: "AcceptedResourceId");

            migrationBuilder.CreateIndex(
                name: "IX_WastewaterParametersResults_MeasurementUnitId",
                table: "WastewaterParametersResults",
                column: "MeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WastewaterParametersResults_ParametersSamplingResultsId",
                table: "WastewaterParametersResults",
                column: "ParametersSamplingResultsId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastewaters_DaqMeasurementUnitId",
                table: "Wastewaters",
                column: "DaqMeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastewaters_DmqMeasurementUnitId",
                table: "Wastewaters",
                column: "DmqMeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastewaters_HaqMeasurementUnitId",
                table: "Wastewaters",
                column: "HaqMeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastewaters_HmqMeasurementUnitId",
                table: "Wastewaters",
                column: "HmqMeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastewaters_IndustryId",
                table: "Wastewaters",
                column: "IndustryId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastewaters_WastewaterProductionReleaseTypeId",
                table: "Wastewaters",
                column: "WastewaterProductionReleaseTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Wastewaters_WastewaterTypeId",
                table: "Wastewaters",
                column: "WastewaterTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_WaterConsumptions_IndustryId",
                table: "WaterConsumptions",
                column: "IndustryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WwHasPurificationSystems_DrsoqMeasurementUnitId",
                table: "WwHasPurificationSystems",
                column: "DrsoqMeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WwHasPurificationSystems_MrsoqMeasurementUnitId",
                table: "WwHasPurificationSystems",
                column: "MrsoqMeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WwHasPurificationSystems_SludgeCollectionMeasurementUnitId",
                table: "WwHasPurificationSystems",
                column: "SludgeCollectionMeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WwHasPurificationSystems_SuvMeasurementUnitId",
                table: "WwHasPurificationSystems",
                column: "SuvMeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WwHasPurificationSystems_WastewaterId",
                table: "WwHasPurificationSystems",
                column: "WastewaterId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WwHasPurificationSystems_YrsoqMeasurementUnitId",
                table: "WwHasPurificationSystems",
                column: "YrsoqMeasurementUnitId");

            migrationBuilder.CreateIndex(
                name: "IX_WwUseMotherPurificationSystems_WastewaterId",
                table: "WwUseMotherPurificationSystems",
                column: "WastewaterId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AmbientAirParametersResults");

            migrationBuilder.DropTable(
                name: "ChemicalPropertiesParameters");

            migrationBuilder.DropTable(
                name: "ChimneyParametersResults");

            migrationBuilder.DropTable(
                name: "ChimneysInfo");

            migrationBuilder.DropTable(
                name: "ConsumingMaterials");

            migrationBuilder.DropTable(
                name: "DisinfectionDevicesInfos");

            migrationBuilder.DropTable(
                name: "EnergyConsumptions");

            migrationBuilder.DropTable(
                name: "HumanResources");

            migrationBuilder.DropTable(
                name: "IndustrialTownsSpecialtyDetails");

            migrationBuilder.DropTable(
                name: "Industry_License");

            migrationBuilder.DropTable(
                name: "Industry_Managers");

            migrationBuilder.DropTable(
                name: "Industry_OfficeAddresses");

            migrationBuilder.DropTable(
                name: "Industry_WorkshopAddresses");

            migrationBuilder.DropTable(
                name: "Lab_Addresses");

            migrationBuilder.DropTable(
                name: "Lab_Managers");

            migrationBuilder.DropTable(
                name: "LabConsumingMaterials");

            migrationBuilder.DropTable(
                name: "LivestockSpecialtyDetails");

            migrationBuilder.DropTable(
                name: "ManufacturedProducts");

            migrationBuilder.DropTable(
                name: "MedicalCenterSelfDeclarationInfos");

            migrationBuilder.DropTable(
                name: "MedicalCenterUnitsAdditionalInfos");

            migrationBuilder.DropTable(
                name: "MotorVehiclesParametersResults");

            migrationBuilder.DropTable(
                name: "OutletWastewaters");

            migrationBuilder.DropTable(
                name: "ParametersAndMeasurementMethods");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropTable(
                name: "SlaughterHouseSpecialtyInfos");

            migrationBuilder.DropTable(
                name: "SoundAndWavesParametersResults");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "WasteManagementUnitsDetails");

            migrationBuilder.DropTable(
                name: "WasteParameter");

            migrationBuilder.DropTable(
                name: "WasteParametersResults");

            migrationBuilder.DropTable(
                name: "WasteTransportation");

            migrationBuilder.DropTable(
                name: "WastewaterDisposals");

            migrationBuilder.DropTable(
                name: "WastewaterParametersResults");

            migrationBuilder.DropTable(
                name: "WaterConsumptions");

            migrationBuilder.DropTable(
                name: "WwHasPurificationSystems");

            migrationBuilder.DropTable(
                name: "WwUseMotherPurificationSystems");

            migrationBuilder.DropTable(
                name: "IndustrialTownsSpecialtyInfos");

            migrationBuilder.DropTable(
                name: "LivestockSpecialtyInfos");

            migrationBuilder.DropTable(
                name: "MedicalCenterUnitsInfos");

            migrationBuilder.DropTable(
                name: "MonitoringInfos");

            migrationBuilder.DropTable(
                name: "Equipments");

            migrationBuilder.DropTable(
                name: "RotterdamConventionChemicals");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "WasteManagementUnitsInfos");

            migrationBuilder.DropTable(
                name: "Wastes");

            migrationBuilder.DropTable(
                name: "ParametersSamplingResults");

            migrationBuilder.DropTable(
                name: "Wastewaters");

            migrationBuilder.DropTable(
                name: "WasteCodings");

            migrationBuilder.DropTable(
                name: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropTable(
                name: "MonitoringParameters");

            migrationBuilder.DropTable(
                name: "Personnels");

            migrationBuilder.DropTable(
                name: "MonitoringCodings");

            migrationBuilder.DropTable(
                name: "Labs");

            migrationBuilder.DropTable(
                name: "Industries");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "EnumData");
        }
    }
}
