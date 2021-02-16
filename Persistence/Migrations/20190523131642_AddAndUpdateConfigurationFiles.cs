using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class AddAndUpdateConfigurationFiles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChemicalPropertiesParameters_EnumData_IngredientId",
                table: "ChemicalPropertiesParameters");

            migrationBuilder.DropForeignKey(
                name: "FK_ChimneysInfo_EnumData_ReleasePollutionSourceId",
                table: "ChimneysInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialTownsSpecialtyDetails_Industries_IndustryId",
                table: "IndustrialTownsSpecialtyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_LabManagerVerifier~",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_SamplerExpertId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_TechnicalAssistant~",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_TesterId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_LivestockSpecialtyDetails_EnumData_DomesticatedAnimalsClassi~",
                table: "LivestockSpecialtyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_LivestockSpecialtyInfos_EnumData_LivestockClassificationId",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringCodings_EnumData_MonitoringTypeId",
                table: "MonitoringCodings");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringParameters_EnumData_ParamClassificationId",
                table: "MonitoringParameters");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringParameters_EnumData_ParamId",
                table: "MonitoringParameters");

            migrationBuilder.DropForeignKey(
                name: "FK_OutletWastewaters_EnumData_AcceptedResourceId",
                table: "OutletWastewaters");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametersSamplingResults_MonitoringParameters_MonitoringPar~",
                table: "ParametersSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametersSamplingResults_EnumData_MonitoringTypeId",
                table: "ParametersSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteCodings_EnumData_HsCodeId",
                table: "WasteCodings");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteCodings_EnumData_IsicCode10Id",
                table: "WasteCodings");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteCodings_EnumData_WasteClassificationId",
                table: "WasteCodings");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteCodings_EnumData_WasteNameId",
                table: "WasteCodings");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteManagementUnitsDetails_EnumData_HcUnitMeasurementId",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteManagementUnitsDetails_EnumData_IsicCode10Id",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteManagementUnitsInfos_EnumData_WasteManagementUnitClassi~",
                table: "WasteManagementUnitsInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteParameter_EnumData_ParamClassificationId",
                table: "WasteParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteParameter_EnumData_ParamId",
                table: "WasteParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Industries_RecieverIndustryId",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Industries_SenderIndustryId",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Wastes_WasteId",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastewaters_EnumData_DaqMeasurementUnitId",
                table: "Wastewaters");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastewaters_EnumData_DmqMeasurementUnitId",
                table: "Wastewaters");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastewaters_EnumData_HaqMeasurementUnitId",
                table: "Wastewaters");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastewaters_EnumData_HmqMeasurementUnitId",
                table: "Wastewaters");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastewaters_EnumData_WastewaterProductionReleaseTypeId",
                table: "Wastewaters");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastewaters_EnumData_WastewaterTypeId",
                table: "Wastewaters");

            migrationBuilder.AddColumn<int>(
                name: "EquipmentId",
                table: "ParametersAndMeasurementMethods",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ParametersAndMeasurementMethods_EquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "EquipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChemicalPropertiesParameters_EnumData_IngredientId",
                table: "ChemicalPropertiesParameters",
                column: "IngredientId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ChimneysInfo_EnumData_ReleasePollutionSourceId",
                table: "ChimneysInfo",
                column: "ReleasePollutionSourceId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialTownsSpecialtyDetails_Industries_IndustryId",
                table: "IndustrialTownsSpecialtyDetails",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_LabManagerVerifier~",
                table: "IndustrialUnitsSamplingResults",
                column: "LabManagerVerifierId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_SamplerExpertId",
                table: "IndustrialUnitsSamplingResults",
                column: "SamplerExpertId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_TechnicalAssistant~",
                table: "IndustrialUnitsSamplingResults",
                column: "TechnicalAssistantVerifierId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_TesterId",
                table: "IndustrialUnitsSamplingResults",
                column: "TesterId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LivestockSpecialtyDetails_EnumData_DomesticatedAnimalsClassi~",
                table: "LivestockSpecialtyDetails",
                column: "DomesticatedAnimalsClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LivestockSpecialtyInfos_EnumData_LivestockClassificationId",
                table: "LivestockSpecialtyInfos",
                column: "LivestockClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitoringCodings_EnumData_MonitoringTypeId",
                table: "MonitoringCodings",
                column: "MonitoringTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitoringParameters_EnumData_ParamClassificationId",
                table: "MonitoringParameters",
                column: "ParamClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitoringParameters_EnumData_ParamId",
                table: "MonitoringParameters",
                column: "ParamId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OutletWastewaters_EnumData_AcceptedResourceId",
                table: "OutletWastewaters",
                column: "AcceptedResourceId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_EquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "EquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "UsingEquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersSamplingResults_MonitoringParameters_MonitoringPar~",
                table: "ParametersSamplingResults",
                column: "MonitoringParametersId",
                principalTable: "MonitoringParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersSamplingResults_EnumData_MonitoringTypeId",
                table: "ParametersSamplingResults",
                column: "MonitoringTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteCodings_EnumData_BaselABId",
                table: "WasteCodings",
                column: "BaselABId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteCodings_EnumData_HsCodeId",
                table: "WasteCodings",
                column: "HsCodeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteCodings_EnumData_IsicCode10Id",
                table: "WasteCodings",
                column: "IsicCode10Id",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteCodings_EnumData_WasteClassificationId",
                table: "WasteCodings",
                column: "WasteClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteCodings_EnumData_WasteNameId",
                table: "WasteCodings",
                column: "WasteNameId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteManagementUnitsDetails_EnumData_HcUnitMeasurementId",
                table: "WasteManagementUnitsDetails",
                column: "HcUnitMeasurementId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteManagementUnitsDetails_EnumData_IsicCode10Id",
                table: "WasteManagementUnitsDetails",
                column: "IsicCode10Id",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteManagementUnitsInfos_EnumData_WasteManagementUnitClassi~",
                table: "WasteManagementUnitsInfos",
                column: "WasteManagementUnitClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteParameter_EnumData_ParamClassificationId",
                table: "WasteParameter",
                column: "ParamClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteParameter_EnumData_ParamId",
                table: "WasteParameter",
                column: "ParamId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Industries_RecieverIndustryId",
                table: "WasteTransportation",
                column: "RecieverIndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Industries_SenderIndustryId",
                table: "WasteTransportation",
                column: "SenderIndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Wastes_WasteId",
                table: "WasteTransportation",
                column: "WasteId",
                principalTable: "Wastes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastewaters_EnumData_DaqMeasurementUnitId",
                table: "Wastewaters",
                column: "DaqMeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastewaters_EnumData_DmqMeasurementUnitId",
                table: "Wastewaters",
                column: "DmqMeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastewaters_EnumData_HaqMeasurementUnitId",
                table: "Wastewaters",
                column: "HaqMeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastewaters_EnumData_HmqMeasurementUnitId",
                table: "Wastewaters",
                column: "HmqMeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastewaters_EnumData_WastewaterProductionReleaseTypeId",
                table: "Wastewaters",
                column: "WastewaterProductionReleaseTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastewaters_EnumData_WastewaterTypeId",
                table: "Wastewaters",
                column: "WastewaterTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChemicalPropertiesParameters_EnumData_IngredientId",
                table: "ChemicalPropertiesParameters");

            migrationBuilder.DropForeignKey(
                name: "FK_ChimneysInfo_EnumData_ReleasePollutionSourceId",
                table: "ChimneysInfo");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialTownsSpecialtyDetails_Industries_IndustryId",
                table: "IndustrialTownsSpecialtyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_LabManagerVerifier~",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_SamplerExpertId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_TechnicalAssistant~",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_TesterId",
                table: "IndustrialUnitsSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_LivestockSpecialtyDetails_EnumData_DomesticatedAnimalsClassi~",
                table: "LivestockSpecialtyDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_LivestockSpecialtyInfos_EnumData_LivestockClassificationId",
                table: "LivestockSpecialtyInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringCodings_EnumData_MonitoringTypeId",
                table: "MonitoringCodings");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringParameters_EnumData_ParamClassificationId",
                table: "MonitoringParameters");

            migrationBuilder.DropForeignKey(
                name: "FK_MonitoringParameters_EnumData_ParamId",
                table: "MonitoringParameters");

            migrationBuilder.DropForeignKey(
                name: "FK_OutletWastewaters_EnumData_AcceptedResourceId",
                table: "OutletWastewaters");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_EquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametersSamplingResults_MonitoringParameters_MonitoringPar~",
                table: "ParametersSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_ParametersSamplingResults_EnumData_MonitoringTypeId",
                table: "ParametersSamplingResults");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteCodings_EnumData_BaselABId",
                table: "WasteCodings");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteCodings_EnumData_HsCodeId",
                table: "WasteCodings");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteCodings_EnumData_IsicCode10Id",
                table: "WasteCodings");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteCodings_EnumData_WasteClassificationId",
                table: "WasteCodings");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteCodings_EnumData_WasteNameId",
                table: "WasteCodings");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteManagementUnitsDetails_EnumData_HcUnitMeasurementId",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteManagementUnitsDetails_EnumData_IsicCode10Id",
                table: "WasteManagementUnitsDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteManagementUnitsInfos_EnumData_WasteManagementUnitClassi~",
                table: "WasteManagementUnitsInfos");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteParameter_EnumData_ParamClassificationId",
                table: "WasteParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteParameter_EnumData_ParamId",
                table: "WasteParameter");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Industries_RecieverIndustryId",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Industries_SenderIndustryId",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_WasteTransportation_Wastes_WasteId",
                table: "WasteTransportation");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastewaters_EnumData_DaqMeasurementUnitId",
                table: "Wastewaters");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastewaters_EnumData_DmqMeasurementUnitId",
                table: "Wastewaters");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastewaters_EnumData_HaqMeasurementUnitId",
                table: "Wastewaters");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastewaters_EnumData_HmqMeasurementUnitId",
                table: "Wastewaters");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastewaters_EnumData_WastewaterProductionReleaseTypeId",
                table: "Wastewaters");

            migrationBuilder.DropForeignKey(
                name: "FK_Wastewaters_EnumData_WastewaterTypeId",
                table: "Wastewaters");

            migrationBuilder.DropIndex(
                name: "IX_ParametersAndMeasurementMethods_EquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.DropColumn(
                name: "EquipmentId",
                table: "ParametersAndMeasurementMethods");

            migrationBuilder.AddForeignKey(
                name: "FK_ChemicalPropertiesParameters_EnumData_IngredientId",
                table: "ChemicalPropertiesParameters",
                column: "IngredientId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChimneysInfo_EnumData_ReleasePollutionSourceId",
                table: "ChimneysInfo",
                column: "ReleasePollutionSourceId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialTownsSpecialtyDetails_Industries_IndustryId",
                table: "IndustrialTownsSpecialtyDetails",
                column: "IndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_LabManagerVerifier~",
                table: "IndustrialUnitsSamplingResults",
                column: "LabManagerVerifierId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_SamplerExpertId",
                table: "IndustrialUnitsSamplingResults",
                column: "SamplerExpertId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_TechnicalAssistant~",
                table: "IndustrialUnitsSamplingResults",
                column: "TechnicalAssistantVerifierId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_IndustrialUnitsSamplingResults_Personnels_TesterId",
                table: "IndustrialUnitsSamplingResults",
                column: "TesterId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LivestockSpecialtyDetails_EnumData_DomesticatedAnimalsClassi~",
                table: "LivestockSpecialtyDetails",
                column: "DomesticatedAnimalsClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LivestockSpecialtyInfos_EnumData_LivestockClassificationId",
                table: "LivestockSpecialtyInfos",
                column: "LivestockClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitoringCodings_EnumData_MonitoringTypeId",
                table: "MonitoringCodings",
                column: "MonitoringTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitoringParameters_EnumData_ParamClassificationId",
                table: "MonitoringParameters",
                column: "ParamClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonitoringParameters_EnumData_ParamId",
                table: "MonitoringParameters",
                column: "ParamId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OutletWastewaters_EnumData_AcceptedResourceId",
                table: "OutletWastewaters",
                column: "AcceptedResourceId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersAndMeasurementMethods_Equipments_UsingEquipmentId",
                table: "ParametersAndMeasurementMethods",
                column: "UsingEquipmentId",
                principalTable: "Equipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersSamplingResults_MonitoringParameters_MonitoringPar~",
                table: "ParametersSamplingResults",
                column: "MonitoringParametersId",
                principalTable: "MonitoringParameters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ParametersSamplingResults_EnumData_MonitoringTypeId",
                table: "ParametersSamplingResults",
                column: "MonitoringTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteCodings_EnumData_BaselABId",
                table: "WasteCodings",
                column: "BaselABId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteCodings_EnumData_HsCodeId",
                table: "WasteCodings",
                column: "HsCodeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteCodings_EnumData_IsicCode10Id",
                table: "WasteCodings",
                column: "IsicCode10Id",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteCodings_EnumData_WasteClassificationId",
                table: "WasteCodings",
                column: "WasteClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteCodings_EnumData_WasteNameId",
                table: "WasteCodings",
                column: "WasteNameId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteManagementUnitsDetails_EnumData_HcUnitMeasurementId",
                table: "WasteManagementUnitsDetails",
                column: "HcUnitMeasurementId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteManagementUnitsDetails_EnumData_IsicCode10Id",
                table: "WasteManagementUnitsDetails",
                column: "IsicCode10Id",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteManagementUnitsInfos_EnumData_WasteManagementUnitClassi~",
                table: "WasteManagementUnitsInfos",
                column: "WasteManagementUnitClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteParameter_EnumData_ParamClassificationId",
                table: "WasteParameter",
                column: "ParamClassificationId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteParameter_EnumData_ParamId",
                table: "WasteParameter",
                column: "ParamId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Industries_RecieverIndustryId",
                table: "WasteTransportation",
                column: "RecieverIndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Industries_SenderIndustryId",
                table: "WasteTransportation",
                column: "SenderIndustryId",
                principalTable: "Industries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WasteTransportation_Wastes_WasteId",
                table: "WasteTransportation",
                column: "WasteId",
                principalTable: "Wastes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastewaters_EnumData_DaqMeasurementUnitId",
                table: "Wastewaters",
                column: "DaqMeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastewaters_EnumData_DmqMeasurementUnitId",
                table: "Wastewaters",
                column: "DmqMeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastewaters_EnumData_HaqMeasurementUnitId",
                table: "Wastewaters",
                column: "HaqMeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastewaters_EnumData_HmqMeasurementUnitId",
                table: "Wastewaters",
                column: "HmqMeasurementUnitId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastewaters_EnumData_WastewaterProductionReleaseTypeId",
                table: "Wastewaters",
                column: "WastewaterProductionReleaseTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wastewaters_EnumData_WastewaterTypeId",
                table: "Wastewaters",
                column: "WastewaterTypeId",
                principalTable: "EnumData",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
