using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace TB.Models
{
    public class TBL_MS_HOSP_CODE
    {
       // private float _LATITUDE, _LOGITUDE;

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "not null")]
        public string ORG_ID { get; set; }
        [Required(ErrorMessage ="not null")]
        public string ORG_ID_9 { get; set; }
        public string ORG_LEVEL { get; set; }
        public string ORG_TYPE { get; set; }
        public string ORG_TYPE_NHSO { get; set; }
        public string NAME_TH { get; set; }
        public string NAME_EN { get; set; }
        public string ADDR { get; set; }
        public string MU { get; set; }
        public string CHANGWAT { get; set; }
        public string AMPUR { get; set; }
        public string TAMBON { get; set; }
        public string BED { get; set; }
        public string DEPARTMENT { get; set; }
        public string TEL { get; set; }
        public string FAX { get; set; }
        public string NHSO_ID { get; set; }
        public string ODPC_ID { get; set; }
        public string PHO_ID { get; set; }
        public string SSO_ID { get; set; }
        public string IS_MDR_TREAT { get; set; }
        public string IS_CULTURE_TREAT { get; set; }
        public string IS_DST_TREAT { get; set; }
        public string IS_MOLECULAR_TREAT { get; set; }
        public string STATUS { get; set; }
        public double ? LATITUDE
        {
            get;
            set;
        }
        public double ? LOGITUDE
        {
            get;
            set;
        }

        public string IS_CUL_SOLID { get; set; }
        public string IS_CUL_LIQUID { get; set; }
        public string IS_DST_SOLID { get; set; }
        public string IS_DST_LIQUID { get; set; }
        public string IS_MOL_LPA { get; set; }
        public string IS_MOL_XPERT { get; set; }
        public string IS_NHSO_ORG { get; set; }
        public string IS_OUTOF_TBCM { get; set; }
        public string hmain_id { get; set; }


    }
}
