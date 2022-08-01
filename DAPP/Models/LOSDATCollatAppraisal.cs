using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DAPP.Models
{
    public class LOSDATCollatAppraisal
    {
        [Key]
        public long ApprID { get; set; }

        [Required]
        public long CollatID { get; set; }

        public long? SeqNo { get; set; }

        [Column(TypeName = "nvarcha(40)")]
        public string DocumentNo { get; set; }

        public string LandNo { get; set; }
        public string BookNo { get; set; }
        public string PageNo { get; set; }
        public string SurveySurface { get; set; }
        public string Liable { get; set; }
        public decimal? LandSizeSqM { get; set; }
        public string LandPosition { get; set; }
        public string CheckBy { get; set; }
        public string Other { get; set; }
        public string Street { get; set; }
        public string SplitEntry { get; set; }
        public decimal? Distance { get; set; }
        public string LandCondition { get; set; }
        public decimal? AvgLandReclamation { get; set; }
        public string PositionLatitude { get; set; }
        public string PositionLongtitude { get; set; }
        public string WithBuilding { get; set; }
        public string OtherLoan { get; set; }
        public decimal? PondAreaPct { get; set; }
        public decimal? PondDepthEstimation { get; set; }
        public string RoadToLand { get; set; }
        public string RoadSurface { get; set; }
        public decimal? RoadSurfaceWidth { get; set; }
        public decimal? PedestrianWay { get; set; }
        public string CarAccess { get; set; }
        public string EntranceExit { get; set; }
        public string EntranceExitCondition { get; set; }
        public string Allocation { get; set; }
        public string Appraised { get; set; }
        public string AppraisedNote { get; set; }
        public decimal? SpaceEncroached { get; set; }
        public string PublicUtility { get; set; }
        public string PondDrain { get; set; }
        public string RoadWithElecCab { get; set; }
        public string OtherUtility { get; set; }
        public string ConstraintCond { get; set; }
        public string IsExpropriation { get; set; }
        public string InLineExpropriated { get; set; }
        public string RoyalDecreeAct { get; set; }
        public string ElectricityOver100M { get; set; }
        public string ElectricityOver100MNote { get; set; }
        public string HighVoltageLine { get; set; }
        public string LocatedForestAgriPark { get; set; }
        public string CarNoAccess { get; set; }
        public string OtherCondition { get; set; }
        public string OtherConditionNote { get; set; }
        public string Club { get; set; }
        public string SecuritySystem { get; set; }
        public string Stadium { get; set; }
        public string KeyCardSystem { get; set; }
        public string Kindergarden { get; set; }
        public string WasteDisposalSystem { get; set; }
        public string AnyDevelopment { get; set; }
        public string TownPlanReq { get; set; }
        public string PhysicalReputation { get; set; }
        public string Location { get; set; }
        public string ProjReputation { get; set; }
        public string EnvVeryDensityResArea { get; set; }
        public string EnvMediumDensityResArea { get; set; }
        public string EnvLessDensityResArea { get; set; }
        public string EnvRusticResidentialNeighborhood { get; set; }
        public string EnvNeglectedLand { get; set; }
        public string EnvCommercialDistrict { get; set; }
        public string EnvIndustrialDistrict { get; set; }
        public string EnvAgriculturalDistrict { get; set; }
        public string EnvBizCommDistrictInCity { get; set; }
        public string EnvResidentialSwitchCommercial { get; set; }
        public string PollWell { get; set; }
        public string PollHighVoltage { get; set; }
        public string PollJunkyard { get; set; }
        public string PollWasteWaterTreatPlant { get; set; }
        public string PollWasteDisposalSite { get; set; }
        public string PollSlaughterhouse { get; set; }
        public string PollForest { get; set; }
        public string PollOther { get; set; }
        public string LiqVeryLargeTradingVol { get; set; }
        public string LiqMediumTradingVol { get; set; }
        public string LiqLessTradingVol { get; set; }
        public string LiqNoTrading { get; set; }
        public string LiqNotStated { get; set; }
        public string CollatFaceDirection { get; set; }
        public string Remark { get; set; }
        public string HouseNo { get; set; }
        public string ConstDeedNo { get; set; }
        public string ConstSite { get; set; }
        public string SectionScaleEncr { get; set; }
        public string ConstProgOriBuilding { get; set; }
        public decimal? ConstProgOriBuildingPct { get; set; }
        public string ConstProgExpand { get; set; }
        public decimal? ConstProgExpandPct { get; set; }
        public short? BuildingYr { get; set; }
        public DateTime? ConstPermitDate { get; set; }
        public string BuildingType { get; set; }
        public string BuildingModel { get; set; }
        public string BuildingCond { get; set; }
        public Decimal? NoOfFloor { get; set; }
        public string IsResidential { get; set; }
        public string RoofFrame { get; set; }
        public string Roof { get; set; }
        public string Wall { get; set; }
        public string Painting { get; set; }
        public string Floor1 { get; set; }
        public string Floor1Surface { get; set; }
        public string Floor2 { get; set; }
        public string Floor2Surface { get; set; }
        public string OthFloor { get; set; }
        public string OthFloorSurface { get; set; }
        public string Fence { get; set; }
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
        public string Environment { get; set; }
        public string Pollution { get; set; }
        public string Liquidity { get; set; }
        public string AerialPhoto { get; set; }
        public string AerialPhotoNumber { get; set; }
        public int? AerialPhotoPageNumber { get; set; }
        public string RegisterNumber { get; set; }
        public string IsHost { get; set; }
        public string SendHost { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string SubDistrict { get; set; }
        public string ProvinceOther { get; set; }
        public string DistrictOther { get; set; }
        public string SubDistrictOther { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
