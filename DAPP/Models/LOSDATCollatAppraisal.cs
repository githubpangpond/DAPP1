using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPP.Models
{
    public class LOSDATCollatAppraisal
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long ApprID { get; set; }

        [Required]
        [Column(TypeName = "bigint")]
        public long CollatID { get; set; }

        [Column(TypeName = "bigint")]
        public long? SeqNo { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string DocumentNo { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string LandNo { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string BookNo { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string PageNo { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string SurveySurface { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string Liable { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal? LandSizeSqM { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string LandPosition { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string CheckBy { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Other { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Street { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string SplitEntry { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal? Distance { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string LandCondition { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal? AvgLandReclamation { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string PositionLatitude { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string PositionLongtitude { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string WithBuilding { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string OtherLoan { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal? PondAreaPct { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal? PondDepthEstimation { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string RoadToLand { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string RoadSurface { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal? RoadSurfaceWidth { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal? PedestrianWay { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string CarAccess { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string EntranceExit { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        public string EntranceExitCondition { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Allocation { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Appraised { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string AppraisedNote { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal? SpaceEncroached { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string PublicUtility { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string PondDrain { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string RoadWithElecCab { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string OtherUtility { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string ConstraintCond { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string IsExpropriation { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string InLineExpropriated { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string RoyalDecreeAct { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string ElectricityOver100M { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ElectricityOver100MNote { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string HighVoltageLine { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string LocatedForestAgriPark { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string CarNoAccess { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string OtherCondition { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string OtherConditionNote { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string Club { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string SecuritySystem { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string Stadium { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string KeyCardSystem { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string Kindergarden { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string WasteDisposalSystem { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string AnyDevelopment { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string TownPlanReq { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string PhysicalReputation { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Location { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string ProjReputation { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Environment { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string EnvVeryDensityResArea { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string EnvMediumDensityResArea { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string EnvLessDensityResArea { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string EnvRusticResidentialNeighborhood { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string EnvNeglectedLand { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string EnvCommercialDistrict { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string EnvIndustrialDistrict { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string EnvAgriculturalDistrict { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string EnvBizCommDistrictInCity { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string EnvResidentialSwitchCommercial { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Pollution { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string PollWell { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string PollHighVoltage { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string PollJunkyard { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string PollWasteWaterTreatPlant { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string PollWasteDisposalSite { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string PollSlaughterhouse { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string PollForest { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string PollOther { get; set; }

        [Column(TypeName = "varchar(80)")]
        public string Liquidity { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string LiqVeryLargeTradingVol { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string LiqMediumTradingVol { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string LiqLessTradingVol { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string LiqNoTrading { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string LiqNotStated { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string CollatFaceDirection { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        public string Remark { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string HouseNo { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string ConstDeedNo { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string ConstSite { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        public string SectionScaleEncr { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string ConstProgOriBuilding { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal? ConstProgOriBuildingPct { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string ConstProgExpand { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        public decimal? ConstProgExpandPct { get; set; }

        [Column(TypeName = "smallint")]
        public short? BuildingYr { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? ConstPermitDate { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string BuildingType { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string BuildingModel { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string BuildingCond { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public Decimal? NoOfFloor { get; set; }

        [Column(TypeName = "varchar(5)")]
        public string IsResidential { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string RoofFrame { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Roof { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Wall { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Painting { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Floor1 { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Floor1Surface { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Floor2 { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Floor2Surface { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string OthFloor { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string OthFloorSurface { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Fence { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string ConstType { get; set; }

        public string Village { get; set; }

        public string UtilOfBuilding { get; set; }

        public decimal? BuildingArea { get; set; }

        public decimal? FireInsSpace { get; set; }

        public string RoomNo { get; set; }

        public string FloorNoCondo { get; set; }

        public string FloorNoActual { get; set; }

        public decimal? TotLivSpace { get; set; }

        public decimal? OutLivSpace { get; set; }

        public decimal? IntSpace { get; set; }

        public string FloorMaterial { get; set; }

        public string BathroomFlrMaterial { get; set; }

        public decimal? NoOfSection { get; set; }

        public decimal? NoOfPart { get; set; }

        public string CondoName { get; set; }

        public short? TotalNoFloor { get; set; }

        public string BuildingNo { get; set; }

        public string RegNo { get; set; }

        public string Expropriation { get; set; }

        public string Decoration { get; set; }

        public string BuildingStyle { get; set; }

        public string SpaceDiv { get; set; }

        public string Pool { get; set; }

        public string Lift { get; set; }

        public string SaunaRoom { get; set; }

        public string Parking { get; set; }

        public string GymRoom { get; set; }

        public string FireEscape { get; set; }

        public string FireHydrant { get; set; }

        public string Park { get; set; }

        public string DiffGradeEffectPric { get; set; }

        public string AerialPhoto { get; set; }

        public string AerialPhotoNumber { get; set; }

        public int? AerialPhotoPageNumber { get; set; }

        public string RegisterNumber { get; set; }

        public string IsHost { get; set; }

        public string SendHost { get; set; }

        public string CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

        public string UpdatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public string Province { get; set; }

        public string District { get; set; }

        public string SubDistrict { get; set; }

        public string ProvinceOther { get; set; }

        public string DistrictOther { get; set; }

        public string SubDistrictOther { get; set; }

    }
}
