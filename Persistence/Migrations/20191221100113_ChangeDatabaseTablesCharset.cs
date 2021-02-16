using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class ChangeDatabaseTablesCharset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var cmd = @"
            SET FOREIGN_KEY_CHECKS=0;
            ALTER TABLE airqualitymonitoringstations CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE airqualitymonitoringstation_addresses CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE airqualitymonitoringstation_managers CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE airqualitystationconsumables CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE airqualitystationmeteorologicalsystems CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE airqualitystationparametersanalyzers CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE airqualitystationspareparts CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE ambientairparametersresults CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE chemicalpropertiesparameters CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE chimneyparametersresults CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE chimneysinfo CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE consumingmaterials CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE disinfectiondevicesinfos CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE energyconsumptions CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE enumdata CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE equipments CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE experimentparametersclassifications CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE greenindustries CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE greenindustrydescriptions CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE greenindustryrelations CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE greenindustrystrategies CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE groupreceiverusers CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE groups CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE humanresources CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE hydrometrystationclosedyears CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE hydrometrystations CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE hydrometrystation_addresses CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industrialtownsspecialtyassignedindustries CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industrialtownsspecialtydetails CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industrialtownsspecialtyinfos CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industrialunitssamplingresults CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industries CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industryevaluationenvironmentalmanagementcertificates CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industryevaluationgreenspacespeciesvegetations CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industryevaluations CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industryevaluationselectedasgreenindustryinformations CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industryevaluationunitsaleinformations CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industryinspectingmonitoringtypes CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industryinspectingplaces CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industryinspections CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industryinspectors CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industryonlinemonitoringequipments CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industryonlinemonitoringparameters CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industryonlinemonitorings CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industrypollutionreasons CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industrypollutions CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industrypollutiontypes CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industrywarningreasons CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industrywarnings CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industry_license CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industry_managers CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industry_officeaddresses CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE industry_workshopaddresses CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE informationvalidations CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE labconsumingmaterials CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE labs CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE lab_addresses CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE lab_managers CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE livestockspecialtydetails CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE livestockspecialtyinfos CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE manufacturedproducts CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE medicalcenterselfdeclarationinfos CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE medicalcenterunitsadditionalinfos CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE medicalcenterunitsinfos CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE messagereceivers CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE messages CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE monitoringcodings CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE monitoringinfos CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE monitoringparameters CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE municipalitywastespecialtyadditionalinfos CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE municipalitywastespecialtyinfos CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE needmonitoringtypes CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE normalwasteinformations CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE oldmigrationhistory CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE onlinemonitoringchimneyinfosparameters CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE onlinemonitoringoutletwastewatersparameters CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE outletwastewaters CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE parametersandmeasurementmethods CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE parameterssamplingresults CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE personnels CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE product CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE rawmaterials CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE refinerysendinggastypes CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE refineryspecialtyinfos CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE repositories CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE riverpassingcities CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE riverpassingprovinces CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE riverprovinceranges CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE rivers CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE riversecondarybasins CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE riverusagetypes CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE riverusagetypesinprovinces CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE roleclaims CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE roles CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE rotterdamconventionchemicals CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE slaughterhousespecialtyinfos CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE soundandwavesparametersresults CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE templatemanagers CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE uploads CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE userclaims CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE usergroups CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE userroles CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE users CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE usertokens CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastecodings CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastemanagementunitsdetails CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastemanagementunitsinfos CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wasteparameter CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wasteparametersresults CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastes CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastesshipments CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastetransfers CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastetransfersadditionalindustries CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastetransfersdescriptions CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastetransfersrelatedprovinces CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastetransportation CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastewaterdisposals CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastewaterparametersresults CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wastewaters CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE waterconsumptions CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wwhaspurificationsystems CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            ALTER TABLE wwusemotherpurificationsystems CONVERT TO CHARACTER SET utf8mb4 COLLATE utf8mb4_persian_ci;
            SET FOREIGN_KEY_CHECKS=1;
            ";
            migrationBuilder.Sql(cmd);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
