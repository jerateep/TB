﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;
using TB.Models;

namespace TB.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20180604045511_tbl_tb")]
    partial class tbl_tb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TB.Models.TBL_MS_AMPUR", b =>
                {
                    b.Property<string>("AMPUR_ID");

                    b.Property<string>("AMPUR_NAME_EN");

                    b.Property<string>("AMPUR_NAME_TH");

                    b.Property<string>("CHANGWAT_ID");

                    b.Property<double?>("LATITUDE")
                        .HasColumnType("float");

                    b.Property<double?>("LONGTITUDE")
                        .HasColumnType("float");

                    b.Property<string>("POLYGON")
                        .HasColumnType("text");

                    b.Property<string>("STATUS");

                    b.HasKey("AMPUR_ID");

                    b.ToTable("TBL_MS_AMPUR");
                });

            modelBuilder.Entity("TB.Models.TBL_MS_CHANGWAT", b =>
                {
                    b.Property<string>("CHANGWAT_ID");

                    b.Property<string>("CHANGWAT_NAME_EN");

                    b.Property<string>("CHANGWAT_NAME_TH");

                    b.Property<string>("COUNTRY_ID");

                    b.Property<string>("NHSO_ID");

                    b.Property<string>("ODPC_ID");

                    b.Property<string>("STATUS");

                    b.Property<string>("ZONE");

                    b.HasKey("CHANGWAT_ID");

                    b.ToTable("TBL_MS_CHANGWAT");
                });

            modelBuilder.Entity("TB.Models.TBL_MS_DEFINE_CODE", b =>
                {
                    b.Property<string>("MAJOR");

                    b.Property<string>("MINOR");

                    b.Property<string>("CODE1");

                    b.Property<string>("DESCRIPTION_EN");

                    b.Property<string>("DESCRIPTION_TH");

                    b.Property<string>("FLAG");

                    b.Property<string>("NHSO_CODE");

                    b.Property<string>("REMARK");

                    b.Property<string>("SEQUENCE");

                    b.HasKey("MAJOR", "MINOR");

                    b.ToTable("TBL_MS_DEFINE_CODE");
                });

            modelBuilder.Entity("TB.Models.TBL_MS_HOSP_CODE", b =>
                {
                    b.Property<string>("ORG_ID");

                    b.Property<string>("ADDR");

                    b.Property<string>("AMPUR");

                    b.Property<string>("BED");

                    b.Property<string>("CHANGWAT");

                    b.Property<string>("DEPARTMENT");

                    b.Property<string>("FAX");

                    b.Property<string>("IS_CULTURE_TREAT");

                    b.Property<string>("IS_CUL_LIQUID");

                    b.Property<string>("IS_CUL_SOLID");

                    b.Property<string>("IS_DST_LIQUID");

                    b.Property<string>("IS_DST_SOLID");

                    b.Property<string>("IS_DST_TREAT");

                    b.Property<string>("IS_MDR_TREAT");

                    b.Property<string>("IS_MOLECULAR_TREAT");

                    b.Property<string>("IS_MOL_LPA");

                    b.Property<string>("IS_MOL_XPERT");

                    b.Property<string>("IS_NHSO_ORG");

                    b.Property<string>("IS_OUTOF_TBCM");

                    b.Property<double?>("LATITUDE")
                        .HasColumnType("float");

                    b.Property<double?>("LOGITUDE")
                        .HasColumnType("float");

                    b.Property<string>("MU");

                    b.Property<string>("NAME_EN");

                    b.Property<string>("NAME_TH");

                    b.Property<string>("NHSO_ID");

                    b.Property<string>("ODPC_ID");

                    b.Property<string>("ORG_ID_9")
                        .IsRequired();

                    b.Property<string>("ORG_LEVEL");

                    b.Property<string>("ORG_TYPE");

                    b.Property<string>("ORG_TYPE_NHSO");

                    b.Property<string>("PHO_ID");

                    b.Property<string>("SSO_ID");

                    b.Property<string>("STATUS");

                    b.Property<string>("TAMBON");

                    b.Property<string>("TEL");

                    b.Property<string>("hmain_id");

                    b.HasKey("ORG_ID");

                    b.ToTable("TBL_MS_HOSP_CODE");
                });

            modelBuilder.Entity("TB.Models.TBL_MS_TAMBON", b =>
                {
                    b.Property<string>("TAMBON_ID");

                    b.Property<string>("AMPUR_ID");

                    b.Property<double?>("LATITUDE")
                        .HasColumnType("float");

                    b.Property<double?>("LONGTITUDE")
                        .HasColumnType("float");

                    b.Property<string>("POLYGON")
                        .HasColumnType("text");

                    b.Property<string>("STATUS");

                    b.Property<string>("TAMBON_NAME_EN");

                    b.Property<string>("TAMBON_NAME_TH");

                    b.HasKey("TAMBON_ID");

                    b.ToTable("TBL_MS_TAMBON");
                });

            modelBuilder.Entity("TB.Models.TBL_REQUEST_USER", b =>
                {
                    b.Property<int>("REQUEST_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CID");

                    b.Property<DateTime>("CREATED_DATE");

                    b.Property<string>("EMAIL");

                    b.Property<string>("FNAME");

                    b.Property<string>("LNAME");

                    b.Property<string>("ORG_ID");

                    b.Property<string>("PHONE");

                    b.Property<string>("REGIS_BY");

                    b.Property<string>("REGIS_DATE");

                    b.Property<string>("REQUEST_DATE");

                    b.Property<string>("REQUEST_STATUS");

                    b.Property<string>("TITLE_ID");

                    b.Property<DateTime>("UPDATED_DATE");

                    b.HasKey("REQUEST_ID");

                    b.ToTable("TBL_REQUEST_USER");
                });

            modelBuilder.Entity("TB.Models.TBL_REQUEST_USER_GROUP", b =>
                {
                    b.Property<int>("REQUEST_GROUP_ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("GROUP_ID");

                    b.Property<string>("IS_VALID");

                    b.Property<int>("REQUEST_ID");

                    b.HasKey("REQUEST_GROUP_ID");

                    b.ToTable("TBL_REQUEST_USER_GROUP");
                });

            modelBuilder.Entity("TB.Models.TBL_TB", b =>
                {
                    b.Property<decimal>("TB_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TB_ID")
                        .HasColumnType("decimal(18, 0)");

                    b.Property<string>("ABROAD_COUNTRY");

                    b.Property<string>("ABROAD_OTHER");

                    b.Property<string>("ADDR");

                    b.Property<string>("ADMIT_DATE");

                    b.Property<string>("ADMIT_TYPE");

                    b.Property<string>("AFB0_DATE");

                    b.Property<string>("AFB0_LABNO");

                    b.Property<string>("AFB0_RESULT");

                    b.Property<string>("AFB_DC");

                    b.Property<int>("AGE_M");

                    b.Property<int>("AGE_Y");

                    b.Property<string>("AN");

                    b.Property<string>("ARV_DATE");

                    b.Property<string>("ARV_DRUG");

                    b.Property<string>("BCG");

                    b.Property<string>("CA");

                    b.Property<string>("CD4_DATE_1");

                    b.Property<string>("CD4_DATE_2");

                    b.Property<string>("CD4_RESULT_1");

                    b.Property<string>("CD4_RESULT_2");

                    b.Property<string>("CHEST_PAIN_DAY");

                    b.Property<string>("CKD");

                    b.Property<string>("CLASSIFY");

                    b.Property<string>("CLASSIFY_EP_ID");

                    b.Property<string>("CLASSIFY_EP_OTH");

                    b.Property<string>("COMBINE_DRUG");

                    b.Property<string>("COPD");

                    b.Property<string>("COUGH_DAY");

                    b.Property<int>("CREATE_BY");

                    b.Property<DateTime>("CREATE_DATE");

                    b.Property<string>("DATE_REGIS");

                    b.Property<string>("DISCHARGE_DATE");

                    b.Property<string>("DM");

                    b.Property<string>("DOT_BY");

                    b.Property<string>("DRUG");

                    b.Property<string>("DRUGREACT");

                    b.Property<string>("DRUG_TYPE");

                    b.Property<string>("FEVER_DAY");

                    b.Property<string>("HISTORY_TREATED");

                    b.Property<string>("HISTORY_TREATED_RESULT");

                    b.Property<string>("HIV_ADVISE");

                    b.Property<string>("HIV_DIAG");

                    b.Property<string>("HIV_DIAG_DATE");

                    b.Property<string>("HIV_MEET");

                    b.Property<string>("HIV_RESULT");

                    b.Property<string>("HN");

                    b.Property<string>("HOME_TYPE");

                    b.Property<string>("HOSP_ID")
                        .IsRequired();

                    b.Property<string>("HT");

                    b.Property<string>("ICD10_ID");

                    b.Property<string>("INDEX_TB_ID");

                    b.Property<string>("INSCL_ID");

                    b.Property<string>("INTERIM_DATE");

                    b.Property<string>("INTERIM_DEATH_CAUSE");

                    b.Property<string>("INTERIM_DEATH_DATE");

                    b.Property<string>("INTERIM_REFER_DATE");

                    b.Property<string>("INTERIM_REFER_HOSP_ID");

                    b.Property<string>("INTERIM_REMARK");

                    b.Property<string>("INTERIM_RESULT");

                    b.Property<string>("IS_HEALTH_OFFICER");

                    b.Property<string>("IS_MDR");

                    b.Property<string>("IS_PRISONER");

                    b.Property<string>("IS_SOCIAL_FROM_DLA");

                    b.Property<string>("IS_SOCIAL_FROM_HOSPITAL");

                    b.Property<string>("IS_SOCIAL_FROM_OTHER");

                    b.Property<string>("IS_SOCIAL_FROM_RED_CROSS");

                    b.Property<string>("IS_SOCIAL_FROM_SOCIETY");

                    b.Property<string>("IS_SOCIAL_GET");

                    b.Property<string>("IS_SOCIAL_SEND");

                    b.Property<string>("IS_SOCIAL_TYPE_BENEFIT");

                    b.Property<string>("IS_SOCIAL_TYPE_OTHER");

                    b.Property<string>("IS_SOCIAL_TYPE_STIPENT");

                    b.Property<string>("IS_SOCIAL_TYPE_VISIT");

                    b.Property<string>("IS_TRANSFER_ABROAD");

                    b.Property<string>("LD");

                    b.Property<string>("MU");

                    b.Property<string>("NOADMIT_CAUSE");

                    b.Property<string>("NOARV_CAUSE");

                    b.Property<string>("OCC_ID");

                    b.Property<string>("OI_PREVENT");

                    b.Property<string>("OLD_TB_ID");

                    b.Property<string>("OTHER_DAY");

                    b.Property<string>("OTHER_DISEASE");

                    b.Property<string>("OTHER_SYMPTOM");

                    b.Property<string>("OTHER_TXT");

                    b.Property<decimal>("PATIENT_ID");

                    b.Property<string>("PMDT_INTERIM_DATE");

                    b.Property<string>("PMDT_INTERIM_DEATH_CAUSE");

                    b.Property<string>("PMDT_INTERIM_DEATH_DATE");

                    b.Property<string>("PMDT_INTERIM_REFER_DATE");

                    b.Property<string>("PMDT_INTERIM_REFER_HOSP_ID");

                    b.Property<string>("PMDT_INTERIM_REMARK");

                    b.Property<string>("PMDT_INTERIM_RESULT");

                    b.Property<string>("PMDT_REGIS_DATE");

                    b.Property<string>("PMDT_REGIS_TYPE");

                    b.Property<string>("PMDT_RESULT");

                    b.Property<string>("PMDT_RX_DATE");

                    b.Property<string>("PMDT_RX_DEATH_CAUSE");

                    b.Property<string>("PMDT_RX_DEATH_DATE");

                    b.Property<string>("PMDT_RX_REFER_DATE");

                    b.Property<string>("PMDT_RX_REFER_HOSP_ID");

                    b.Property<string>("PMDT_RX_REMARK");

                    b.Property<string>("PMDT_RX_RESULT");

                    b.Property<string>("REGIMEN");

                    b.Property<string>("REVER_CAT_TYPE");

                    b.Property<string>("REVER_CAUSE");

                    b.Property<string>("RISK_TB_GROUP_ID");

                    b.Property<string>("RISK_TB_TYPE_ID");

                    b.Property<string>("RX_DATE");

                    b.Property<string>("RX_DEATH_CAUSE");

                    b.Property<string>("RX_DEATH_DATE");

                    b.Property<string>("RX_NEW_DIAG");

                    b.Property<string>("RX_REFER_DATE");

                    b.Property<string>("RX_REFER_HOSP_ID");

                    b.Property<string>("RX_REMARK");

                    b.Property<string>("RX_RESULT");

                    b.Property<string>("SITE_ID");

                    b.Property<string>("SOCIAL_FROM_OTHER");

                    b.Property<string>("SOCIAL_TYPE_OTHER");

                    b.Property<string>("SPACEMEN_ID");

                    b.Property<string>("SPACEMEN_OTH");

                    b.Property<string>("SPACEMEN_RESULT");

                    b.Property<string>("SPUTUM_BLOOD_DAY");

                    b.Property<string>("SPUTUM_COLOR");

                    b.Property<string>("SPUTUM_COLOR_DAY");

                    b.Property<string>("START_DATE");

                    b.Property<string>("TAF_TYPE_ID");

                    b.Property<string>("TBNO")
                        .IsRequired();

                    b.Property<string>("TB_TYPE");

                    b.Property<string>("TIRED_DAY");

                    b.Property<string>("TI_HOSP_ID");

                    b.Property<string>("TYPE_ID");

                    b.Property<int>("UPDATE_BY");

                    b.Property<DateTime>("UPDATE_DATE");

                    b.Property<decimal>("WEIGHT");

                    b.HasKey("TB_ID");

                    b.HasIndex("DATE_REGIS")
                        .HasName("NonClusteredIndex-20171108-140051");

                    b.HasIndex("HOSP_ID", "TBNO", "PATIENT_ID")
                        .HasName("NonClusteredIndex-20170830-095913");

                    b.ToTable("TBL_TB");
                });
#pragma warning restore 612, 618
        }
    }
}
