using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAPP.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblLOSDATCollatAppraisal",
                columns: table => new
                {
                    ApprID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollatID = table.Column<long>(type: "bigint", nullable: false),
                    SeqNo = table.Column<long>(type: "bigint", nullable: true),
                    DocumentNo = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    LandNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SurveySurface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Liable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LandSizeSqM = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LandPosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CheckBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Other = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SplitEntry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Distance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LandCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvgLandReclamation = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PositionLatitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionLongtitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WithBuilding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherLoan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PondAreaPct = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PondDepthEstimation = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RoadToLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoadSurface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoadSurfaceWidth = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PedestrianWay = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CarAccess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntranceExit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntranceExitCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Allocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Appraised = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AppraisedNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpaceEncroached = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PublicUtility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PondDrain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoadWithElecCab = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherUtility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstraintCond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsExpropriation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InLineExpropriated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoyalDecreeAct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricityOver100M = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ElectricityOver100MNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HighVoltageLine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocatedForestAgriPark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarNoAccess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherConditionNote = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Club = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecuritySystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stadium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyCardSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kindergarden = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WasteDisposalSystem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnyDevelopment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TownPlanReq = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhysicalReputation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjReputation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvVeryDensityResArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvMediumDensityResArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvLessDensityResArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvRusticResidentialNeighborhood = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvNeglectedLand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvCommercialDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvIndustrialDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvAgriculturalDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvBizCommDistrictInCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnvResidentialSwitchCommercial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PollWell = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PollHighVoltage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PollJunkyard = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PollWasteWaterTreatPlant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PollWasteDisposalSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PollSlaughterhouse = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PollForest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PollOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiqVeryLargeTradingVol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiqMediumTradingVol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiqLessTradingVol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiqNoTrading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LiqNotStated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CollatFaceDirection = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remark = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstDeedNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstSite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionScaleEncr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstProgOriBuilding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstProgOriBuildingPct = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ConstProgExpand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstProgExpandPct = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    BuildingYr = table.Column<short>(type: "smallint", nullable: true),
                    ConstPermitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BuildingType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingCond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfFloor = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsResidential = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoofFrame = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Roof = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wall = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Painting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor1Surface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Floor2Surface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OthFloor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OthFloorSurface = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConstType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Village = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UtilOfBuilding = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingArea = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FireInsSpace = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    RoomNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorNoCondo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FloorNoActual = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotLivSpace = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OutLivSpace = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IntSpace = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FloorMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BathroomFlrMaterial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfSection = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NoOfPart = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CondoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalNoFloor = table.Column<short>(type: "smallint", nullable: true),
                    BuildingNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expropriation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Decoration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuildingStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SpaceDiv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pool = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lift = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SaunaRoom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GymRoom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireEscape = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireHydrant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Park = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiffGradeEffectPric = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Environment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pollution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Liquidity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AerialPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AerialPhotoNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AerialPhotoPageNumber = table.Column<int>(type: "int", nullable: true),
                    RegisterNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsHost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SendHost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubDistrict = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistrictOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubDistrictOther = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLOSDATCollatAppraisal", x => x.ApprID);
                });

            migrationBuilder.CreateTable(
                name: "tblLOSDATCollatApprValue",
                columns: table => new
                {
                    ValueD = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollatID = table.Column<long>(type: "bigint", nullable: false),
                    ApprID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblLOSDATCollatApprValue", x => x.ValueD);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblLOSDATCollatAppraisal");

            migrationBuilder.DropTable(
                name: "tblLOSDATCollatApprValue");
        }
    }
}
