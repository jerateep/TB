using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace TB.Migrations
{
    public partial class hosp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBL_MS_DEFINE_CODE",
                columns: table => new
                {
                    MAJOR = table.Column<string>(nullable: false),
                    MINOR = table.Column<string>(nullable: false),
                    CODE1 = table.Column<string>(nullable: true),
                    DESCRIPTION_EN = table.Column<string>(nullable: true),
                    DESCRIPTION_TH = table.Column<string>(nullable: true),
                    FLAG = table.Column<string>(nullable: true),
                    NHSO_CODE = table.Column<string>(nullable: true),
                    REMARK = table.Column<string>(nullable: true),
                    SEQUENCE = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_MS_DEFINE_CODE", x => new { x.MAJOR, x.MINOR });
                });

            migrationBuilder.CreateTable(
                name: "TBL_MS_HOSP_CODE",
                columns: table => new
                {
                    ORG_ID = table.Column<string>(nullable: false),
                    ADDR = table.Column<string>(nullable: true),
                    AMPUR = table.Column<string>(nullable: true),
                    BED = table.Column<string>(nullable: true),
                    CHANGWAT = table.Column<string>(nullable: true),
                    DEPARTMENT = table.Column<string>(nullable: true),
                    FAX = table.Column<string>(nullable: true),
                    IS_CULTURE_TREAT = table.Column<string>(nullable: true),
                    IS_CUL_LIQUID = table.Column<string>(nullable: true),
                    IS_CUL_SOLID = table.Column<string>(nullable: true),
                    IS_DST_LIQUID = table.Column<string>(nullable: true),
                    IS_DST_SOLID = table.Column<string>(nullable: true),
                    IS_DST_TREAT = table.Column<string>(nullable: true),
                    IS_MDR_TREAT = table.Column<string>(nullable: true),
                    IS_MOLECULAR_TREAT = table.Column<string>(nullable: true),
                    IS_MOL_LPA = table.Column<string>(nullable: true),
                    IS_MOL_XPERT = table.Column<string>(nullable: true),
                    IS_NHSO_ORG = table.Column<string>(nullable: true),
                    IS_OUTOF_TBCM = table.Column<string>(nullable: true),
                    MU = table.Column<string>(nullable: true),
                    NAME_EN = table.Column<string>(nullable: true),
                    NAME_TH = table.Column<string>(nullable: true),
                    NHSO_ID = table.Column<string>(nullable: true),
                    ODPC_ID = table.Column<string>(nullable: true),
                    ORG_ID_9 = table.Column<string>(nullable: true),
                    ORG_LEVEL = table.Column<string>(nullable: true),
                    ORG_TYPE = table.Column<string>(nullable: true),
                    ORG_TYPE_NHSO = table.Column<string>(nullable: true),
                    PHO_ID = table.Column<string>(nullable: true),
                    SSO_ID = table.Column<string>(nullable: true),
                    STATUS = table.Column<string>(nullable: true),
                    TAMBON = table.Column<string>(nullable: true),
                    TEL = table.Column<string>(nullable: true),
                    hmain_id = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_MS_HOSP_CODE", x => x.ORG_ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_REQUEST_USER",
                columns: table => new
                {
                    REQUEST_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CID = table.Column<string>(nullable: true),
                    CREATED_DATE = table.Column<DateTime>(nullable: false),
                    EMAIL = table.Column<string>(nullable: true),
                    FNAME = table.Column<string>(nullable: true),
                    LNAME = table.Column<string>(nullable: true),
                    ORG_ID = table.Column<string>(nullable: true),
                    PHONE = table.Column<string>(nullable: true),
                    REGIS_BY = table.Column<string>(nullable: true),
                    REGIS_DATE = table.Column<string>(nullable: true),
                    REQUEST_DATE = table.Column<string>(nullable: true),
                    REQUEST_STATUS = table.Column<string>(nullable: true),
                    TITLE_ID = table.Column<string>(nullable: true),
                    UPDATED_DATE = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_REQUEST_USER", x => x.REQUEST_ID);
                });

            migrationBuilder.CreateTable(
                name: "TBL_REQUEST_USER_GROUP",
                columns: table => new
                {
                    REQUEST_GROUP_ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GROUP_ID = table.Column<int>(nullable: false),
                    IS_VALID = table.Column<string>(nullable: true),
                    REQUEST_ID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBL_REQUEST_USER_GROUP", x => x.REQUEST_GROUP_ID);
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
        }
    }
}
