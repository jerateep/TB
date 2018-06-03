using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TB.Migrations
{
    public partial class TBL_TB_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_TB",
                columns: table => new
                {
                    TB_ID = table.Column<decimal>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ABROAD_COUNTRY = table.Column<string>(nullable: true),
                    ABROAD_OTHER = table.Column<string>(nullable: true),
                    ADDR = table.Column<string>(nullable: true),
                    ADMIT_DATE = table.Column<string>(nullable: true),
                    ADMIT_TYPE = table.Column<string>(nullable: true),
                    AFB0_DATE = table.Column<string>(nullable: true),
                    AFB0_LABNO = table.Column<string>(nullable: true),
                    AFB0_RESULT = table.Column<string>(nullable: true),
                    AFB_DC = table.Column<string>(nullable: true),
                    AGE_M = table.Column<int>(nullable: false),
                    AGE_Y = table.Column<int>(nullable: false),
                    AN = table.Column<string>(nullable: true),
                    ARV_DATE = table.Column<string>(nullable: true),
                    ARV_DRUG = table.Column<string>(nullable: true),
                    BCG = table.Column<string>(nullable: true),
                    CA = table.Column<string>(nullable: true),
                    CD4_DATE_1 = table.Column<string>(nullable: true),
                    CD4_DATE_2 = table.Column<string>(nullable: true),
                    CD4_RESULT_1 = table.Column<string>(nullable: true),
                    CD4_RESULT_2 = table.Column<string>(nullable: true),
                    CHEST_PAIN_DAY = table.Column<string>(nullable: true),
                    CKD = table.Column<string>(nullable: true),
                    CLASSIFY = table.Column<string>(nullable: true),
                    CLASSIFY_EP_ID = table.Column<string>(nullable: true),
                    CLASSIFY_EP_OTH = table.Column<string>(nullable: true),
                    COMBINE_DRUG = table.Column<string>(nullable: true),
                    COPD = table.Column<string>(nullable: true),
                    COUGH_DAY = table.Column<string>(nullable: true),
                    CREATE_BY = table.Column<int>(nullable: false),
                    CREATE_DATE = table.Column<DateTime>(nullable: false),
                    DATE_REGIS = table.Column<string>(nullable: true),
                    DISCHARGE_DATE = table.Column<string>(nullable: true),
                    DM = table.Column<string>(nullable: true),
                    DOT_BY = table.Column<string>(nullable: true),
                    DRUG = table.Column<string>(nullable: true),
                    DRUGREACT = table.Column<string>(nullable: true),
                    DRUG_TYPE = table.Column<string>(nullable: true),
                    FEVER_DAY = table.Column<string>(nullable: true),
                    HISTORY_TREATED = table.Column<string>(nullable: true),
                    HISTORY_TREATED_RESULT = table.Column<string>(nullable: true),
                    HIV_ADVISE = table.Column<string>(nullable: true),
                    HIV_DIAG = table.Column<string>(nullable: true),
                    HIV_DIAG_DATE = table.Column<string>(nullable: true),
                    HIV_MEET = table.Column<string>(nullable: true),
                    HIV_RESULT = table.Column<string>(nullable: true),
                    HN = table.Column<string>(nullable: true),
                    HOME_TYPE = table.Column<string>(nullable: true),
                    HOSP_ID = table.Column<string>(nullable: false),
                    HT = table.Column<string>(nullable: true),
                    ICD10_ID = table.Column<string>(nullable: true),
                    INDEX_TB_ID = table.Column<string>(nullable: true),
                    INSCL_ID = table.Column<string>(nullable: true),
                    INTERIM_DATE = table.Column<string>(nullable: true),
                    INTERIM_DEATH_CAUSE = table.Column<string>(nullable: true),
                    INTERIM_DEATH_DATE = table.Column<string>(nullable: true),
                    INTERIM_REFER_DATE = table.Column<string>(nullable: true),
                    INTERIM_REFER_HOSP_ID = table.Column<string>(nullable: true),
                    INTERIM_REMARK = table.Column<string>(nullable: true),
                    INTERIM_RESULT = table.Column<string>(nullable: true),
                    IS_HEALTH_OFFICER = table.Column<string>(nullable: true),
                    IS_MDR = table.Column<string>(nullable: true),
                    IS_PRISONER = table.Column<string>(nullable: true),
                    IS_SOCIAL_FROM_DLA = table.Column<string>(nullable: true),
                    IS_SOCIAL_FROM_HOSPITAL = table.Column<string>(nullable: true),
                    IS_SOCIAL_FROM_OTHER = table.Column<string>(nullable: true),
                    IS_SOCIAL_FROM_RED_CROSS = table.Column<string>(nullable: true),
                    IS_SOCIAL_FROM_SOCIETY = table.Column<string>(nullable: true),
                    IS_SOCIAL_GET = table.Column<string>(nullable: true),
                    IS_SOCIAL_SEND = table.Column<string>(nullable: true),
                    IS_SOCIAL_TYPE_BENEFIT = table.Column<string>(nullable: true),
                    IS_SOCIAL_TYPE_OTHER = table.Column<string>(nullable: true),
                    IS_SOCIAL_TYPE_STIPENT = table.Column<string>(nullable: true),
                    IS_SOCIAL_TYPE_VISIT = table.Column<string>(nullable: true),
                    IS_TRANSFER_ABROAD = table.Column<string>(nullable: true),
                    LD = table.Column<string>(nullable: true),
                    MU = table.Column<string>(nullable: true),
                    NOADMIT_CAUSE = table.Column<string>(nullable: true),
                    NOARV_CAUSE = table.Column<string>(nullable: true),
                    OCC_ID = table.Column<string>(nullable: true),
                    OI_PREVENT = table.Column<string>(nullable: true),
                    OLD_TB_ID = table.Column<string>(nullable: true),
                    OTHER_DAY = table.Column<string>(nullable: true),
                    OTHER_DISEASE = table.Column<string>(nullable: true),
                    OTHER_SYMPTOM = table.Column<string>(nullable: true),
                    OTHER_TXT = table.Column<string>(nullable: true),
                    PATIENT_ID = table.Column<decimal>(nullable: false),
                    PMDT_INTERIM_DATE = table.Column<string>(nullable: true),
                    PMDT_INTERIM_DEATH_CAUSE = table.Column<string>(nullable: true),
                    PMDT_INTERIM_DEATH_DATE = table.Column<string>(nullable: true),
                    PMDT_INTERIM_REFER_DATE = table.Column<string>(nullable: true),
                    PMDT_INTERIM_REFER_HOSP_ID = table.Column<string>(nullable: true),
                    PMDT_INTERIM_REMARK = table.Column<string>(nullable: true),
                    PMDT_INTERIM_RESULT = table.Column<string>(nullable: true),
                    PMDT_REGIS_DATE = table.Column<string>(nullable: true),
                    PMDT_REGIS_TYPE = table.Column<string>(nullable: true),
                    PMDT_RESULT = table.Column<string>(nullable: true),
                    PMDT_RX_DATE = table.Column<string>(nullable: true),
                    PMDT_RX_DEATH_CAUSE = table.Column<string>(nullable: true),
                    PMDT_RX_DEATH_DATE = table.Column<string>(nullable: true),
                    PMDT_RX_REFER_DATE = table.Column<string>(nullable: true),
                    PMDT_RX_REFER_HOSP_ID = table.Column<string>(nullable: true),
                    PMDT_RX_REMARK = table.Column<string>(nullable: true),
                    PMDT_RX_RESULT = table.Column<string>(nullable: true),
                    REGIMEN = table.Column<string>(nullable: true),
                    REVER_CAT_TYPE = table.Column<string>(nullable: true),
                    REVER_CAUSE = table.Column<string>(nullable: true),
                    RISK_TB_GROUP_ID = table.Column<string>(nullable: true),
                    RISK_TB_TYPE_ID = table.Column<string>(nullable: true),
                    RX_DATE = table.Column<string>(nullable: true),
                    RX_DEATH_CAUSE = table.Column<string>(nullable: true),
                    RX_DEATH_DATE = table.Column<string>(nullable: true),
                    RX_NEW_DIAG = table.Column<string>(nullable: true),
                    RX_REFER_DATE = table.Column<string>(nullable: true),
                    RX_REFER_HOSP_ID = table.Column<string>(nullable: true),
                    RX_REMARK = table.Column<string>(nullable: true),
                    RX_RESULT = table.Column<string>(nullable: true),
                    SITE_ID = table.Column<string>(nullable: true),
                    SOCIAL_FROM_OTHER = table.Column<string>(nullable: true),
                    SOCIAL_TYPE_OTHER = table.Column<string>(nullable: true),
                    SPACEMEN_ID = table.Column<string>(nullable: true),
                    SPACEMEN_OTH = table.Column<string>(nullable: true),
                    SPACEMEN_RESULT = table.Column<string>(nullable: true),
                    SPUTUM_BLOOD_DAY = table.Column<string>(nullable: true),
                    SPUTUM_COLOR = table.Column<string>(nullable: true),
                    SPUTUM_COLOR_DAY = table.Column<string>(nullable: true),
                    START_DATE = table.Column<string>(nullable: true),
                    TAF_TYPE_ID = table.Column<string>(nullable: true),
                    TBNO = table.Column<string>(nullable: false),
                    TB_TYPE = table.Column<string>(nullable: true),
                    TIRED_DAY = table.Column<string>(nullable: true),
                    TI_HOSP_ID = table.Column<string>(nullable: true),
                    TYPE_ID = table.Column<string>(nullable: true),
                    UPDATE_BY = table.Column<int>(nullable: false),
                    UPDATE_DATE = table.Column<DateTime>(nullable: false),
                    WEIGHT = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_TB", x => x.TB_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_MS_DEFINE_CODE");

            migrationBuilder.DropTable(
                name: "TBL_MS_HOSP_CODE");

            migrationBuilder.DropTable(
                name: "TBL_REQUEST_USER");

            migrationBuilder.DropTable(
                name: "TBL_REQUEST_USER_GROUP");

            migrationBuilder.DropTable(
                name: "TBL_TB");

            migrationBuilder.AlterColumn<string>(
                name: "POLYGON",
                table: "TBL_MS_TAMBON",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LONGTITUDE",
                table: "TBL_MS_TAMBON",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LATITUDE",
                table: "TBL_MS_TAMBON",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "POLYGON",
                table: "TBL_MS_AMPUR",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LONGTITUDE",
                table: "TBL_MS_AMPUR",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "LATITUDE",
                table: "TBL_MS_AMPUR",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);
        }
    }
}
