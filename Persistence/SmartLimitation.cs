using System;
using System.Linq;
using System.Linq.Expressions;
using Core.Contracts;
using Core.Entities;
using Core.Tools;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Persistence.Context;

namespace Persistence
{
   public static class SmartLimitation
   {
      public static IQueryable<T> SmartLimit<T>(this AppDbContext context) where T : class, IAccessControl
      {
         var u = context.UserAccessInfo;
         IQueryable result = typeof(T).Name
         switch
         {
            nameof(Industry) => context.Industries.Where(Industry.GetSmartLimitations(u)),
            nameof(HuntInstruction) => context.HuntInstructions.Where(HuntInstruction.GetSmartLimitations(u)),
            nameof(WasteTransfer) => context.WasteTransfers.Where(WasteTransfer.GetSmartLimitations(u)),
            nameof(WasteExportImport) => context.WasteExportImports.Where(WasteExportImport.GetSmartLimitations(u)),
            nameof(Lab) => context.Labs.Where(Lab.GetSmartLimitations(u)),
            nameof(Hunter) => context.Hunters.Where(Hunter.GetSmartLimitations(u)),
            nameof(User) => context.Users.Where(User.GetSmartLimitations(u)),
            nameof(GreenIndustry) => context.GreenIndustries.Where(GreenIndustry.GetSmartLimitations(u)),
            nameof(MessageReceiver) => context.MessageReceivers.Where(MessageReceiver.GetSmartLimitations(u)),
            nameof(ConsumingMaterial) => context.ConsumingMaterials.HasLimitationOf(q => q.Industry),
            nameof(MedicalCenterUnitsInfo) => context.MedicalCenterUnitsInfos.HasLimitationOf(q => q.Industry),
            nameof(EnergyConsumption) => context.EnergyConsumptions.HasLimitationOf(q => q.Industry),
            nameof(GreenIndustryStrategies) => context.GreenIndustryStrategies.HasLimitationOf(q => q.GreenIndustry),
            nameof(HumanResource) => context.HumanResources.HasLimitationOf(q => q.Industry),
            nameof(IndustrialTownsSpecialtyInfo) => context.IndustrialTownsSpecialtyInfos.HasLimitationOf(q => q.Industry),
            nameof(IndustryEvaluation) => context.IndustryEvaluations.HasLimitationOf(q => q.Industry),
            nameof(IndustryEstablishmentCase) => context.IndustryEstablishmentCases.HasLimitationOf(q => q.Industry),
            nameof(IndustryEstablishmentCaseAdditionalInfo) => context.IndustryEstablishmentCaseAdditionalInfos.HasLimitationOf(q => q.Industry),
            nameof(IndustryInspection) => context.IndustryInspections.HasLimitationOf(q => q.Industry),
            nameof(IndustryOnlineMonitoring) => context.IndustryOnlineMonitorings.HasLimitationOf(q => q.Industry),
            nameof(IndustryPollution) => context.IndustryPollutions.HasLimitationOf(q => q.Industry),
            nameof(IndustryJudicialAction) => context.IndustryJudicialActions.HasLimitationOf(q => q.Industry),
            nameof(IndustryWarning) => context.IndustryWarnings.HasLimitationOf(q => q.Industry),
            nameof(LivestockSpecialtyInfo) => context.LivestockSpecialtyInfos.HasLimitationOf(q => q.Industry),
            nameof(UndergroundWaterQualityContinuousMonitoring) => context.UndergroundWaterQualityContinuousMonitorings.HasLimitationOf(q => q.Industry),
            nameof(LandfillSpecialtyInfo) => context.LandfillSpecialtyInfos.HasLimitationOf(q => q.Industry),
            nameof(MineSpecialtyInfo) => context.MineSpecialtyInfos.HasLimitationOf(q => q.Industry),
            nameof(MineSpecialtyInfoMineralMaterial) => context.MineSpecialtyInfoMineralMaterials.HasLimitationOf(q => q.MineSpecialtyInfo.Industry),
            nameof(WasteDamSpecialtyInfo) => context.WasteDamSpecialtyInfos.HasLimitationOf(q => q.Industry),
            nameof(WasteDamSpecialtyInfoProblem) => context.WasteDamSpecialtyInfoProblems.HasLimitationOf(q => q.WasteDamSpecialtyInfo.Industry),
            nameof(WasteDamSpecialtyInfoWaterQualityMonitoringStation) => context.WasteDamSpecialtyInfoWaterQualityMonitoringStations.HasLimitationOf(q => q.WasteDamSpecialtyInfo.Industry),
            nameof(IndustryEnvironmentalHealthExpertReport) => context.IndustryEnvironmentalHealthExpertReports.HasLimitationOf(q => q.Industry),
            nameof(ManufacturedProduct) => context.ManufacturedProducts.HasLimitationOf(q => q.Industry),
            nameof(MedicalCenterSelfDeclarationInfo) => context.MedicalCenterSelfDeclarationInfos.HasLimitationOf(q => q.Industry),
            nameof(IndustrialUnitsSamplingResult) => context.IndustrialUnitsSamplingResults.Where(IndustrialUnitsSamplingResult.GetSmartLimitations(u)),
            nameof(ParametersSamplingResults) => context.ParametersSamplingResults.HasLimitationOf(q => q.IndustrialUnitsSamplingResult),
            nameof(MonitoringInfo) => context.MonitoringInfos.HasLimitationOf(q => q.Industry),
            nameof(MunicipalityWasteSpecialtyInfo) => context.MunicipalityWasteSpecialtyInfos.HasLimitationOf(q => q.Industry),
            nameof(RawMaterial) => context.RawMaterials.HasLimitationOf(q => q.Industry),
            nameof(RefinerySpecialtyInfo) => context.RefinerySpecialtyInfos.HasLimitationOf(q => q.Industry),
            nameof(Repository) => context.Repositories.HasLimitationOf(q => q.Industry),
            nameof(IndustryClosure) => context.IndustryClosures.HasLimitationOf(q => q.Industry),
            nameof(SlaughterHouseSpecialtyInfo) => context.SlaughterHouseSpecialtyInfos.HasLimitationOf(q => q.Industry),
            nameof(WastesShipments) => context.WastesShipments.HasLimitationOf(q => q.WasteTransfer),
            nameof(WasteExportImportCustomCargo) => context.WasteExportImportCustomCargos.HasLimitationOf(q => q.WasteExportImport),
            nameof(Waste) => context.Wastes.HasLimitationOf(q => q.Industry),
            nameof(WasteManagementUnitsInfo) => context.WasteManagementUnitsInfos.HasLimitationOf(q => q.Industry),
            nameof(WasteManagementUnitsDetails) => context.WasteManagementUnitsDetails.HasLimitationOf(q => q.WasteManagementUnitsInfo.Industry),
            nameof(WasteTransfersAdditionalIndustries) => context.WasteTransfersAdditionalIndustries.HasLimitationOf(q => q.WasteTransfer),
            nameof(WastewaterDisposal) => context.WastewaterDisposals.HasLimitationOf(q => q.Industry),
            nameof(Wastewater) => context.Wastewaters.HasLimitationOf(q => q.Industry),
            nameof(WaterConsumption) => context.WaterConsumptions.HasLimitationOf(q => q.Industry),
            nameof(WwUseMotherPurificationSystems) => context.WwUseMotherPurificationSystems.HasLimitationOf(q => q.Wastewater.Industry),
            nameof(WwHasPurificationSystems) => context.WwHasPurificationSystems.HasLimitationOf(q => q.Wastewater.Industry),
            nameof(DisinfectionDevicesInfo) => context.DisinfectionDevicesInfos.HasLimitationOf(q => q.MedicalCenterUnitsInfo.Industry),
            nameof(IndustryOnlineMonitoringParameters) => context.IndustryOnlineMonitoringParameters.HasLimitationOf(q => q.IndustryOnlineMonitoring.Industry),
            nameof(IndustryOnlineMonitoringEquipments) => context.IndustryOnlineMonitoringEquipments.HasLimitationOf(q => q.IndustryOnlineMonitoring.Industry),
            nameof(MedicalCenterUnitsAdditionalInfo) => context.MedicalCenterUnitsAdditionalInfos.HasLimitationOf(q => q.MedicalCenterUnitsInfo.Industry),
            nameof(OutletWastewaters) => context.OutletWastewaters.HasLimitationOf(q => q.MonitoringInfo.Industry),
            nameof(ChimneysInfo) => context.ChimneysInfo.HasLimitationOf(q => q.MonitoringInfo.Industry),
            nameof(Equipment) => context.Equipments.HasLimitationOf(q => q.Lab),
            nameof(LabInspection) => context.LabInspections.HasLimitationOf(q => q.Lab),
            nameof(LabSupervision) => context.LabSupervisions.HasLimitationOf(q => q.Lab),
            nameof(Personnel) => context.Personnels.HasLimitationOf(q => q.Lab),
            nameof(ParameterAndMeasurementMethod) => context.ParametersAndMeasurementMethods.HasLimitationOf(q => q.Lab),
            nameof(LabConsumingMaterial) => context.LabConsumingMaterials.HasLimitationOf(q => q.Lab),
            nameof(AmbientAirParametersResults) => context.AmbientAirParametersResults.HasLimitationOf(q => q.ParametersSamplingResults.IndustrialUnitsSamplingResult),
            nameof(WasteParametersResults) => context.WasteParametersResults.HasLimitationOf(q => q.ParametersSamplingResults.IndustrialUnitsSamplingResult),
            nameof(ChimneyParametersResults) => context.ChimneyParametersResults.HasLimitationOf(q => q.ParametersSamplingResults.IndustrialUnitsSamplingResult),
            nameof(SoundAndWavesParametersResults) => context.SoundAndWavesParametersResults.HasLimitationOf(q => q.ParametersSamplingResults.IndustrialUnitsSamplingResult),
            nameof(WastewaterParametersResults) => context.WastewaterParametersResults.HasLimitationOf(q => q.ParametersSamplingResults.IndustrialUnitsSamplingResult),
            nameof(RiverPassingProvince) => context.RiverPassingProvinces.Where(RiverPassingProvince.GetSmartLimitations(u)),
            nameof(InformationValidation) => context.InformationValidations.Where(InformationValidation.GetSmartLimitations(u)),
            nameof(HospitalSamplingResult) => context.HospitalSamplingResults.Where(HospitalSamplingResult.GetSmartLimitations(u)),
            nameof(HospitalDisinfectionDeviceResult) => context.HospitalDisinfectionDeviceResults.HasLimitationOf(q => q.HospitalSamplingResult),
            nameof(WaterQualityMonitoringStation) => context.WaterQualityMonitoringStations.Where(WaterQualityMonitoringStation.GetSmartLimitations(u)),
            nameof(WaterQualityMonitoringStationSamplingResult) => context.WaterQualityMonitoringStationSamplingResults.HasLimitationOf(q => q.WaterQualityMonitoringStation),
            nameof(WaterQualityMonitoringStationSamplingParameter) => context.WaterQualityMonitoringStationSamplingParameters.HasLimitationOf(q => q.WaterQualityMonitoringStationSamplingResult.WaterQualityMonitoringStation),
            nameof(HunterWeaponHistory) => context.HunterWeaponHistories.HasLimitationOf(q => q.Hunter),
            nameof(FishermanToolsHistory) => context.FishermanToolsHistories.HasLimitationOf(q => q.Hunter),
            nameof(HunterViolation) => context.HunterViolations.HasLimitationOf(q => q.Hunter),
            nameof(HunterNative) => context.HunterNatives.HasLimitationOf(q => q.Hunter),
            nameof(HunterTraining) => context.HunterTrainings.HasLimitationOf(q => q.Hunter),
            nameof(HunterBooklet) => context.HunterBooklets.HasLimitationOf(q => q.Hunter),
            nameof(HuntingLicense) => context.HuntingLicenses.HasLimitationOf(q => q.Hunter),
            nameof(HuntRegionEntranceCertificate) => context.HuntRegionEntranceCertificates.HasLimitationOf(q => q.HuntingLicense.Hunter),
            nameof(Ticket) => context.Tickets.Where(Ticket.GetSmartLimitations(u)),
            nameof(TicketReplies) => context.TicketReplies.HasLimitationOf(q => q.Ticket),
            nameof(KnowledgeBase) => context.KnowledgeBases.Where(KnowledgeBase.GetSmartLimitations(u)),
            nameof(UserRelatedIndustry) => context.v_UserRelatedIndustry.Where(UserRelatedIndustry.GetSmartLimitations(u)),
            nameof(UserRelatedLab) => context.v_UserRelatedLab.Where(UserRelatedLab.GetSmartLimitations(u)),
            nameof(PersonnelExperience) => context.PersonnelExperiences.HasLimitationOf(q => q.Personnel.Lab),
            nameof(IndustryPhaseOneMonitoringMapList) => context.v_IndustryPhaseOneMonitoringMapList.Where(IndustryPhaseOneMonitoringMapList.GetSmartLimitations(u)),
            nameof(WasteSenderIndustryMapList) => context.v_WasteSenderIndustryMapList.Where(WasteSenderIndustryMapList.GetSmartLimitations(u)),
            nameof(Invoice) => context.Invoices.Where(Invoice.GetSmartLimitations(u)),
            _ =>
            throw new NotImplementedException($"SmartLimit, for `{typeof(T).Name}` class, is not implemented yet.")
         };
         return result.Cast<T>();
      }

