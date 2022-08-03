using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPP.Models
{
    public class LOSDATCollatAppraisal
    {
        [Key]
        [Column(TypeName = "bigint")]
        [Display(Name = "รหัสประเมิน")]
        public long ApprID { get; set; }

        [Required]
        [Column(TypeName = "bigint")]
        [Display(Name = "เลขที่หลักประกัน")]
        public long CollatID { get; set; }

        [Column(TypeName = "bigint")]
        [Display(Name = "ลำดับที่")]
        public long? SeqNo { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "เลขที่เอกสารสิทธิ์")]
        public string DocumentNo { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "เลขที่ดิน")]
        public string LandNo { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "เล่มที่")]
        public string BookNo { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "หน้าที่")]
        public string PageNo { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "หน้าสำรวจ")]
        public string SurveySurface { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "ระวาง")]
        public string Liable { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "เนื้อที่ดิน(ตารางวา)")]
        public decimal? LandSizeSqM { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ตำแหน่งที่ดิน")]
        public string LandPosition { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ตรวจจาก")]
        public string CheckBy { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "อื่นๆ")]
        public string Other { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "ตั้งอยู่บนถนน")]
        public string Street { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "แยกเข้าซอย")]
        public string SplitEntry { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ระยะทาง(เมตร)")]
        public decimal? Distance { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "สภาพที่ดิน")]
        public string LandCondition { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ระดับดินถมเฉลี่ย(เซนติเมตร)")]
        public decimal? AvgLandReclamation { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "ตำแหน่งพิกัดละติจูด")]
        public string PositionLatitude { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "ตำแหน่งพิกัดลองจิจูด")]
        public string PositionLongtitude { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "สิ่งปลูกสร้าง")]
        public string WithBuilding { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        [Display(Name = "กู้ประเภทอื่นๆ")]
        public string OtherLoan { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "เนื้อที่บ่อน้ำ(ตารางวา)")]
        public decimal? PondAreaPct { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ความลึกโดยประมาณ(เมตร)")]
        public decimal? PondDepthEstimation { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ถนนผ่านหน้าที่ดิน")]
        public string RoadToLand { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ลักษณะผิวจราจร")]
        public string RoadSurface { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ผิวจราจรกว้าง(เมตร)")]
        public decimal? RoadSurfaceWidth { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "เขตทาง(เมตร)")]
        public decimal? PedestrianWay { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "รถยนต์เข้า-ออก")]
        public string CarAccess { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ทางเข้า-ออก")]
        public string EntranceExit { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [Display(Name = "ต้องมีการปรับปรุงสภาพทาง")]
        public string EntranceExitCondition { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "โครงการจัดสรร")]
        public string Allocation { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ประเมินราคา")]
        public string Appraised { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [Display(Name = "หมายเหตุ")]
        public string AppraisedNote { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "เนื้อที่ถูกรุกล้ำ/ใช้เพื่อบุคคลอื่น")]
        public decimal? SpaceEncroached { get; set; }

        [Column(TypeName = "varchar(80)")]
        [Display(Name = "สาธารณูปโภค")]
        public string PublicUtility { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "บ่อพัก / ท่อระบายน้ำ")]
        public string PondDrain { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ไฟฟ้าถนน")]
        public string RoadWithElecCab { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        [Display(Name = "สาธารณูปโภคอื่นๆ")]
        public string OtherUtility { get; set; }

        [Column(TypeName = "varchar(80)")]
        [Display(Name = "ConstraintCond")]
        public string ConstraintCond { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "อยู่ในระวางเวนคืน")]
        public string IsExpropriation { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "อยู่ในแนวเวนคืน ตาม พรฎ/พรบ")]
        public string InLineExpropriated { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "ตาม พรฎ./พรบ")]
        public string RoyalDecreeAct { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "จุดสิ้นสุดสาธารณูปโภคไฟฟ้าถาวรอยู่ห่างหลักประกันไปตามแนวถนน/ซอย  ระยะทางประมาณ                  เมตร(กรณีเกิน 100 เมตร)")]
        public string ElectricityOver100M { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "ElectricityOver100MNote")]
        public string ElectricityOver100MNote { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "อยู่ในแนวสายไฟฟ้าแรงสูง")]
        public string HighVoltageLine { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "อยู่ในเขตป่าฯ / อยู่ในเขต สปก. / อุทยานฯ")]
        public string LocatedForestAgriPark { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "รูปร่างลักษณะที่ดินหลักประกันไม่สามารถนำรถยนต์เข้าไปในที่ดินได้")]
        public string CarNoAccess { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "เงื่อนไขเพิ่มเติม")]
        public string OtherCondition { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "OtherConditionNote")]
        public string OtherConditionNote { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "สโมสร")]
        public string Club { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ระบบรักษาความปลอดภัย")]
        public string SecuritySystem { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "สนามกีฬากลางแจ้ง")]
        public string Stadium { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ระบบ Key card")]
        public string KeyCardSystem { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "โรงเรียนอนุบาล")]
        public string Kindergarden { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ระบบการทิ้งและกำจัดขยะ")]
        public string WasteDisposalSystem { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "การพัฒนาในพื้นที่")]
        public string AnyDevelopment { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ข้อกำหนดผังเมือง")]
        public string TownPlanReq { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ลักษณะทางกายภาพ/ รูปแปลง")]
        public string PhysicalReputation { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "สถานที่ตั้ง")]
        public string Location { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ชื่อเสียงโครงการ (ผู้ประกอบการ)")]
        public string ProjReputation { get; set; }

        [Column(TypeName = "varchar(80)")]
        [Display(Name = "สภาพแวดล้อม")]
        public string Environment { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ย่านที่อยู่อาศัยหนาแน่นมาก")]
        public string EnvVeryDensityResArea { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ย่านที่อยู่อาศัยหนาแน่นปานกลาง")]
        public string EnvMediumDensityResArea { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ย่านที่อยู่อาศัยหนาแน่นน้อย")]
        public string EnvLessDensityResArea { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ย่านที่อยู่อาศัยประปราย ชนบท")]
        public string EnvRusticResidentialNeighborhood { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ที่ดินรกร้าง เปล่าห่างไกลชุมชน")]
        public string EnvNeglectedLand { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ย่านพานิชยกรรม")]
        public string EnvCommercialDistrict { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ย่านอุตสาหกรรม")]
        public string EnvIndustrialDistrict { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ย่านเกษตรกรรม")]
        public string EnvAgriculturalDistrict { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ย่านธุรกิจการค้าใจกลางเมือง")]
        public string EnvBizCommDistrictInCity { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ย่านที่อยู่อาศัยสลับพานิชยกรรม")]
        public string EnvResidentialSwitchCommercial { get; set; }

        [Column(TypeName = "varchar(80)")]
        [Display(Name = "มลภาวะ")]
        public string Pollution { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "บ่อน้ำ")]
        public string PollWell { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ไฟฟ้าแรงสูง")]
        public string PollHighVoltage { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "บ่อขยะ")]
        public string PollJunkyard { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "บ่อบำบัด")]
        public string PollWasteWaterTreatPlant { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ที่ทิ้งของเสีย")]
        public string PollWasteDisposalSite { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "โรงฆ่าสัตว์")]
        public string PollSlaughterhouse { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "เขตป่าไม้")]
        public string PollForest { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "อื่นๆ")]
        public string PollOther { get; set; }

        [Column(TypeName = "varchar(80)")]
        [Display(Name = "สภาพคล่อง")]
        public string Liquidity { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "มีการซื้อขายเปลี่ยนมือปริมาณมาก")]
        public string LiqVeryLargeTradingVol { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "มีการซื้อขายเปลี่ยนมือปริมาณปานกลาง")]
        public string LiqMediumTradingVol { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "มีการซื้อขายเปลี่ยนมือปริมาณน้อย")]
        public string LiqLessTradingVol { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ไม่มีการซื้อขายเปลี่ยนมือ")]
        public string LiqNoTrading { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ไม่ระบุ")]
        public string LiqNotStated { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ทิศที่ตั้งหลักประกัน")]
        public string CollatFaceDirection { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "หมายเหตุ")]
        public string Remark { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "บ้านเลขที่")]
        public string HouseNo { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "ก่อสร้างบนโฉนดเลขที่")]
        public string ConstDeedNo { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ตำแหน่งก่อสร้าง")]
        public string ConstSite { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "ส่วน/ขนาดที่รุกล้ำ(ตารางเมตร)")]
        public string SectionScaleEncr { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ก่อสร้างแล้วเสร็จ(อาคารเดิม)")]
        public string ConstProgOriBuilding { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ConstProgOriBuildingPct")]
        public decimal? ConstProgOriBuildingPct { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ก่อสร้างแล้วเสร็จ(ปลูกสร้าง/ต่อเติม)")]
        public string ConstProgExpand { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ConstProgExpandPct")]
        public decimal? ConstProgExpandPct { get; set; }

        [Column(TypeName = "smallint")]
        [Display(Name = "อายุอาคาร(ปี)")]
        public short? BuildingYr { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "วันที่ใบอนุญาตก่อสร้างหมดอายุ")]
        public DateTime? ConstPermitDate { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ประเภทอาคาร")]
        public string BuildingType { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ลักษณะอาคาร")]
        public string BuildingModel { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "รูปแบบอาคาร")]
        public string BuildingCond { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        [Display(Name = "จำนวนชั้น")]
        public Decimal? NoOfFloor { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "การใช้อยู่อาศัย")]
        public string IsResidential { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "โครงหลังคา")]
        public string RoofFrame { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "หลังคา")]
        public string Roof { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ผนัง")]
        public string Wall { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "การทาสี")]
        public string Painting { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "พื้นชั้น 1")]
        public string Floor1 { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ผิวพื้นชั้น1")]
        public string Floor1Surface { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "พื้นชั้น 2")]
        public string Floor2 { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ผิวพื้นชั้น2")]
        public string Floor2Surface { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "หมายเหตุพื้นชั้นอื่นๆ")]
        public string OthFloor { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "หมายเหตุผิวพื้นชั้นอื่นๆ")]
        public string OthFloorSurface { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "รั้ว")]
        public string Fence { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ประเภทการก่อสร้าง")]
        public string ConstType { get; set; }

        [Column(TypeName = "nvarchar(80)")]
        [Display(Name = "หมู่บ้าน")]
        public string Village { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "การใช้ประโยชน์ของอาคาร")]
        public string UtilOfBuilding { get; set; }

        [Column(TypeName = "decimal(19,5)")]
        [Display(Name = "เนื้อที่อาคาร(ตารางเมตร)")]
        public decimal? BuildingArea { get; set; }

        [Column(TypeName = "decimal(19,5)")]
        [Display(Name = "เนื้อที่ประกันอัคคีภัย(ตารางเมตร)")]
        public decimal? FireInsSpace { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "ห้องชุดเลขที่")]
        public string RoomNo { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        [Display(Name = "ชั้นที่(ตาม อช.)")]
        public string FloorNoCondo { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        [Display(Name = "FloorNoActual")]
        public string FloorNoActual { get; set; }

        [Column(TypeName = "decimal(19,5)")]
        [Display(Name = "เนื้อที่ห้องชุดรวม(ตารางเมตร)")]
        public decimal? TotLivSpace { get; set; }

        [Column(TypeName = "decimal(19,5)")]
        [Display(Name = "เนื้อที่ภายนอกห้องชุด(ตารางเมตร)")]
        public decimal? OutLivSpace { get; set; }

        [Column(TypeName = "decimal(19,5)")]
        [Display(Name = "เนื้อที่ภายในห้องชุด(ตารางเมตร)")]
        public decimal? IntSpace { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "วัสดุปูพื้นห้องชุด")]
        public string FloorMaterial { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "วัสดุปูพื้นห้องน้ำ")]
        public string BathroomFlrMaterial { get; set; }

        [Column(TypeName = "decimal(19,7)")]
        [Display(Name = "จำนวน(ส่วน)")]
        public decimal? NoOfSection { get; set; }

        [Column(TypeName = "decimal(19,7)")]
        [Display(Name = "ใน(ส่วน)")]
        public decimal? NoOfPart { get; set; }

        [Column(TypeName = "nvarchar(80)")]
        [Display(Name = "ชื่ออาคารชุด")]
        public string CondoName { get; set; }

        [Column(TypeName = "smallint")]
        [Display(Name = "อาคารสูง(ชั้น)")]
        public short? TotalNoFloor { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Display(Name = "อาคารชุดเลขที่ / หลังที่")]
        public string BuildingNo { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        [Display(Name = "เลขที่จดทะเบียน")]
        public string RegNo { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "การเวนคืน")]
        public string Expropriation { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "การตกแต่ง")]
        public string Decoration { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ลักษณะอาคาร")]
        public string BuildingStyle { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "การแบ่งพื้นที่")]
        public string SpaceDiv { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "สระว่ายน้ำ")]
        public string Pool { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ลิฟท์โดยสาร")]
        public string Lift { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ห้องอบไอน้ำ")]
        public string SaunaRoom { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ที่จอดรถ")]
        public string Parking { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ห้องออกกำลังกาย")]
        public string GymRoom { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "บันไดหนีไฟ")]
        public string FireEscape { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ดับเพลิง")]
        public string FireHydrant { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "สวนหย่อม")]
        public string Park { get; set; }

        [Column(TypeName = "varchar(5)")]
        [Display(Name = "ค่าคะแนนความต่างชั้นมีผลกระทบต่อราคา")]
        public string DiffGradeEffectPric { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        [Display(Name = "ระวางรูปถ่ายทางอากาศชื่อ")]
        public string AerialPhoto { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "หมายเลข")]
        public string AerialPhotoNumber { get; set; }

        [Column(TypeName = "int")]
        [Display(Name = "แผ่นที่")]
        public int? AerialPhotoPageNumber { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        [Display(Name = "ทะเบียนเลขที่")]
        public string RegisterNumber { get; set; }

        [Column(TypeName = "varchar(1)")]
        [Display(Name = "IsHost")]
        public string IsHost { get; set; }

        [Column(TypeName = "varchar(1)")]
        [Display(Name = "SendHost")]
        public string SendHost { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [Display(Name = "สร้างโดย")]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "วันที่บันทึก")]
        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        [Display(Name = "ผู้ทำรายการ")]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "วันที่บันทึก")]
        public DateTime? UpdatedOn { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "จังหวัด")]
        public string Province { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "อำเภอ/เขต")]
        public string District { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "ตำบล/แขวง")]
        public string SubDistrict { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "ProvinceOther")]
        public string ProvinceOther { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "DistrictOther")]
        public string DistrictOther { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "SubDistrictOther")]
        public string SubDistrictOther { get; set; }

    }
}

