using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Core.Contracts;
using Core.Entities;
using Core.Entities.AuditableEntity;
using Core.Tools.GuardToolkit;
using Core.Tools.PersianToolkit;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Persistence.Context
{
   public class AppDbContext : DbContext
   {
      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
      {
         this.ChangeTracker.LazyLoadingEnabled = false;
      }
      public IUserAccessInfoService UserAccessInfo => this.GetService<IUserAccessInfoService>();

      #region TableMappings
      public virtual DbSet<EnumData> EnumData { get; set; }
      public virtual DbSet<Industry> Industries { get; set; }
      public virtual DbSet<Waste> Wastes { get; set; }
      public virtual DbSet<WasteCoding> WasteCodings { get; set; }
      public virtual DbSet<User> Users { set; get; }
      public virtual DbSet<Role> Roles { set; get; }
      public virtual DbSet<UserRole> UserRoles { get; set; }
      public virtual DbSet<GreenIndustryRelation> GreenIndustryRelations { get; set; }
      public virtual DbSet<UserToken> UserTokens { get; set; }
      public virtual DbSet<WasteManagementUnitsInfo> WasteManagementUnitsInfos { get; set; }
      public virtual DbSet<WasteManagementUnitsDetails> WasteManagementUnitsDetails { get; set; }
      public virtual DbSet<Lab> Labs { get; set; }
      public virtual DbSet<LabMonitoringTypeStartedDate> LabMonitoringTypeStartedDates { get; set; }
      public virtual DbSet<Personnel> Personnels { get; set; }
      public virtual DbSet<PersonnelExperience> PersonnelExperiences { get; set; }
      public virtual DbSet<Equipment> Equipments { get; set; }
      public virtual DbSet<ParameterAndMeasurementMethod> ParametersAndMeasurementMethods { get; set; }
      public virtual DbSet<ConventionChemical> ConventionChemicals { get; set; }
      public virtual DbSet<ConventionChemicalHsCodeMixture> ConventionChemicalHsCodeMixtures { get; set; }
      public virtual DbSet<ManufacturedProduct> ManufacturedProducts { get; set; }
      public virtual DbSet<HumanResource> HumanResources { get; set; }
      public virtual DbSet<WaterConsumption> WaterConsumptions { get; set; }
      public virtual DbSet<EnergyConsumption> EnergyConsumptions { get; set; }
      public virtual DbSet<RawMaterial> RawMaterials { get; set; }
      public virtual DbSet<ConsumingMaterial> ConsumingMaterials { get; set; }
      public virtual DbSet<Wastewater> Wastewaters { get; set; }
      public virtual DbSet<WwHasPurificationSystems> WwHasPurificationSystems { get; set; }
      public virtual DbSet<WwUseMotherPurificationSystems> WwUseMotherPurificationSystems { get; set; }
      public virtual DbSet<WastewaterDisposal> WastewaterDisposals { get; set; }
      public virtual DbSet<MonitoringCoding> MonitoringCodings { get; set; }
      public virtual DbSet<MonitoringInfo> MonitoringInfos { get; set; }
      public virtual DbSet<IndustrialUnitsSamplingResult> IndustrialUnitsSamplingResults { get; set; }
      public virtual DbSet<ExperimentParametersClassification> ExperimentParametersClassifications { get; set; }
      public virtual DbSet<ParametersSamplingResults> ParametersSamplingResults { get; set; }
      public virtual DbSet<AmbientAirParametersResults> AmbientAirParametersResults { get; set; }
      public virtual DbSet<ChimneyParametersResults> ChimneyParametersResults { get; set; }
      public virtual DbSet<WastewaterParametersResults> WastewaterParametersResults { get; set; }
      public virtual DbSet<WasteParametersResults> WasteParametersResults { get; set; }
      public virtual DbSet<SoundAndWavesParametersResults> SoundAndWavesParametersResults { get; set; }
      public virtual DbSet<ChimneysInfo> ChimneysInfo { get; set; }
      public virtual DbSet<OutletWastewaters> OutletWastewaters { get; set; }
      public virtual DbSet<LabConsumingMaterial> LabConsumingMaterials { get; set; }
      public virtual DbSet<SlaughterHouseSpecialtyInfo> SlaughterHouseSpecialtyInfos { get; set; }
      public virtual DbSet<MedicalCenterSelfDeclarationInfo> MedicalCenterSelfDeclarationInfos { get; set; }
      public virtual DbSet<MedicalCenterUnitsInfo> MedicalCenterUnitsInfos { get; set; }
      public virtual DbSet<DisinfectionDevicesInfo> DisinfectionDevicesInfos { get; set; }
      public virtual DbSet<MedicalCenterUnitsAdditionalInfo> MedicalCenterUnitsAdditionalInfos { get; set; }
      public virtual DbSet<IndustrialTownsSpecialtyInfo> IndustrialTownsSpecialtyInfos { get; set; }
      public virtual DbSet<IndustrialTownsSpecialtyDetails> IndustrialTownsSpecialtyDetails { get; set; }
      public virtual DbSet<LivestockSpecialtyInfo> LivestockSpecialtyInfos { get; set; }
      public virtual DbSet<LivestockSpecialtyDetails> LivestockSpecialtyDetails { get; set; }
      public virtual DbSet<LivestockSpecialtyAdditionalInformation> LivestockSpecialtyAdditionalInformations { get; set; }
      public virtual DbSet<LivestockSpecialtyWasteInformation> LivestockSpecialtyWasteInformations { get; set; }
      public virtual DbSet<MonitoringParameters> MonitoringParameters { get; set; }
      public virtual DbSet<ChemicalPropertiesParameters> ChemicalPropertiesParameters { get; set; }
      public virtual DbSet<WasteParameter> WasteParameter { get; set; }
      public virtual DbSet<NeedMonitoringTypes> NeedMonitoringTypes { get; set; }
      public virtual DbSet<Message> Messages { get; set; }
      public virtual DbSet<Group> Groups { get; set; }
      public virtual DbSet<UserGroup> UserGroups { get; set; }
      public virtual DbSet<UserClaim> UserClaims { get; set; }
      public virtual DbSet<RoleClaim> RoleClaims { get; set; }
      public virtual DbSet<Repository> Repositories { get; set; }
      public virtual DbSet<IndustryClosure> IndustryClosures { get; set; }
      public virtual DbSet<NormalWasteInformation> NormalWasteInformations { get; set; }
      public virtual DbSet<WasteTransfer> WasteTransfers { get; set; }
      public virtual DbSet<WastesShipments> WastesShipments { get; set; }
      public virtual DbSet<WasteTransfersDescriptions> WasteTransfersDescriptions { get; set; }
      public virtual DbSet<WasteTransfersAdditionalIndustries> WasteTransfersAdditionalIndustries { get; set; }
      public virtual DbSet<WasteTransfersRelatedProvinces> WasteTransfersRelatedProvinces { get; set; }
      public virtual DbSet<MunicipalityWasteSpecialtyInfo> MunicipalityWasteSpecialtyInfos { get; set; }
      public virtual DbSet<MunicipalityWasteSpecialtyAdditionalInfos> MunicipalityWasteSpecialtyAdditionalInfos { get; set; }
      public virtual DbSet<AirQualityMonitoringStation> AirQualityMonitoringStations { get; set; }
      public virtual DbSet<AirQualityStationParametersAnalyzer> AirQualityStationParametersAnalyzers { get; set; }
      public virtual DbSet<AirQualityStationMeteorologicalSystem> AirQualityStationMeteorologicalSystems { get; set; }
      public virtual DbSet<AirQualityStationSparePart> AirQualityStationSpareParts { get; set; }
      public virtual DbSet<AirQualityStationConsumable> AirQualityStationConsumables { get; set; }
      public virtual DbSet<TemplateManager> TemplateManagers { get; set; }
      public virtual DbSet<WaterOnlineQualityMonitoringStation> WaterOnlineQualityMonitoringStations { get; set; }
      public virtual DbSet<WaterOnlineQualityMonitoringStationParametersAnalyzer> WaterOnlineQualityMonitoringStationParametersAnalyzers { get; set; }
      public virtual DbSet<WaterOnlineQualityMonitoringStationSparePart> WaterOnlineQualityMonitoringStationSpareParts { get; set; }
      public virtual DbSet<WaterOnlineQualityMonitoringStationConsumable> WaterOnlineQualityMonitoringStationConsumables { get; set; }
      public virtual DbSet<IndustrialTownsSpecialtyAssignedIndustries> IndustrialTownsSpecialtyAssignedIndustries { get; set; }
      public virtual DbSet<RefinerySpecialtyInfo> RefinerySpecialtyInfos { get; set; }
      public virtual DbSet<RefinerySendingGasType> RefinerySendingGasTypes { get; set; }
      public virtual DbSet<IndustryInspection> IndustryInspections { get; set; }
      public virtual DbSet<IndustryInspectors> IndustryInspectors { get; set; }
      public virtual DbSet<IndustryInspectingPlaces> IndustryInspectingPlaces { get; set; }
      public virtual DbSet<IndustryInspectingMonitoringTypes> IndustryInspectingMonitoringTypes { get; set; }
      public virtual DbSet<IndustryPollution> IndustryPollutions { get; set; }
      public virtual DbSet<IndustryPollutionReasons> IndustryPollutionReasons { get; set; }
      public virtual DbSet<IndustryPollutionTypes> IndustryPollutionTypes { get; set; }
      public virtual DbSet<IndustryPollutionCommitteeMember> IndustryPollutionCommitteeMembers { get; set; }
      public virtual DbSet<IndustryWarning> IndustryWarnings { get; set; }
      public virtual DbSet<IndustryWarningDescription> IndustryWarningDescriptions { get; set; }
      public virtual DbSet<IndustryWarningReasons> IndustryWarningReasons { get; set; }
      public virtual DbSet<IndustryEvaluation> IndustryEvaluations { get; set; }
      public virtual DbSet<IndustryEvaluationGreenSpaceSpeciesVegetations> IndustryEvaluationGreenSpaceSpeciesVegetations { get; set; }
      public virtual DbSet<IndustryEvaluationEnvironmentalManagementCertificates> IndustryEvaluationEnvironmentalManagementCertificates { get; set; }
      public virtual DbSet<IndustryEvaluationUnitSaleInformations> IndustryEvaluationUnitSaleInformations { get; set; }
      public virtual DbSet<IndustryEvaluationSelectedAsGreenIndustryInformations> IndustryEvaluationSelectedAsGreenIndustryInformations { get; set; }
      public virtual DbSet<IndustryOnlineMonitoring> IndustryOnlineMonitorings { get; set; }
      public virtual DbSet<IndustryOnlineMonitoringParameters> IndustryOnlineMonitoringParameters { get; set; }
      public virtual DbSet<IndustryOnlineMonitoringEquipments> IndustryOnlineMonitoringEquipments { get; set; }
      public virtual DbSet<GreenIndustry> GreenIndustries { get; set; }
      public virtual DbSet<GreenIndustryStrategies> GreenIndustryStrategies { get; set; }
      public virtual DbSet<GreenIndustryDescriptions> GreenIndustryDescriptions { get; set; }
      public virtual DbSet<River> Rivers { get; set; }
      public virtual DbSet<RiverPassingProvince> RiverPassingProvinces { get; set; }
      public virtual DbSet<RiverUsageTypes> RiverUsageTypes { get; set; }
      public virtual DbSet<RiverSecondaryBasin> RiverSecondaryBasins { get; set; }
      public virtual DbSet<OnlineMonitoringChimneyInfosParameters> OnlineMonitoringChimneyInfosParameters { get; set; }
      public virtual DbSet<OnlineMonitoringOutletWastewatersParameters> OnlineMonitoringOutletWastewatersParameters { get; set; }
      public virtual DbSet<RiverProvinceRange> RiverProvinceRanges { get; set; }
      public virtual DbSet<RiverPassingCity> RiverPassingCities { get; set; }
      public virtual DbSet<RiverUsageTypesInProvince> RiverUsageTypesInProvinces { get; set; }
      public virtual DbSet<Upload> Uploads { get; set; }
      public virtual DbSet<HydrometryStation> HydrometryStations { get; set; }
      public virtual DbSet<HydrometryStationClosedYear> HydrometryStationClosedYears { get; set; }
      public virtual DbSet<HydrometryStationMonitoring> HydrometryStationMonitorings { get; set; }
      public virtual DbSet<WaterQualityMonitoringStation> WaterQualityMonitoringStations { get; set; }
      public virtual DbSet<WaterQualityMonitoringStationClosedYear> WaterQualityMonitoringStationClosedYears { get; set; }
      public virtual DbSet<WaterQualityMonitoringStationMonitoring> WaterQualityMonitoringStationMonitorings { get; set; }
      public virtual DbSet<WaterQualityMonitoringStationFacility> WaterQualityMonitoringStationFacilities { get; set; }
      public virtual DbSet<WaterQualityMonitoringStationRiverUsage> WaterQualityMonitoringStationRiverUsages { get; set; }
      public virtual DbSet<InformationValidation> InformationValidations { get; set; }
      public virtual DbSet<MessageReceiver> MessageReceivers { get; set; }
      public virtual DbSet<HuntInstruction> HuntInstructions { get; set; }
      public virtual DbSet<HuntInstructionProvinceRegionsLimitation> HuntInstructionProvinceRegionsLimitations { get; set; }
      public virtual DbSet<HuntInstructionWeekLimitation> HuntInstructionWeekLimitations { get; set; }
      public virtual DbSet<HuntInstructionDescription> HuntInstructionDescriptions { get; set; }
      public virtual DbSet<Hunter> Hunters { get; set; }
      public virtual DbSet<HunterWeaponHistory> HunterWeaponHistories { get; set; }
      public virtual DbSet<FishermanToolsHistory> FishermanToolsHistories { get; set; }
      public virtual DbSet<HunterViolation> HunterViolations { get; set; }
      public virtual DbSet<HunterViolationType> HunterViolationTypes { get; set; }
      public virtual DbSet<HunterViolatedSpecie> HunterViolatedSpecies { get; set; }
      public virtual DbSet<HunterSeizedDevice> HunterSeizedDevices { get; set; }
      public virtual DbSet<HunterViolationPartner> HunterViolationPartners { get; set; }
      public virtual DbSet<Signature> Signatures { get; set; }
      public virtual DbSet<HospitalSamplingResult> HospitalSamplingResults { get; set; }
      public virtual DbSet<HospitalTesterPersonnel> HospitalTesterPersonnels { get; set; }
      public virtual DbSet<HospitalDisinfectionDeviceResult> HospitalDisinfectionDeviceResults { get; set; }
      public virtual DbSet<HospitalUsingFacility> HospitalUsingFacilities { get; set; }
      public virtual DbSet<HospitalGuidanceMonitoringCondition> HospitalGuidanceMonitoringConditions { get; set; }
      public virtual DbSet<IndustryEnvironmentalHealthExpertReport> IndustryEnvironmentalHealthExpertReports { get; set; }
      public virtual DbSet<IndustryUsingOtherIndustryDisinfectionDevice> IndustryUsingOtherIndustryDisinfectionDevices { get; set; }
      public virtual DbSet<Ticket> Tickets { get; set; }
      public virtual DbSet<TicketReplies> TicketReplies { get; set; }
      public virtual DbSet<TicketUser> TicketUsers { get; set; }
      public virtual DbSet<ServiceAssessmentQuestionnaire> ServiceAssessmentQuestionnaires { get; set; }
      public virtual DbSet<Assistance> Assistances { get; set; }
      public virtual DbSet<WaterQualityMonitoringStationSamplingResult> WaterQualityMonitoringStationSamplingResults { get; set; }
      public virtual DbSet<WaterQualityMonitoringStationSamplingExpert> WaterQualityMonitoringStationSamplingExperts { get; set; }
      public virtual DbSet<WaterQualityMonitoringStationSamplingParameter> WaterQualityMonitoringStationSamplingParameters { get; set; }
      public virtual DbSet<WasteExportImport> WasteExportImports { get; set; }
      public virtual DbSet<WasteExportImportRepresentative> WasteExportImportRepresentatives { get; set; }
      public virtual DbSet<WasteExportImportProforma> WasteExportImportProformas { get; set; }
      public virtual DbSet<WasteExportImportPassingProvince> WasteExportImportPassingProvinces { get; set; }
      public virtual DbSet<WasteExportImportDescription> WasteExportImportDescriptions { get; set; }
      public virtual DbSet<WasteExportImportCustomCargo> WasteExportImportCustomCargos { get; set; }
      public virtual DbSet<MineSpecialtyInfo> MineSpecialtyInfos { get; set; }
      public virtual DbSet<MineSpecialtyInfoMineralMaterial> MineSpecialtyInfoMineralMaterials { get; set; }
      public virtual DbSet<WasteDamSpecialtyInfo> WasteDamSpecialtyInfos { get; set; }
      public virtual DbSet<WasteDamSpecialtyInfoProblem> WasteDamSpecialtyInfoProblems { get; set; }
      public virtual DbSet<WasteDamSpecialtyInfoWaterQualityMonitoringStation> WasteDamSpecialtyInfoWaterQualityMonitoringStations { get; set; }
      public virtual DbSet<LandfillSpecialtyInfo> LandfillSpecialtyInfos { get; set; }
      public virtual DbSet<LandfillSpecialtyInfoWasteAcceptingIndustries> LandfillSpecialtyInfoWasteAcceptingIndustries { get; set; }
      public virtual DbSet<LandfillSpecialtyInfoBurialInformation> LandfillSpecialtyInfoBurialInformations { get; set; }
      public virtual DbSet<LandfillSpecialtyInfoTemporaryHoldingInformation> LandfillSpecialtyInfoTemporaryHoldingInformations { get; set; }
      public virtual DbSet<UndergroundWaterQualityContinuousMonitoring> UndergroundWaterQualityContinuousMonitorings { get; set; }
      public virtual DbSet<LabRankingCoding> LabRankingCodings { get; set; }
      public virtual DbSet<LabRankingCodingExpertPersonnel> LabRankingCodingExpertPersonnels { get; set; }
      public virtual DbSet<LabRankingCodingParameter> LabRankingCodingParameters { get; set; }
      public virtual DbSet<KnowledgeBase> KnowledgeBases { get; set; }
      public virtual DbSet<MajorPriorityRatio> MajorPriorityRatios { get; set; }
      public virtual DbSet<UserTwoStepAuthentication> UserTwoStepAuthentications { get; set; }
      public virtual DbSet<IndustryEstablishmentRequest> IndustryEstablishmentRequests { get; set; }
      public virtual DbSet<IndustryEstablishmentRequestProtest> IndustryEstablishmentRequestProtests { get; set; }
      public virtual DbSet<IndustryEstablishment> IndustryEstablishments { get; set; }
      public virtual DbSet<IndustryEstablishmentDescription> IndustryEstablishmentDescriptions { get; set; }
      public virtual DbSet<IndustryEstablishmentDocumentFile> IndustryEstablishmentDocumentFiles { get; set; }
      public virtual DbSet<IndustryEstablishmentInquiryFile> IndustryEstablishmentInquiryFiles { get; set; }
      public virtual DbSet<IndustryEstablishmentInspectionDate> IndustryEstablishmentInspectionDates { get; set; }
      public virtual DbSet<IndustryEstablishmentInspectionVisitor> IndustryEstablishmentInspectionVisitors { get; set; }
      public virtual DbSet<IndustryEstablishmentInspectionCoordinate> IndustryEstablishmentInspectionCoordinates { get; set; }
      public virtual DbSet<IndustryEstablishmentCase> IndustryEstablishmentCases { get; set; }
      public virtual DbSet<WasteMaterialMode> WasteMaterialModes { get; set; }
      public virtual DbSet<WasteKeepingMethod> WasteKeepingMethods { get; set; }
      public virtual DbSet<WasteCollectMethod> WasteCollectMethods { get; set; }
      public virtual DbSet<IndustryEstablishmentCaseAdditionalInfo> IndustryEstablishmentCaseAdditionalInfos { get; set; }
      public virtual DbSet<IndustryEstablishmentCaseAdditionalInfoDistance> IndustryEstablishmentCaseAdditionalInfoDistances { get; set; }
      public virtual DbSet<HerbalMuseum> HerbalMuseums { get; set; }
      public virtual DbSet<AnimalMuseum> AnimalMuseums { get; set; }
      public virtual DbSet<GeneticsMuseum> GeneticsMuseums { get; set; }
      public virtual DbSet<AncientMuseum> AncientMuseums { get; set; }
      public virtual DbSet<MineralStoneMuseum> MineralStoneMuseums { get; set; }
      public virtual DbSet<LabInspection> LabInspections { get; set; }
      public virtual DbSet<LabSupervision> LabSupervisions { get; set; }
      public virtual DbSet<LabSupervisionSupervisingExpert> LabSupervisionSupervisingExperts { get; set; }
      public virtual DbSet<Researcher> Researchers { get; set; }
      public virtual DbSet<ResearcherForeignLanguage> ResearcherForeignLanguages { get; set; }
      public virtual DbSet<ResearcherEducation> ResearcherEducations { get; set; }
      public virtual DbSet<ResearcherSkill> ResearcherSkills { get; set; }
      public virtual DbSet<ResearcherDeputiesCooperationHistory> ResearcherDeputiesCooperationHistories { get; set; }
      public virtual DbSet<ResearcherConferencePaper> ResearcherConferencePapers { get; set; }
      public virtual DbSet<ResearcherCompilationBook> ResearcherCompilationBooks { get; set; }
      public virtual DbSet<ResearcherAward> ResearcherAwards { get; set; }
      public virtual DbSet<ResearcherCourseWorkshop> ResearcherCourseWorkshops { get; set; }
      public virtual DbSet<ResearcherCommunityMembership> ResearcherCommunityMemberships { get; set; }
      public virtual DbSet<ResearcherIsiArticle> ResearcherIsiArticles { get; set; }
      public virtual DbSet<ResearcherJournalMagazine> ResearcherJournalMagazines { get; set; }
      public virtual DbSet<IndustryJudicialAction> IndustryJudicialActions { get; set; }
      public virtual DbSet<IndustryJudicialActionContractor> IndustryJudicialActionContractors { get; set; }
      public virtual DbSet<Aquifer> Aquifers { get; set; }
      public virtual DbSet<AquiferProvince> AquiferProvinces { get; set; }
      public virtual DbSet<Plain> Plains { get; set; }
      public virtual DbSet<Altitude> Altitudes { get; set; }
      public virtual DbSet<Aqueduct> Aqueducts { get; set; }
      public virtual DbSet<AqueductWell> AqueductWells { get; set; }
      public virtual DbSet<AqueductWaterUsage> AqueductWaterUsages { get; set; }
      public virtual DbSet<Pit> Pits { get; set; }
      public virtual DbSet<PitWaterUsage> PitWaterUsages { get; set; }
      public virtual DbSet<Fountain> Fountains { get; set; }
      public virtual DbSet<FountainWaterUsage> FountainWaterUsages { get; set; }
      public virtual DbSet<ProductClassification> ProductClassifications { get; set; }
      public virtual DbSet<BirdsSite> BirdsSites { get; set; }
      public virtual DbSet<MammalsSite> MammalsSites { get; set; }
      public virtual DbSet<MammalsCensus> MammalsCensuses { get; set; }
      public virtual DbSet<MammalsCensusPerson> MammalsCensusPersons { get; set; }
      public virtual DbSet<MammalsCensusSpecie> MammalsCensusSpecies { get; set; }
      public virtual DbSet<BirdsCensus> BirdsCensuses { get; set; }
      public virtual DbSet<BirdsCensusPerson> BirdsCensusPersons { get; set; }
      public virtual DbSet<BirdsCensusSpecie> BirdsCensusSpecies { get; set; }
      public virtual DbSet<IndustryMonitoringReference> IndustryMonitoringReferences { get; set; }
      public virtual DbSet<IndustryMonitoringReferred> IndustryMonitoringReferreds { get; set; }
      public virtual DbSet<ChangeLog> ChangeLogs { get; set; }
      public virtual DbSet<IndustryEstablishmentTariffCoding> IndustryEstablishmentTariffCodings { get; set; }
      public virtual DbSet<Invoice> Invoices { get; set; }
      public virtual DbSet<OrderItem> OrderItems { get; set; }
      public virtual DbSet<Service> Services { get; set; }
      public virtual DbSet<IndustryEstablishmentFinancialRelation> IndustryEstablishmentFinancialRelations { get; set; }
      public virtual DbSet<IndustryEstablishmentFinancialRelationServices> IndustryEstablishmentFinancialRelationServices { get; set; }
      public virtual DbSet<AccountNumber> AccountNumbers { get; set; }
      public virtual DbSet<HunterNative> HunterNatives { get; set; }
      public virtual DbSet<HunterNativeDescription> HunterNativeDescriptions { get; set; }
      public virtual DbSet<HuntRegion> HuntRegions { get; set; }
      public virtual DbSet<HunterBooklet> HunterBooklets { get; set; }
      public virtual DbSet<HunterBookletDescription> HunterBookletDescriptions { get; set; }
      public virtual DbSet<HuntingLicense> HuntingLicenses { get; set; }
      public virtual DbSet<HuntingLicenseDescription> HuntingLicenseDescriptions { get; set; }
      public virtual DbSet<HunterTraining> HunterTrainings { get; set; }
      public virtual DbSet<HuntRegionEntranceCertificate> HuntRegionEntranceCertificates { get; set; }
      public virtual DbSet<HuntRegionEntranceCertificateOfferingDate> HuntRegionEntranceCertificateOfferingDates { get; set; }
      public virtual DbSet<HuntRegionEntranceCertificateDescription> HuntRegionEntranceCertificateDescriptions { get; set; }

      #endregion

      #region View Queries
      public virtual DbSet<IndustryManagementDashboard> v_IndustryManagementDashboard { get; set; }
      public virtual DbSet<UserManagementDashboard> v_UserManagementDashboard { get; set; }
      public virtual DbSet<BigIndustryManagementDashboard> v_BigIndustryManagementDashboard { get; set; }
      public virtual DbSet<IndustryMonitoringDashboard> v_IndustryMonitoringDashboard { get; set; }
      public virtual DbSet<MonitoringTypesFinishedSamplingsStatsDashboard> v_MonitoringTypesFinishedSamplingsStatsDashboard { get; set; }
      public virtual DbSet<MonitoringPollutionDashboard> v_MonitoringPollutionDashboard { get; set; }
      public virtual DbSet<ParameterRedundancyByProvinceDashboard> v_ParameterRedundancyByProvinceDashboard { get; set; }
      public virtual DbSet<MonitoringByProvinceDashboard> v_MonitoringByProvinceDashboard { get; set; }
      public virtual DbSet<FinishedMonitoringTypesMapList> v_FinishedMonitoringTypesMapList { get; set; }
      public virtual DbSet<MonitoringRequiredIndustryMapList> v_MonitoringRequiredIndustryMapList { get; set; }
      public virtual DbSet<MonitoringPollutionMapList> v_MonitoringPollutionMapList { get; set; }
      public virtual DbSet<ParamRedundancyByEstablishmentGroupingClassificationDashboard> v_ParamRedundancyByEstablishmentGroupingClassificationDashboard { get; set; }
      public virtual DbSet<IndustryNeedMonitoringDashboard> v_IndustryNeedMonitoringDashboard { get; set; }
      public virtual DbSet<UsersClaim> v_UsersClaim { get; set; }
      public virtual DbSet<GreenIndustriesList> v_GreenIndustriesList { get; set; }
      public virtual DbSet<PollutionTaxesDashboard> v_PollutionTaxesDashboard { get; set; }
      public virtual DbSet<AirQualityMonitoringStationEquipmentsMapList> v_AirQualityMonitoringStationEquipmentsMapList { get; set; }
      public virtual DbSet<WastesList> v_WastesList { get; set; }
      public virtual DbSet<IndustryPollutionTypeTaxesDashboard> v_IndustryPollutionTypeTaxesDashboard { get; set; }
      public virtual DbSet<IndustryPollutionTaxesByEgClassificationDashboard> v_IndustryPollutionTaxesByEgClassificationDashboard { get; set; }
      public virtual DbSet<UserRelatedIndustry> v_UserRelatedIndustry { get; set; }
      public virtual DbSet<UserRelatedLab> v_UserRelatedLab { get; set; }
      public virtual DbSet<IndustryPhaseOneMonitoringMapList> v_IndustryPhaseOneMonitoringMapList { get; set; }
      public virtual DbSet<IsIndustryMonitoredMapList> v_IsIndustryMonitoredMapList { get; set; }
      public virtual DbSet<WasteSenderIndustryMapList> v_WasteSenderIndustryMapList { get; set; }
      #endregion

      #region "override methods"
      protected override void OnModelCreating(ModelBuilder builder)
      {
         // automatically adds all configurations in this assembly
         builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

         ApplyViewConfigurations(builder);

         SetGlobalQueryFilters(builder);

         // This should be placed here, at the end.
         builder.AddSoftDeleteShadowProperties();
         builder.AddAuditableShadowProperties();

         base.OnModelCreating(builder);
      }

      private void ApplyViewConfigurations(ModelBuilder builder)
      {
         builder.Entity<IndustryManagementDashboard>().HasNoKey().ToView("v_industrymanagementdashboard");
         builder.Entity<BigIndustryManagementDashboard>().HasNoKey().ToView("v_bigindustrymanagementdashboard");
         builder.Entity<UserManagementDashboard>().HasNoKey().ToView("v_usermanagementdashboard");
         builder.Entity<IndustryMonitoringDashboard>().HasNoKey().ToView("v_industrymonitoringdashboard");
         builder.Entity<MonitoringTypesFinishedSamplingsStatsDashboard>().HasNoKey().ToView("v_monitoringtypesfinishedsamplingsstatsdashboard");
         builder.Entity<MonitoringPollutionDashboard>().HasNoKey().ToView("v_monitoringpollutiondashboard");
         builder.Entity<ParameterRedundancyByProvinceDashboard>().HasNoKey().ToView("v_parameterredundancybyprovincedashboard");
         builder.Entity<MonitoringByProvinceDashboard>().HasNoKey().ToView("v_monitoringbyprovincedashboard");
         builder.Entity<FinishedMonitoringTypesMapList>().HasNoKey().ToView("v_finishedmonitoringtypesmaplist");
         builder.Entity<MonitoringRequiredIndustryMapList>().HasNoKey().ToView("v_monitoringrequiredindustrymaplist");
         builder.Entity<MonitoringPollutionMapList>().HasNoKey().ToView("v_monitoringpollutionmaplist");
         builder.Entity<ParamRedundancyByEstablishmentGroupingClassificationDashboard>().HasNoKey().ToView("v_paramredundancybyestablishmentgroupingclassificationdashboard");
         builder.Entity<IndustryNeedMonitoringDashboard>().HasNoKey().ToView("v_industryneedmonitoringdashboard");
         builder.Entity<UsersClaim>().HasNoKey().ToView("v_usersclaim");
         builder.Entity<GreenIndustriesList>().HasNoKey().ToView("v_greenindustrieslist");
         builder.Entity<PollutionTaxesDashboard>().HasNoKey().ToView("v_pollutiontaxesdashboard");
         builder.Entity<AirQualityMonitoringStationEquipmentsMapList>().HasNoKey().ToView("v_airqualitymonitoringstationequipmentsmaplist");
         builder.Entity<WastesList>().HasNoKey().ToView("v_wasteslist");
         builder.Entity<IndustryPollutionTypeTaxesDashboard>().HasNoKey().ToView("v_industrypollutiontypetaxesdashboard");
         builder.Entity<IndustryPollutionTaxesByEgClassificationDashboard>().HasNoKey().ToView("v_industrypollutiontaxesbyegclassificationdashboard");
         builder.Entity<UserRelatedIndustry>().HasNoKey().ToView("v_userrelatedindustry");
         builder.Entity<UserRelatedLab>().HasNoKey().ToView("v_userrelatedlab");
         builder.Entity<IndustryPhaseOneMonitoringMapList>().HasNoKey().ToView("v_industryphaseonemonitoringmaplist");
         builder.Entity<IsIndustryMonitoredMapList>().HasNoKey().ToView("v_isindustrymonitoredmaplist");
         builder.Entity<WasteSenderIndustryMapList>().HasNoKey().ToView("v_wastesenderindustrymaplist");
      }

      public override int SaveChanges()
      {
         ChangeTracker.DetectChanges();

         BeforeSaveTriggers();

         ChangeTracker.AutoDetectChangesEnabled =
            false; // for performance reasons, to avoid calling DetectChanges() again.
         var result = base.SaveChanges();
         ChangeTracker.AutoDetectChangesEnabled = true;
         return result;
      }

      public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
      {
         ChangeTracker.DetectChanges();

         BeforeSaveTriggers();

         ChangeTracker.AutoDetectChangesEnabled =
            false; // for performance reasons, to avoid calling DetectChanges() again.
         var result = base.SaveChangesAsync(cancellationToken);
         ChangeTracker.AutoDetectChangesEnabled = true;
         return result;
      }

      public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess,
         CancellationToken cancellationToken = new CancellationToken())
      {
         ChangeTracker.DetectChanges();

         BeforeSaveTriggers();

         ChangeTracker.AutoDetectChangesEnabled =
            false; // for performance reasons, to avoid calling DetectChanges() again.
         var result = base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
         ChangeTracker.AutoDetectChangesEnabled = true;
         return result;
      }
      #endregion

      #region "AccessControl"

      private void SetGlobalQueryFilters(ModelBuilder builder)
      {
         builder.Entity<WasteTransfer>().HasQueryFilter(q =>
            EF.Property<bool>(q, "IsDeleted") == false);
         builder.Entity<WasteExportImport>().HasQueryFilter(q =>
            EF.Property<bool>(q, "IsDeleted") == false);
         builder.Entity<Invoice>().HasQueryFilter(q =>
            EF.Property<bool>(q, "IsDeleted") == false);
      }

      #endregion

      #region "ExtraMethods"

      public T GetShadowPropertyValue<T>(object entity, string propertyName) where T : IConvertible
      {
         var value = this.Entry(entity).Property(propertyName).CurrentValue;
         return value != null ?
            (T)Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture) :
            default(T);
      }

      public object GetShadowPropertyValue(object entity, string propertyName)
      {
         return this.Entry(entity).Property(propertyName).CurrentValue;
      }

      public void ExecuteSqlCommand(string query)
      {
         Database.ExecuteSqlRaw(query);
      }

      public void ExecuteSqlCommand(string query, params object[] parameters)
      {
         Database.ExecuteSqlRaw(query, parameters);
      }

      private void BeforeSaveTriggers()
      {
         ValidateEntities();
         SetShadowProperties();
         this.ApplyCorrectYeKe();
      }

      private void ValidateEntities()
      {
         var errors = this.GetValidationErrors();
         if (!string.IsNullOrWhiteSpace(errors))
         {
            // we can't use constructor injection anymore, because we are using the `AddDbContextPool<>`
            var loggerFactory = this.GetService<ILoggerFactory>();
            loggerFactory.CheckArgumentIsNull(nameof(loggerFactory));
            var logger = loggerFactory.CreateLogger<AppDbContext>();
            logger.LogError(errors);
            throw new InvalidOperationException(errors);
         }
      }

      private void SetShadowProperties()
      {
         // we can't use constructor injection anymore, because we are using the `AddDbContextPool<>`
         var httpContextAccessor = this.GetService<IHttpContextAccessor>();
         httpContextAccessor.CheckArgumentIsNull(nameof(httpContextAccessor));
         ChangeTracker.SetAuditableEntityPropertyValues(httpContextAccessor);
         ChangeTracker.UpdateSoftDeleteStatuses();
      }
      #endregion
   }
}
