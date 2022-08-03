using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAPP.Models
{
    public class LOSDATCollatApprValue
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long ValueD { get; set; }

        [Required]
        [Column(TypeName = "bigint")]
        public long CollatID { get; set; }

        [Column(TypeName = "bigint")]
        public long ApprID { get; set; }

        [Column(TypeName = "varchar(1)")]
        public string AssessBy { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "เนื้อที่ประเมินหลักประกัน(ตารางวา)")]
        public decimal? AreaOfCollatAssess { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ราคาประเมินที่ดินต่อตารางวา(บาท)")]
        public decimal? LandPriceAssess { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ราคาประเมินอาคารเดิม(บาท)")]
        public decimal? AVOfOrigBuilding { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ราคาปลูกสร้าง/ต่อเติม/ซ่อมแซม(บาท)")]
        public decimal? PriceBuildingRevRepair { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ราคารวมหลักประกัน(บาท)")]
        public decimal? TotPriceCollat { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ราคารับเป็นหลักประกัน(บาท)")]
        public decimal? CollatPrice { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [Display(Name = "บริษัทประเมิน")]
        public string AssessCompany { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "สาเหตุงานล่าช้า")]
        public string DelayCause { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "อื่นๆ")]
        public string Other { get; set; }

        [Column(TypeName = "nvarchar(40)")]
        [Display(Name = "รหัสพนักงาน")]
        public string BankEmpID { get; set; }

        [Column(TypeName = "nvarchar(80)")]
        [Display(Name = "รหัสพนักงานธนาคาร/ชื่อพนักงาน")]
        public string BankEmpName { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [DisplayFormat(DataFormatString = "{0:N5}", ApplyFormatInEditMode = true)]
        [Display(Name = "เนื้อที่ห้องชุด(ตารางเมตร)")]
        public decimal? LivSpace { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ราคาประเมินต่อตารางเมตร(บาท)")]
        public decimal? ApprValue { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ราคาประเมินสิทธิการเช่าที่ดิน/ตารางวา(บาท)")]
        public decimal? AVOfLandLease { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ราคาประเมินสิทธิการเช่าอาคาร(บาท)")]
        public decimal? AVOfBuildingLease { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ราคารวมที่ดินสิทธิการเข่า(บาท)")]
        public decimal? TotValueLeaseLand { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ราคารวมสิทธิการเช่าอาคาร(บาท)")]
        public decimal? TotValueLeaseBuilding { get; set; }

        [Column(TypeName = "decimal(19,4)")]
        [Display(Name = "ราคารับเป็นหลักประกัน(บาท)")]
        public decimal? NetValue { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "วันที่รับงาน")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateReceive { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "วันที่ติดต่อ")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateContact { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "วันที่สำรวจ")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateSurvey { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "วันที่ประเมิน")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateAssess { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "วันที่ประเมิน")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateSubmission { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "วันที่บันทึก")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateRecord { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "วันที่ขอแก้ไข")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateRequest { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "วันที่บันทึกการแก้ไข")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateRequestEdit { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "การรับรองราคา(ตั้งแต่ 3 ล้าน)")]
        public string ReviewAV3M { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "เหตุผล")]
        public string ReviewAV3MRem { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "การกลั่นกรอง")]
        public string ReviewAVLT3M { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "เหตุผล")]
        public string ReviewAVLT3MRem { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "การทบทวนราคา")]
        public string AppealCase { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "เหตุผล")]
        public string AppealCaseRem { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        [Display(Name = "การสุ่มตัวอย่าง")]
        public string SamplingCase { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "เหตุผล")]
        public string SamplingCaseRem { get; set; }

        [Column(TypeName = "datetime2")]
        [Display(Name = "วันที่รับรองราคา")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? ReviewDate { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "เหตุผล")]
        public string ReviewRem { get; set; }

        [Column(TypeName = "nvarchar(500)")]
        [Display(Name = "อื่นๆ")]
        public string ReviewOther { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string CreatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string UpdatedBy { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? UpdatedOn { get; set; }

    }
}
