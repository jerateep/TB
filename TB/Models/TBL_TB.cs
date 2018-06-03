using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace TB.Models
{
    public class TBL_TB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal TB_ID { get; set; }
        [Required]
        public string HOSP_ID { get; set; }
        public string TB_TYPE { get; set; }
        [Required]
        public string TBNO { get; set; }
        public string DATE_REGIS { get; set; }
        public decimal PATIENT_ID { get; set; }
        public string HN { get; set; }
        public int AGE_Y { get; set; }
        public int AGE_M { get; set; }
        public decimal WEIGHT { get; set; }
        public string INSCL_ID { get; set; }
        public string OCC_ID { get; set; }
        public string HOME_TYPE { get; set; }
        public string ADDR { get; set; }
        public string MU { get; set; }
        public string SITE_ID { get; set; }
        public string START_DATE { get; set; }
        public string CLASSIFY { get; set; }
        public string CLASSIFY_EP_ID { get; set; }
        public string CLASSIFY_EP_OTH { get; set; }
        public string SPACEMEN_ID { get; set; }
        public string SPACEMEN_OTH { get; set; }
        public string SPACEMEN_RESULT { get; set; }
        public string TYPE_ID { get; set; }
        public string TAF_TYPE_ID { get; set; }
        public string TI_HOSP_ID { get; set; }
        public string REGIMEN { get; set; }
        public string DRUG { get; set; }
        public string DRUG_TYPE { get; set; }
        public string COMBINE_DRUG { get; set; }
        public string REVER_CAT_TYPE { get; set; }
        public string REVER_CAUSE { get; set; }
        public string DOT_BY { get; set; }
        public string BCG { get; set; }
        public string HISTORY_TREATED { get; set; }
        public string HISTORY_TREATED_RESULT { get; set; }
        public string DRUGREACT { get; set; }
        public string COPD { get; set; }
        public string CKD { get; set; }
        public string LD { get; set; }
        public string CA { get; set; }
        public string DM { get; set; }
        public string HT { get; set; }
        public string OTHER_DISEASE { get; set; }
        public string OTHER_TXT { get; set; }
        public string ADMIT_TYPE { get; set; }
        public string AN { get; set; }
        public string ADMIT_DATE { get; set; }
        public string DISCHARGE_DATE { get; set; }
        public string AFB_DC { get; set; }
        public string NOADMIT_CAUSE { get; set; }
        public string COUGH_DAY { get; set; }
        public string SPUTUM_COLOR { get; set; }
        public string SPUTUM_COLOR_DAY { get; set; }
        public string SPUTUM_BLOOD_DAY { get; set; }
        public string CHEST_PAIN_DAY { get; set; }
        public string TIRED_DAY { get; set; }
        public string FEVER_DAY { get; set; }
        public string OTHER_SYMPTOM { get; set; }
        public string OTHER_DAY { get; set; }
        public string HIV_ADVISE { get; set; }
        public string HIV_DIAG { get; set; }
        public string HIV_DIAG_DATE { get; set; }
        public string HIV_RESULT { get; set; }
        public string CD4_DATE_1 { get; set; }
        public string CD4_RESULT_1 { get; set; }
        public string CD4_DATE_2 { get; set; }
        public string CD4_RESULT_2 { get; set; }
        public string OI_PREVENT { get; set; }
        public string ARV_DRUG { get; set; }
        public string ARV_DATE { get; set; }
        public string NOARV_CAUSE { get; set; }
        public string HIV_MEET { get; set; }
        public string INTERIM_RESULT { get; set; }
        public string INTERIM_DATE { get; set; }
        public string INTERIM_DEATH_CAUSE { get; set; }
        public string INTERIM_DEATH_DATE { get; set; }
        public string INTERIM_REFER_DATE { get; set; }
        public string INTERIM_REFER_HOSP_ID { get; set; }
        public string INTERIM_REMARK { get; set; }
        public string RX_RESULT { get; set; }
        public string RX_DATE { get; set; }
        public string RX_DEATH_CAUSE { get; set; }
        public string RX_DEATH_DATE { get; set; }
        public string RX_REFER_DATE { get; set; }
        public string RX_REFER_HOSP_ID { get; set; }
        public string RX_REMARK { get; set; }
        public string RX_NEW_DIAG { get; set; }
        public string PMDT_RESULT { get; set; }
        public string IS_PRISONER { get; set; }
        public string IS_HEALTH_OFFICER { get; set; }
        public string RISK_TB_GROUP_ID { get; set; }
        public string RISK_TB_TYPE_ID { get; set; }
        public string ICD10_ID { get; set; }
        public string INDEX_TB_ID { get; set; }
        public string OLD_TB_ID { get; set; }
        public string IS_MDR { get; set; }
        public string PMDT_REGIS_DATE { get; set; }
        public string PMDT_REGIS_TYPE { get; set; }
        public string PMDT_INTERIM_RESULT { get; set; }
        public string PMDT_INTERIM_DATE { get; set; }
        public string PMDT_INTERIM_DEATH_CAUSE { get; set; }
        public string PMDT_INTERIM_DEATH_DATE { get; set; }
        public string PMDT_INTERIM_REFER_DATE { get; set; }
        public string PMDT_INTERIM_REFER_HOSP_ID { get; set; }
        public string PMDT_INTERIM_REMARK { get; set; }
        public string PMDT_RX_RESULT { get; set; }
        public string PMDT_RX_DATE { get; set; }
        public string PMDT_RX_DEATH_CAUSE { get; set; }
        public string PMDT_RX_DEATH_DATE { get; set; }
        public string PMDT_RX_REFER_DATE { get; set; }
        public string PMDT_RX_REFER_HOSP_ID { get; set; }
        public string PMDT_RX_REMARK { get; set; }
        public string AFB0_DATE { get; set; }
        public string AFB0_LABNO { get; set; }
        public string AFB0_RESULT { get; set; }
        public string IS_TRANSFER_ABROAD { get; set; }
        public string ABROAD_COUNTRY { get; set; }
        public string ABROAD_OTHER { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public int CREATE_BY { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public int UPDATE_BY { get; set; }
        public string IS_SOCIAL_SEND { get; set; }
        public string IS_SOCIAL_GET { get; set; }
        public string IS_SOCIAL_FROM_SOCIETY { get; set; }
        public string IS_SOCIAL_FROM_HOSPITAL { get; set; }
        public string IS_SOCIAL_FROM_DLA { get; set; }
        public string IS_SOCIAL_FROM_RED_CROSS { get; set; }
        public string IS_SOCIAL_FROM_OTHER { get; set; }
        public string SOCIAL_FROM_OTHER { get; set; }
        public string IS_SOCIAL_TYPE_BENEFIT { get; set; }
        public string IS_SOCIAL_TYPE_STIPENT { get; set; }
        public string IS_SOCIAL_TYPE_VISIT { get; set; }
        public string IS_SOCIAL_TYPE_OTHER { get; set; }
        public string SOCIAL_TYPE_OTHER { get; set; }

    }
}
