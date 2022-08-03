using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPP.Models
{
    public class LOSDATCollatAppraisal_L
    {
        [Key]

        [Display(Name = "รหัสประเมิน")]
        public long ApprID { get; set; }

        [Required]

        [Display(Name = "เลขที่หลักประกัน")]
        public long CollatID { get; set; }

        [Required(ErrorMessageResourceName = "เลขที่เอกสารสิทธิ์ จำเป็นต้องระบุ")]

        [Display(Name = "เลขที่เอกสารสิทธิ์")]
        public string DocumentNo { get; set; }

        [Required(ErrorMessageResourceName = "เลขที่ดิน จำเป็นต้องระบุ")]

        [Display(Name = "เลขที่ดิน")]
        public string LandNo { get; set; }


        [Display(Name = "เล่มที่")]
        public string BookNo { get; set; }


        [Display(Name = "หน้าที่")]
        public string PageNo { get; set; }


        [Display(Name = "หน้าสำรวจ")]
        public string SurveySurface { get; set; }


        [Display(Name = "ระวาง")]
        public string Liable { get; set; }


        [Display(Name = "เนื้อที่ดิน(ตารางวา)")]
        public decimal? LandSizeSqM { get; set; }


        [Display(Name = "ตำแหน่งที่ดิน")]
        public string LandPosition { get; set; }


        [Display(Name = "ตรวจจาก")]
        public string CheckBy { get; set; }


        [Display(Name = "อื่นๆ")]
        public string Other { get; set; }


        [Required(ErrorMessageResourceName = "ตั้งอยู่บนถนน จำเป็นต้องระบุ")]
        [Display(Name = "ตั้งอยู่บนถนน")]
        public string Street { get; set; }


        [Display(Name = "แยกเข้าซอย")]
        public string SplitEntry { get; set; }


        [Display(Name = "ระยะทาง(เมตร)")]
        public decimal? Distance { get; set; }


        [Display(Name = "สภาพที่ดิน")]
        public string LandCondition { get; set; }


        [Display(Name = "ระดับดินถมเฉลี่ย(เซนติเมตร)")]
        public decimal? AvgLandReclamation { get; set; }


        [Required(ErrorMessageResourceName = "ตำแหน่งพิกัดละติจูด จำเป็นต้องระบุ")]
        [Display(Name = "ตำแหน่งพิกัดละติจูด")]
        public string PositionLatitude { get; set; }


        [Required(ErrorMessageResourceName = "ตำแหน่งพิกัดลองจิจูด จำเป็นต้องระบุ")]
        [Display(Name = "ตำแหน่งพิกัดลองจิจูด")]
        public string PositionLongtitude { get; set; }


        [Display(Name = "สิ่งปลูกสร้าง")]
        public string WithBuilding { get; set; }


        [Display(Name = "กู้ประเภทอื่นๆ")]
        public string OtherLoan { get; set; }


        [Display(Name = "เนื้อที่บ่อน้ำ(ตารางวา)")]
        public decimal? PondAreaPct { get; set; }


        [Display(Name = "ความลึกโดยประมาณ(เมตร)")]
        public decimal? PondDepthEstimation { get; set; }


        [Display(Name = "ถนนผ่านหน้าที่ดิน")]
        public string RoadToLand { get; set; }


        [Display(Name = "ลักษณะผิวจราจร")]
        public string RoadSurface { get; set; }


        [Display(Name = "ผิวจราจรกว้าง(เมตร)")]
        public decimal? RoadSurfaceWidth { get; set; }


        [Display(Name = "เขตทาง(เมตร)")]
        public decimal? PedestrianWay { get; set; }


        [Display(Name = "รถยนต์เข้า-ออก")]
        public string CarAccess { get; set; }


        [Display(Name = "ทางเข้า-ออก")]
        public string EntranceExit { get; set; }


        [Display(Name = "ต้องมีการปรับปรุงสภาพทาง")]
        public string EntranceExitCondition { get; set; }


        [Display(Name = "ลักษณะที่ดิน")]
        public string Allocation { get; set; }


        [Display(Name = "ประเมินราคา")]
        public string Appraised { get; set; }


        [Display(Name = "หมายเหตุ")]
        public string AppraisedNote { get; set; }


        [Display(Name = "เนื้อที่ถูกรุกล้ำ/ใช้เพื่อบุคคลอื่น")]
        public decimal? SpaceEncroached { get; set; }


        [Display(Name = "ไฟฟ้าถาวร")]
        public string ElectricitySupply { get; set; }


        [Display(Name = "น้ำประปา/น้ำบาดาล")]
        public string WaterSupply { get; set; }


        [Display(Name = "บ่อพัก / ท่อระบายน้ำ")]
        public string PondDrain { get; set; }


        [Display(Name = "สาธารณูปโภคอื่นๆ")]
        public string OtherUtility { get; set; }


        [Display(Name = "อยู่ในระวางเวนคืน")]
        public string IsExpropriation { get; set; }


        [Display(Name = "อยู่ในแนวเวนคืน ตาม พรฎ/พรบ")]
        public string InLineExpropriated { get; set; }


        [Display(Name = "จุดสิ้นสุดสาธารณูปโภคไฟฟ้าถาวรอยู่ห่างหลักประกันไปตามแนวถนน/ซอย  ระยะทางประมาณ                  เมตร(กรณีเกิน 100 เมตร)")]
        public string ElectricityOver100M { get; set; }


        [Display(Name = "ElectricityOver100MNote")]
        public string ElectricityOver100MNote { get; set; }


        [Display(Name = "อยู่ในแนวสายไฟฟ้าแรงสูง")]
        public string HighVoltageLine { get; set; }


        [Display(Name = "อยู่ในเขตป่าฯ / อยู่ในเขต สปก. / อุทยานฯ")]
        public string LocatedForestAgriPark { get; set; }


        [Display(Name = "รูปร่างลักษณะที่ดินหลักประกันไม่สามารถนำรถยนต์เข้าไปในที่ดินได้")]
        public string CarNoAccess { get; set; }


        [Display(Name = "เงื่อนไขเพิ่มเติม")]
        public string OtherCondition { get; set; }


        public string OtherConditionNote { get; set; }

        [Display(Name = "สโมสร")]
        public string Club { get; set; }


        [Display(Name = "ระบบรักษาความปลอดภัย")]
        public string SecuritySystem { get; set; }


        [Display(Name = "สนามกีฬากลางแจ้ง")]
        public string Stadium { get; set; }


        [Display(Name = "ระบบ Key card")]
        public string KeyCardSystem { get; set; }


        [Display(Name = "โรงเรียนอนุบาล")]
        public string Kindergarden { get; set; }


        [Display(Name = "ระบบการทิ้งและกำจัดขยะ")]
        public string WasteDisposalSystem { get; set; }


        [Display(Name = "การพัฒนาในพื้นที่")]
        public string AnyDevelopment { get; set; }


        [Display(Name = "ข้อกำหนดผังเมือง")]
        public string TownPlanReq { get; set; }


        [Display(Name = "ลักษณะทางกายภาพ/ รูปแปลง")]
        public string PhysicalReputation { get; set; }


        [Display(Name = "ตำแหน่งที่ตั้ง")]
        public string Location { get; set; }


        [Display(Name = "ชื่อเสียงโครงการ (ผู้ประกอบการ)")]
        public string ProjReputation { get; set; }


        [Display(Name = "ย่านที่อยู่อาศัยหนาแน่นมาก")]
        public string EnvVeryDensityResArea { get; set; }


        [Display(Name = "ย่านที่อยู่อาศัยหนาแน่นปานกลาง")]
        public string EnvMediumDensityResArea { get; set; }


        [Display(Name = "ย่านที่อยู่อาศัยหนาแน่นน้อย")]
        public string EnvLessDensityResArea { get; set; }


        [Display(Name = "ย่านที่อยู่อาศัยประปราย ชนบท")]
        public string EnvRusticResidentialNeighborhood { get; set; }


        [Display(Name = "ที่ดินรกร้าง เปล่าห่างไกลชุมชน")]
        public string EnvNeglectedLand { get; set; }


        [Display(Name = "ย่านพานิชยกรรม")]
        public string EnvCommercialDistrict { get; set; }


        [Display(Name = "ย่านอุตสาหกรรม")]
        public string EnvIndustrialDistrict { get; set; }


        [Display(Name = "ย่านเกษตรกรรม")]
        public string EnvAgriculturalDistrict { get; set; }


        [Display(Name = "ย่านธุรกิจการค้าใจกลางเมือง")]
        public string EnvBizCommDistrictInCity { get; set; }


        [Display(Name = "ย่านที่อยู่อาศัยสลับพานิชยกรรม")]
        public string EnvResidentialSwitchCommercial { get; set; }


        [Display(Name = "บ่อน้ำ")]
        public string PollWell { get; set; }


        [Display(Name = "ไฟฟ้าแรงสูง")]
        public string PollHighVoltage { get; set; }


        [Display(Name = "บ่อขยะ")]
        public string PollJunkyard { get; set; }


        [Display(Name = "บ่อบำบัด")]
        public string PollWasteWaterTreatPlant { get; set; }


        [Display(Name = "ที่ทิ้งของเสีย")]
        public string PollWasteDisposalSite { get; set; }


        [Display(Name = "โรงฆ่าสัตว์")]
        public string PollSlaughterhouse { get; set; }


        [Display(Name = "เขตป่าไม้")]
        public string PollForest { get; set; }


        [Display(Name = "อื่นๆ")]
        public string PollOther { get; set; }


        [Display(Name = "มีการซื้อขายเปลี่ยนมือปริมาณมาก")]
        public string LiqVeryLargeTradingVol { get; set; }


        [Display(Name = "มีการซื้อขายเปลี่ยนมือปริมาณปานกลาง")]
        public string LiqMediumTradingVol { get; set; }


        [Display(Name = "มีการซื้อขายเปลี่ยนมือปริมาณน้อย")]
        public string LiqLessTradingVol { get; set; }


        [Display(Name = "ไม่มีการซื้อขายเปลี่ยนมือ")]
        public string LiqNoTrading { get; set; }


        [Display(Name = "ไม่ระบุ")]
        public string LiqNotStated { get; set; }


        [Display(Name = "ทิศที่ตั้งหลักประกัน")]
        public string CollatFaceDirection { get; set; }


        [Display(Name = "หมายเหตุ")]
        public string Remark { get; set; }


        [Display(Name = "ไฟฟ้าถนน")]
        public String RoadWithElecCab { get; set; }


        [Display(Name = "สาธารณูปโภค")]
        public String PublicUtility { get; set; }


        [Display(Name = "ข้อจำกัดเงื่อนไข")]
        public String ConstraintCondition { get; set; }


        [Display(Name = "สภาพแวดล้อม")]
        public String Environment { get; set; }


        [Display(Name = "มลภาวะ")]
        public String Pollution { get; set; }


        [Display(Name = "สภาพคล่อง")]
        public String Liquidity { get; set; }


        [Display(Name = "ระวางรูปถ่ายทางอากาศชื่อ")]
        public string AerialPhoto { get; set; }


        [Display(Name = "หมายเลข")]
        public string AerialPhotoNumber { get; set; }


        [Display(Name = "แผ่นที่")]
        public int? AerialPhotoPageNumber { get; set; }


        [Display(Name = "ทะเบียนเลขที่")]
        public string RegisterNumber { get; set; }


        public string RoyalDecreeAct { get; set; }
    }
}
