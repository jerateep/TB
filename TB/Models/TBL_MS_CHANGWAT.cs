using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace TB.Models
{
    public class TBL_MS_CHANGWAT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string CHANGWAT_ID { get; set; }
        public string COUNTRY_ID { get; set; }
        public string CHANGWAT_NAME_TH { get; set; }
        public string CHANGWAT_NAME_EN { get; set; }
        public string ZONE { get; set; }
        public string ODPC_ID { get; set; }
        public string NHSO_ID { get; set; }
        public string STATUS { get; set; }

    }
}
