using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace TB.Models
{
    public class TBL_MS_AMPUR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string AMPUR_ID { get; set; }
        public string CHANGWAT_ID { get; set; }
        public string AMPUR_NAME_TH { get; set; }
        public string AMPUR_NAME_EN { get; set; }
        public double? LATITUDE
        {
            get;
            set;
        }
        public double? LONGTITUDE
        {
            get;
            set;
        }
        [Column(TypeName = "text")]
        public string POLYGON { get; set; }
        public string STATUS { get; set; }

    }
}
