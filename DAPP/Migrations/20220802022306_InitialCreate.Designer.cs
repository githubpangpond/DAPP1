// <auto-generated />
using System;
using DAPP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAPP.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220802022306_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAPP.Models.LOSDATCollatAppraisal", b =>
                {
                    b.Property<long>("ApprID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ApprID"), 1L, 1);

                    b.Property<string>("AerialPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AerialPhotoNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AerialPhotoPageNumber")
                        .HasColumnType("int");

                    b.Property<string>("Allocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnyDevelopment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Appraised")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AppraisedNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("AvgLandReclamation")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BathroomFlrMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("BuildingArea")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("BuildingCond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingStyle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuildingType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<short?>("BuildingYr")
                        .HasColumnType("smallint");

                    b.Property<string>("CarAccess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarNoAccess")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CheckBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Club")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CollatFaceDirection")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CollatID")
                        .HasColumnType("bigint");

                    b.Property<string>("CondoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConstDeedNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ConstPermitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConstProgExpand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ConstProgExpandPct")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ConstProgOriBuilding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("ConstProgOriBuildingPct")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ConstSite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConstType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConstraintCond")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Decoration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiffGradeEffectPric")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Distance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DistrictOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentNo")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ElectricityOver100M")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ElectricityOver100MNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntranceExit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntranceExitCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvAgriculturalDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvBizCommDistrictInCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvCommercialDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvIndustrialDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvLessDensityResArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvMediumDensityResArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvNeglectedLand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvResidentialSwitchCommercial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvRusticResidentialNeighborhood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnvVeryDensityResArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Environment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Expropriation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FireEscape")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FireHydrant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("FireInsSpace")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Floor1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floor1Surface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floor2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Floor2Surface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FloorMaterial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FloorNoActual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FloorNoCondo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GymRoom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighVoltageLine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HouseNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InLineExpropriated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("IntSpace")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("IsExpropriation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsHost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IsResidential")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KeyCardSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kindergarden")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("LandSizeSqM")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Liable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lift")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiqLessTradingVol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiqMediumTradingVol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiqNoTrading")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiqNotStated")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LiqVeryLargeTradingVol")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Liquidity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LocatedForestAgriPark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("NoOfFloor")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("NoOfPart")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("NoOfSection")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("OthFloor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OthFloorSurface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Other")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherConditionNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherLoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherUtility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("OutLivSpace")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PageNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Painting")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Park")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PedestrianWay")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhysicalReputation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PollForest")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PollHighVoltage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PollJunkyard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PollOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PollSlaughterhouse")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PollWasteDisposalSite")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PollWasteWaterTreatPlant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PollWell")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pollution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PondAreaPct")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PondDepthEstimation")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PondDrain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pool")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionLatitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PositionLongtitude")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjReputation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProvinceOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicUtility")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RegisterNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoadSurface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("RoadSurfaceWidth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("RoadToLand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoadWithElecCab")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roof")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoofFrame")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoomNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoyalDecreeAct")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SaunaRoom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SectionScaleEncr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecuritySystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SendHost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SeqNo")
                        .HasColumnType("bigint");

                    b.Property<string>("SpaceDiv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("SpaceEncroached")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SplitEntry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stadium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubDistrict")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubDistrictOther")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SurveySurface")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TotLivSpace")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short?>("TotalNoFloor")
                        .HasColumnType("smallint");

                    b.Property<string>("TownPlanReq")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UtilOfBuilding")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Village")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wall")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WasteDisposalSystem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WithBuilding")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApprID");

                    b.ToTable("tblLOSDATCollatAppraisal");
                });

            modelBuilder.Entity("DAPP.Models.LOSDATCollatApprValue", b =>
                {
                    b.Property<long>("ValueD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ValueD"), 1L, 1);

                    b.Property<long>("ApprID")
                        .HasColumnType("bigint");

                    b.Property<long>("CollatID")
                        .HasColumnType("bigint");

                    b.HasKey("ValueD");

                    b.ToTable("tblLOSDATCollatApprValue");
                });
#pragma warning restore 612, 618
        }
    }
}
