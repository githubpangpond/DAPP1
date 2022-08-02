﻿// <auto-generated />
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
    [Migration("20220802050508_UpdateDB1")]
    partial class UpdateDB1
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
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("AerialPhotoNumber")
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("AerialPhotoPageNumber")
                        .HasColumnType("int");

                    b.Property<string>("Allocation")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("AnyDevelopment")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Appraised")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("AppraisedNote")
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal?>("AvgLandReclamation")
                        .HasColumnType("decimal(19,4)");

                    b.Property<string>("BathroomFlrMaterial")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("BookNo")
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal?>("BuildingArea")
                        .HasColumnType("decimal(19,5)");

                    b.Property<string>("BuildingCond")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("BuildingModel")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("BuildingNo")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("BuildingStyle")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("BuildingType")
                        .HasColumnType("nvarchar(10)");

                    b.Property<short?>("BuildingYr")
                        .HasColumnType("smallint");

                    b.Property<string>("CarAccess")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("CarNoAccess")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("CheckBy")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Club")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("CollatFaceDirection")
                        .HasColumnType("nvarchar(10)");

                    b.Property<long>("CollatID")
                        .HasColumnType("bigint");

                    b.Property<string>("CondoName")
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("ConstDeedNo")
                        .HasColumnType("nvarchar(40)");

                    b.Property<DateTime?>("ConstPermitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ConstProgExpand")
                        .HasColumnType("varchar(5)");

                    b.Property<decimal?>("ConstProgExpandPct")
                        .HasColumnType("decimal(19,4)");

                    b.Property<string>("ConstProgOriBuilding")
                        .HasColumnType("varchar(5)");

                    b.Property<decimal?>("ConstProgOriBuildingPct")
                        .HasColumnType("decimal(19,4)");

                    b.Property<string>("ConstSite")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ConstType")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ConstraintCond")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Decoration")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("DiffGradeEffectPric")
                        .HasColumnType("varchar(5)");

                    b.Property<decimal?>("Distance")
                        .HasColumnType("decimal(19,4)");

                    b.Property<string>("District")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DistrictOther")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DocumentNo")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ElectricityOver100M")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("ElectricityOver100MNote")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EntranceExit")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("EntranceExitCondition")
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("EnvAgriculturalDistrict")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("EnvBizCommDistrictInCity")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("EnvCommercialDistrict")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("EnvIndustrialDistrict")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("EnvLessDensityResArea")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("EnvMediumDensityResArea")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("EnvNeglectedLand")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("EnvResidentialSwitchCommercial")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("EnvRusticResidentialNeighborhood")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("EnvVeryDensityResArea")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Environment")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Expropriation")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Fence")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FireEscape")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("FireHydrant")
                        .HasColumnType("varchar(5)");

                    b.Property<decimal?>("FireInsSpace")
                        .HasColumnType("decimal(19,5)");

                    b.Property<string>("Floor1")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Floor1Surface")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Floor2")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Floor2Surface")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FloorMaterial")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("FloorNoActual")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("FloorNoCondo")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("GymRoom")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("HighVoltageLine")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("HouseNo")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("InLineExpropriated")
                        .HasColumnType("varchar(5)");

                    b.Property<decimal?>("IntSpace")
                        .HasColumnType("decimal(19,5)");

                    b.Property<string>("IsExpropriation")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("IsHost")
                        .HasColumnType("varchar(1)");

                    b.Property<string>("IsResidential")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("KeyCardSystem")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Kindergarden")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("LandCondition")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("LandNo")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("LandPosition")
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal?>("LandSizeSqM")
                        .HasColumnType("decimal(19,4)");

                    b.Property<string>("Liable")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Lift")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("LiqLessTradingVol")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("LiqMediumTradingVol")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("LiqNoTrading")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("LiqNotStated")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("LiqVeryLargeTradingVol")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Liquidity")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("LocatedForestAgriPark")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal?>("NoOfFloor")
                        .HasColumnType("decimal(5,2)");

                    b.Property<decimal?>("NoOfPart")
                        .HasColumnType("decimal(19,7)");

                    b.Property<decimal?>("NoOfSection")
                        .HasColumnType("decimal(19,7)");

                    b.Property<string>("OthFloor")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("OthFloorSurface")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Other")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("OtherCondition")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("OtherConditionNote")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("OtherLoan")
                        .HasColumnType("nvarchar(5)");

                    b.Property<string>("OtherUtility")
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal?>("OutLivSpace")
                        .HasColumnType("decimal(19,5)");

                    b.Property<string>("PageNo")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Painting")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Park")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Parking")
                        .HasColumnType("varchar(5)");

                    b.Property<decimal?>("PedestrianWay")
                        .HasColumnType("decimal(19,4)");

                    b.Property<string>("PhysicalReputation")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("PollForest")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("PollHighVoltage")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("PollJunkyard")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("PollOther")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("PollSlaughterhouse")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("PollWasteDisposalSite")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("PollWasteWaterTreatPlant")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("PollWell")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Pollution")
                        .HasColumnType("varchar(80)");

                    b.Property<decimal?>("PondAreaPct")
                        .HasColumnType("decimal(19,4)");

                    b.Property<decimal?>("PondDepthEstimation")
                        .HasColumnType("decimal(19,4)");

                    b.Property<string>("PondDrain")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Pool")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("PositionLatitude")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("PositionLongtitude")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ProjReputation")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Province")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("ProvinceOther")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PublicUtility")
                        .HasColumnType("varchar(80)");

                    b.Property<string>("RegNo")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("RegisterNumber")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Remark")
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("RoadSurface")
                        .HasColumnType("nvarchar(10)");

                    b.Property<decimal?>("RoadSurfaceWidth")
                        .HasColumnType("decimal(19,4)");

                    b.Property<string>("RoadToLand")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RoadWithElecCab")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Roof")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RoofFrame")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("RoomNo")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("RoyalDecreeAct")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("SaunaRoom")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("SectionScaleEncr")
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("SecuritySystem")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("SendHost")
                        .HasColumnType("varchar(1)");

                    b.Property<long?>("SeqNo")
                        .HasColumnType("bigint");

                    b.Property<string>("SpaceDiv")
                        .HasColumnType("varchar(5)");

                    b.Property<decimal?>("SpaceEncroached")
                        .HasColumnType("decimal(19,4)");

                    b.Property<string>("SplitEntry")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Stadium")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SubDistrict")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("SubDistrictOther")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SurveySurface")
                        .HasColumnType("nvarchar(40)");

                    b.Property<decimal?>("TotLivSpace")
                        .HasColumnType("decimal(19,5)");

                    b.Property<short?>("TotalNoFloor")
                        .HasColumnType("smallint");

                    b.Property<string>("TownPlanReq")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("UtilOfBuilding")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Village")
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Wall")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("WasteDisposalSystem")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("WithBuilding")
                        .HasColumnType("nvarchar(10)");

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