      public static IQueryable<T> HasLimitationOf<T>(this DbSet<T> entitySet, Expression<Func<T, IAccessControl>> parent) where T : class, IAccessControl
      {
         var context = entitySet.GetDbContext();
         var u = context.UserAccessInfo;
         // parent nodes switch
         Expression<Func<T, bool>> result = parent.Body.Type.Name
         switch
         {
            nameof(Industry) => Industry.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, Industry>()),
            nameof(Lab) => Lab.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, Lab>()),
            nameof(Hunter) => Hunter.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, Hunter>()),
            nameof(GreenIndustry) => GreenIndustry.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, GreenIndustry>()),
            nameof(IndustrialUnitsSamplingResult) => IndustrialUnitsSamplingResult.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, IndustrialUnitsSamplingResult>()),
            nameof(HospitalSamplingResult) => HospitalSamplingResult.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, HospitalSamplingResult>()),
            nameof(WasteTransfer) => WasteTransfer.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, WasteTransfer>()),
            nameof(WasteExportImport) => WasteExportImport.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, WasteExportImport>()),
            nameof(InformationValidation) => InformationValidation.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, InformationValidation>()),
            nameof(WaterQualityMonitoringStation) => WaterQualityMonitoringStation.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, WaterQualityMonitoringStation>()),
            nameof(Ticket) => Ticket.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, Ticket>()),
            nameof(Invoice) => Invoice.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, Invoice>()),
            nameof(HuntInstruction) => HuntInstruction.GetSmartLimitations(u).Attach(parent.Cast<T, IAccessControl, HuntInstruction>()),
            _ =>
            throw new NotImplementedException($"HasLimitationOf, for `{typeof(T).Name}` class, is not implemented yet.")
         };
         return entitySet.Where(result);

      }
      public static AppDbContext GetDbContext<T>(this DbSet<T> dbSet) where T : class
      {
         var infrastructure = dbSet as IInfrastructure<IServiceProvider>;
         var serviceProvider = infrastructure.Instance;
         var currentDbContext = serviceProvider.GetService(typeof(ICurrentDbContext)) as ICurrentDbContext;
         return (AppDbContext)currentDbContext.Context;
      }

   }

}
