using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAPP.Migrations
{
    public partial class UpdateDB2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AVOfBuildingLease",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AVOfLandLease",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AVOfOrigBuilding",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppealCase",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AppealCaseRem",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ApprValue",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "AreaOfCollatAssess",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssessBy",
                table: "tblLOSDATCollatApprValue",
                type: "varchar(1)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssessCompany",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(50)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankEmpID",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(40)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankEmpName",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(80)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "CollatPrice",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(30)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "tblLOSDATCollatApprValue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateAssess",
                table: "tblLOSDATCollatApprValue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateContact",
                table: "tblLOSDATCollatApprValue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateReceive",
                table: "tblLOSDATCollatApprValue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRecord",
                table: "tblLOSDATCollatApprValue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRequest",
                table: "tblLOSDATCollatApprValue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateRequestEdit",
                table: "tblLOSDATCollatApprValue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateSubmission",
                table: "tblLOSDATCollatApprValue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateSurvey",
                table: "tblLOSDATCollatApprValue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DelayCause",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LandPriceAssess",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "LivSpace",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "NetValue",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Other",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceBuildingRevRepair",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewAV3M",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewAV3MRem",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewAVLT3M",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewAVLT3MRem",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReviewDate",
                table: "tblLOSDATCollatApprValue",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewOther",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewRem",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SamplingCase",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SamplingCaseRem",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(500)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotPriceCollat",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotValueLeaseBuilding",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotValueLeaseLand",
                table: "tblLOSDATCollatApprValue",
                type: "decimal(19,4)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "tblLOSDATCollatApprValue",
                type: "nvarchar(30)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedOn",
                table: "tblLOSDATCollatApprValue",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AVOfBuildingLease",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "AVOfLandLease",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "AVOfOrigBuilding",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "AppealCase",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "AppealCaseRem",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "ApprValue",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "AreaOfCollatAssess",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "AssessBy",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "AssessCompany",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "BankEmpID",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "BankEmpName",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "CollatPrice",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "DateAssess",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "DateContact",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "DateReceive",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "DateRecord",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "DateRequest",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "DateRequestEdit",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "DateSubmission",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "DateSurvey",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "DelayCause",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "LandPriceAssess",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "LivSpace",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "NetValue",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "Other",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "PriceBuildingRevRepair",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "ReviewAV3M",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "ReviewAV3MRem",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "ReviewAVLT3M",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "ReviewAVLT3MRem",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "ReviewDate",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "ReviewOther",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "ReviewRem",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "SamplingCase",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "SamplingCaseRem",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "TotPriceCollat",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "TotValueLeaseBuilding",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "TotValueLeaseLand",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "tblLOSDATCollatApprValue");

            migrationBuilder.DropColumn(
                name: "UpdatedOn",
                table: "tblLOSDATCollatApprValue");
        }
    }
}
