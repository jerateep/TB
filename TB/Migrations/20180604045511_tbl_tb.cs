using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TB.Migrations
{
    public partial class tbl_tb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "TBL_MS_AMPUR",
            //    columns: table => new
            //    {
            //        AMPUR_ID = table.Column<string>(nullable: false),
            //        AMPUR_NAME_EN = table.Column<string>(nullable: true),
            //        AMPUR_NAME_TH = table.Column<string>(nullable: true),
            //        CHANGWAT_ID = table.Column<string>(nullable: true),
            //        LATITUDE = table.Column<double>(type: "float", nullable: true),
            //        LONGTITUDE = table.Column<double>(type: "float", nullable: true),
            //        POLYGON = table.Column<string>(type: "text", nullable: true),
            //        STATUS = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TBL_MS_AMPUR", x => x.AMPUR_ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TBL_MS_CHANGWAT",
            //    columns: table => new
            //    {
            //        CHANGWAT_ID = table.Column<string>(nullable: false),
            //        CHANGWAT_NAME_EN = table.Column<string>(nullable: true),
            //        CHANGWAT_NAME_TH = table.Column<string>(nullable: true),
            //        COUNTRY_ID = table.Column<string>(nullable: true),
            //        NHSO_ID = table.Column<string>(nullable: true),
            //        ODPC_ID = table.Column<string>(nullable: true),
            //        STATUS = table.Column<string>(nullable: true),
            //        ZONE = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TBL_MS_CHANGWAT", x => x.CHANGWAT_ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TBL_MS_DEFINE_CODE",
            //    columns: table => new
            //    {
            //        MAJOR = table.Column<string>(nullable: false),
            //        MINOR = table.Column<string>(nullable: false),
            //        CODE1 = table.Column<string>(nullable: true),
            //        DESCRIPTION_EN = table.Column<string>(nullable: true),
            //        DESCRIPTION_TH = table.Column<string>(nullable: true),
            //        FLAG = table.Column<string>(nullable: true),
            //        NHSO_CODE = table.Column<string>(nullable: true),
            //        REMARK = table.Column<string>(nullable: true),
            //        SEQUENCE = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TBL_MS_DEFINE_CODE", x => new { x.MAJOR, x.MINOR });
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TBL_MS_HOSP_CODE",
            //    columns: table => new
            //    {
            //        ORG_ID = table.Column<string>(nullable: false),
            //        ADDR = table.Column<string>(nullable: true),
            //        AMPUR = table.Column<string>(nullable: true),
            //        BED = table.Column<string>(nullable: true),
            //        CHANGWAT = table.Column<string>(nullable: true),
            //        DEPARTMENT = table.Column<string>(nullable: true),
            //        FAX = table.Column<string>(nullable: true),
            //        IS_CULTURE_TREAT = table.Column<string>(nullable: true),
            //        IS_CUL_LIQUID = table.Column<string>(nullable: true),
            //        IS_CUL_SOLID = table.Column<string>(nullable: true),
            //        IS_DST_LIQUID = table.Column<string>(nullable: true),
            //        IS_DST_SOLID = table.Column<string>(nullable: true),
            //        IS_DST_TREAT = table.Column<string>(nullable: true),
            //        IS_MDR_TREAT = table.Column<string>(nullable: true),
            //        IS_MOLECULAR_TREAT = table.Column<string>(nullable: true),
            //        IS_MOL_LPA = table.Column<string>(nullable: true),
            //        IS_MOL_XPERT = table.Column<string>(nullable: true),
            //        IS_NHSO_ORG = table.Column<string>(nullable: true),
            //        IS_OUTOF_TBCM = table.Column<string>(nullable: true),
            //        LATITUDE = table.Column<double>(type: "float", nullable: true),
            //        LOGITUDE = table.Column<double>(type: "float", nullable: true),
            //        MU = table.Column<string>(nullable: true),
            //        NAME_EN = table.Column<string>(nullable: true),
            //        NAME_TH = table.Column<string>(nullable: true),
            //        NHSO_ID = table.Column<string>(nullable: true),
            //        ODPC_ID = table.Column<string>(nullable: true),
            //        ORG_ID_9 = table.Column<string>(nullable: false),
            //        ORG_LEVEL = table.Column<string>(nullable: true),
            //        ORG_TYPE = table.Column<string>(nullable: true),
            //        ORG_TYPE_NHSO = table.Column<string>(nullable: true),
            //        PHO_ID = table.Column<string>(nullable: true),
            //        SSO_ID = table.Column<string>(nullable: true),
            //        STATUS = table.Column<string>(nullable: true),
            //        TAMBON = table.Column<string>(nullable: true),
            //        TEL = table.Column<string>(nullable: true),
            //        hmain_id = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TBL_MS_HOSP_CODE", x => x.ORG_ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TBL_MS_TAMBON",
            //    columns: table => new
            //    {
            //        TAMBON_ID = table.Column<string>(nullable: false),
            //        AMPUR_ID = table.Column<string>(nullable: true),
            //        LATITUDE = table.Column<double>(type: "float", nullable: true),
            //        LONGTITUDE = table.Column<double>(type: "float", nullable: true),
            //        POLYGON = table.Column<string>(type: "text", nullable: true),
            //        STATUS = table.Column<string>(nullable: true),
            //        TAMBON_NAME_EN = table.Column<string>(nullable: true),
            //        TAMBON_NAME_TH = table.Column<string>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TBL_MS_TAMBON", x => x.TAMBON_ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TBL_REQUEST_USER",
            //    columns: table => new
            //    {
            //        REQUEST_ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        CID = table.Column<string>(nullable: true),
            //        CREATED_DATE = table.Column<DateTime>(nullable: false),
            //        EMAIL = table.Column<string>(nullable: true),
            //        FNAME = table.Column<string>(nullable: true),
            //        LNAME = table.Column<string>(nullable: true),
            //        ORG_ID = table.Column<string>(nullable: true),
            //        PHONE = table.Column<string>(nullable: true),
            //        REGIS_BY = table.Column<string>(nullable: true),
            //        REGIS_DATE = table.Column<string>(nullable: true),
            //        REQUEST_DATE = table.Column<string>(nullable: true),
            //        REQUEST_STATUS = table.Column<string>(nullable: true),
            //        TITLE_ID = table.Column<string>(nullable: true),
            //        UPDATED_DATE = table.Column<DateTime>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TBL_REQUEST_USER", x => x.REQUEST_ID);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "TBL_REQUEST_USER_GROUP",
            //    columns: table => new
            //    {
            //        REQUEST_GROUP_ID = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        GROUP_ID = table.Column<int>(nullable: false),
            //        IS_VALID = table.Column<string>(nullable: true),
            //        REQUEST_ID = table.Column<int>(nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_TBL_REQUEST_USER_GROUP", x => x.REQUEST_GROUP_ID);
            //    });

            migrationBuilder.CreateTable(
                name: "TBL_TB",
                columns: table => new
                {
                    TB_ID = table.Column<decimal>(type: "decimal(18, 0)", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20171108-140051",
                table: "TBL_TB",
                column: "DATE_REGIS");

            migrationBuilder.CreateIndex(
                name: "NonClusteredIndex-20170830-095913",
                table: "TBL_TB",
                columns: new[] { "HOSP_ID", "TBNO", "PATIENT_ID" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBL_MS_AMPUR");

            migrationBuilder.DropTable(
                name: "TBL_MS_CHANGWAT");

            migrationBuilder.DropTable(
                name: "TBL_MS_DEFINE_CODE");

            migrationBuilder.DropTable(
                name: "TBL_MS_HOSP_CODE");

            migrationBuilder.DropTable(
                name: "TBL_MS_TAMBON");

            migrationBuilder.DropTable(
                name: "TBL_REQUEST_USER");

            migrationBuilder.DropTable(
                name: "TBL_REQUEST_USER_GROUP");

            migrationBuilder.DropTable(
                name: "TBL_TB");
        }
    }
}
